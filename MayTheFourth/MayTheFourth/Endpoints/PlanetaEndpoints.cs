using Carter;
using MayTheFourth.Domain.Interfaces.Repositories;

namespace MayTheFourth.API.Endpoints;

public class PlanetaEndpoints : CarterModule
{
    public PlanetaEndpoints() : base("/v2/planetas") { }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/", async (IPlanetaRepository planetaRepositorymRepository) =>
        {
            var filmes = await planetaRepositorymRepository.ListAsync();
            return Results.Ok(filmes);
        });
    }
}
