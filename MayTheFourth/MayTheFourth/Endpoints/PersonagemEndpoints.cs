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
            var personagens = await personagemRepository.ListAsync();
            return Results.Ok(personagens);
        });

        app.MapGet("/{idPersonagem:int}", async (int idPersonagem, IPersonagemRepository personagemRepository) =>
        {
            var personagem = await personagemRepository.GetAsync(p => p.Id == idPersonagem);

            if (personagem == null) return Results.NotFound();

            return Results.Ok(personagem);
        });
    }
}
