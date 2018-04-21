

namespace HomeTask5.Services.Person
{
    public interface IPersonService
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        void Action();
    }
}
