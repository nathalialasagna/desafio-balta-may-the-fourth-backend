using MayTheFourth.Domain.Entities;
using MayTheFourth.Domain.Interfaces.Repositories;
using MayTheFourth.Infra.Context;

namespace MayTheFourth.Infra.Repositories;

public class PersonagemRepository : Repository<Personagem>, IPersonagemRepository
{
    public PersonagemRepository(MayTheFourthDataContext context) : base(context)
    {
    }
}
