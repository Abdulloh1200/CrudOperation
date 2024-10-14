using CrudOperation.Context;
using CrudOperation.Models;

namespace CrudOperation.Repositoy;

public class PersonRepository : Repository<Person> , IPersonRepository
{
        private readonly AppDbContext _appDbContext;
     public PersonRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }
}
