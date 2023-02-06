using PersonRest.Model;
using PersonRest.Model.Context;

namespace PersonRest.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private MySQLContext _context;

        public PersonServiceImplementation(MySQLContext context)
        {
            _context = context;
        }
        public Person Create(Person person)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindAll()
        {
            
            return _context.persons.ToList();
        }

        public Person FindBydID(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Gabriel",
                LastName = "Dos Santos Vieira",
                Gender = "Masculino",
                Address = "Polvilho-cajamar"

            };
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
