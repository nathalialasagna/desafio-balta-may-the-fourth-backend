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
            var veiculos = await veiculoRepository.ListAsync();
            return Results.Ok(veiculos);
        });

        app.MapGet("/{idVeiculo:int}", async (int idVeiculo, IVeiculoRepository veiculoRepositoryy) =>
        {
            var veiculo = await veiculoRepositoryy.GetAsync(v => v.Id == idVeiculo);

            if (veiculo == null) return Results.NotFound();

            return Results.Ok(veiculo);
        });
    }
}
