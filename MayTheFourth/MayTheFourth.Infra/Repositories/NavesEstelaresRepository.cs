using MayTheFourth.Domain.Entities;
using MayTheFourth.Domain.Interfaces.Repositories;
using MayTheFourth.Infra.Context;

namespace MayTheFourth.Infra.Repositories;

public class NavesEstelaresRepository : Repository<NavesEstelares>, INavesEstelaresRepository
{
    public NavesEstelaresRepository(MayTheFourthDataContext context) : base(context)
    {
    }
}
