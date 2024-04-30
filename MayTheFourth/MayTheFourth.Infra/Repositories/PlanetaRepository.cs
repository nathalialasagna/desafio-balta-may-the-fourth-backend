using MayTheFourth.Domain.Entities;
using MayTheFourth.Domain.Interfaces.Repositories;
using MayTheFourth.Infra.Context;

namespace MayTheFourth.Infra.Repositories;

public class PlanetaRepository : Repository<Planeta>, IPlanetaRepository
{
    public PlanetaRepository(MayTheFourthDataContext context) : base(context)
    {
    }
}
