using Carter;
using MayTheFourth.Domain.Interfaces.Repositories;

namespace MayTheFourth.API.Endpoints;

public class FilmeEndpoints : CarterModule
{
    public FilmeEndpoints() : base("/filmes")
    {
        WithTags("filmes");
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/", async (IFilmeRepository filmeRepository) =>
        {
            var filmes = await filmeRepository.ListAsync();
            return Results.Ok(filmes);
        });

        app.MapGet("/{idFilme:int}", async (int idFilme, IFilmeRepository filmeRepository) =>
        {
            var filme = await filmeRepository.GetAsync(f => f.Id == idFilme);

            if (filme == null) return Results.NotFound();

            return Results.Ok(filme);
        });
    }
}
