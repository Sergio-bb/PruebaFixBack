using Entity;
using Infraextrcuture.Repository;
using Infraextructure.Repository;
using IRepository;


namespace Repository
{
    public class RecuestRepository : RepositoryBase<Recuest>, IRecuestRepository

    {
        public RecuestRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
