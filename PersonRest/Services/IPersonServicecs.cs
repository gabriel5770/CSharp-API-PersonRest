
using PersonRest.Model;

namespace PersonRest.Services
{
    public interface IPersonServicecs
    {
        Person Create(Person person); 
        Person FindBydID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);

    }
}
