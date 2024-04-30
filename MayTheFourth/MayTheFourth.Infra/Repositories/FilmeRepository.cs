using MayTheFourth.Domain.Entities;
using MayTheFourth.Domain.Interfaces.Repositories;
using MayTheFourth.Infra.Context;

namespace MayTheFourth.Infra.Repositories;

public class FilmeRepository : Repository<Filme>, IFilmeRepository
{
    public FilmeRepository(MayTheFourthDataContext context) : base(context)
    {
    }
}
