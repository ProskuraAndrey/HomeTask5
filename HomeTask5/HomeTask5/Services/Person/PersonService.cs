using HomeTask5.Services.Person;

namespace HomeTask5.Services.Person
{
    public class PersonService : IPersonService
    {
        public PersonService(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lasName = lastName;
            _age = age;
        }

        private string _firstName;
        private string _lasName;
        private int _age;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lasName; set => _lasName = value; }
        public int Age { get => _age; set => _age = value; }

        public virtual void Action() { }
    }
}
