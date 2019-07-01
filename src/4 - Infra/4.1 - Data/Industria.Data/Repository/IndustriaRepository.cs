using Industria.Data.Context;
using Industria.Domain.Entities.Interfaces;

namespace Industria.Data.Repository
{
    public class IndustriaRepository : Repository<Industria.Domain.Entities.Industria>
    {
        public IndustriaRepository(IndustriaContext context) : base(context)
        {
        }
    }
}