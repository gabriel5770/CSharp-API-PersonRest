using PersonRest.Model;

namespace PersonRest.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
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
            List<Person> list = new List<Person>();
            for(int i = 0; i< 1; i++ )
            {
                list.Add(new Person()
                {
                    Id = 1,
                    FirstName = "Gabriel",
                    LastName = "Dos Santos Vieira",
                    Gender = "Masculino",
                    Address = "Polvilho-cajamar"
                });
            }
            return list;
        }

        public Person FindBydID(long id)
        {
            return new Person
            {
                Id=1,
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
