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
            var filmes = await navesEstelaresRepository.ListAsync();
            return Results.Ok(filmes);
        });
    }
}
