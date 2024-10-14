using CrudOperation.Models;
using CrudOperation.Repositoy;
using System.Linq.Expressions;

namespace CrudOperation.Service;
public class PersonService
{
    public readonly IPersonRepository _personRepository;

    public PersonService(PersonRepository personRepository)
    {
        this._personRepository = personRepository;
    }

    public async Task<IEnumerable<Person>> GetAll(Expression<Func<Person, bool>> expression = null)
    {
        return await _personRepository.GetAll(expression);
    }

    public async Task<Person> Create(Person person)
    {
        return await _personRepository.CreateAsync(person);
    }
    public async Task<Person> Update(Person person)
    {
        return await _personRepository.UpdateAsync(person);
    }
    public async Task Delete(Person person)
    {
        await _personRepository.DeleteAsync(person);
    }
}