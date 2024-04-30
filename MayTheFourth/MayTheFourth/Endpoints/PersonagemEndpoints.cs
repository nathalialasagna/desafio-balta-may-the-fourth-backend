using Carter;
using MayTheFourth.Domain.Interfaces.Repositories;

namespace MayTheFourth.API.Endpoints;

public class PersonagemEndpoints : CarterModule
{
    public PersonagemEndpoints() : base("/v2/personagens") { }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/", async (IPersonagemRepository personagemRepository) =>
        {
            var filmes = await personagemRepository.ListAsync();
            return Results.Ok(filmes);
        });
    }
}
