using CrudOperation.Models;
using CrudOperation.Repositoy;
using System.Linq.Expressions;

namespace CrudOperation.Service;

public class SubjectService
{
    public readonly ISubjectRepository _subjectRepository;
    public SubjectService(SubjectRepository subjectRepository)
    {
        this._subjectRepository = subjectRepository; 
    }
    public async Task CresteSub(Subject subject)
    {
        var res = await _subjectRepository.CreateAsync(subject);
    }
    public async Task<Subject> UpdateSub(Subject subject)
    {
        return await _subjectRepository.UpdateAsync(subject);
    }
    public async Task<IEnumerable<Subject>> GetAll(Expression<Func<Subject, bool>> expression = null)
    {
       return await _subjectRepository.GetAll(expression);
    }
    public async Task Delete(Subject subject)
    {
        await _subjectRepository.DeleteAsync(subject);
    }

}
