using CrudOperation.Context;
using CrudOperation.Models;

namespace CrudOperation.Repositoy;

public class SubjectRepository : Repository<Subject> , ISubjectRepository
{
    private readonly AppDbContext _appDbContext;
    public SubjectRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }

}
