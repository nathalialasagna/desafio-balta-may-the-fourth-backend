using Carter;
using MayTheFourth.Domain.Interfaces.Repositories;

namespace MayTheFourth.API.Endpoints;

public class NavesEstelaresEndpoints : CarterModule
{
    public NavesEstelaresEndpoints() : base("/v2/navesEstelares") { }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/", async (INavesEstelaresRepository navesEstelaresRepository) =>
        {
            var naves = await navesEstelaresRepository.ListAsync();
            return Results.Ok(naves);
        });

        app.MapGet("/{idNave:int}", async (int idNave, INavesEstelaresRepository navesEstelaresRepository) =>
        {
            var nave = await navesEstelaresRepository.GetAsync(n => n.Id == idNave);

            if(nave == null) return Results.NotFound();

            return Results.Ok(nave);
        });
    }
}
