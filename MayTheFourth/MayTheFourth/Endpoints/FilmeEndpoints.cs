﻿using Carter;
using MayTheFourth.Domain.Interfaces.Repositories;

namespace MayTheFourth.API.Endpoints;

public class FilmeEndpoints : CarterModule
{
    public FilmeEndpoints() : base("/v2/filmes") { }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/", async (IFilmeRepository filmeRepository) =>
        {
            var filmes = await filmeRepository.ListAsync();
            return Results.Ok(filmes);
        });
    }
}
