using Carter;
using MayTheFourth.Domain.Interfaces.Repositories;

namespace MayTheFourth.API.Endpoints;

public class VeiculoEndpoints : CarterModule
{
    public VeiculoEndpoints() : base("/v2/veiculos") { }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/", async (IVeiculoRepository veiculoRepository) =>
        {
            var filmes = await veiculoRepository.ListAsync();
            return Results.Ok(filmes);
        });
    }
}
