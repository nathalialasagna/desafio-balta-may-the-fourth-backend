using Carter;
using MayTheFourth.Domain.Interfaces.Repositories;

namespace MayTheFourth.API.Endpoints;

public class PlanetaEndpoints : CarterModule
{
    public PlanetaEndpoints() : base("/planetas")
    {
        WithTags("planetas");
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/", async (IPlanetaRepository planetaRepositorymRepository) =>
        {
            var planetas = await planetaRepositorymRepository.ListAsync();
            return Results.Ok(planetas);
        });

        app.MapGet("/{idPlaneta:int}", async (int idPlaneta, IPlanetaRepository planetaRepositorymRepository) =>
        {
            var planeta = await planetaRepositorymRepository.GetAsync(p => p.Id == idPlaneta);

            if (planeta == null) return Results.NotFound();

            return Results.Ok(planeta);
        });
    }
}
