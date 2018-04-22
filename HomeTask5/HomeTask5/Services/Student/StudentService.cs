using System;
using HomeTask5.Services.Person;


namespace HomeTask5.Services.Student
{
    public class StudentService : PersonService
    {
        private Course _course;

        public Subjects _subjects { get; set; }
        public GroupOfStudents GroupOfStudents { get; set; }

        public Course CurrentCourse
        {
            get { return _course; }
            set { _course = value; }
        }

        public StudentService(string firstName, string lastName, int age) : base(firstName,lastName,age)
        {
            _subjects = new Subjects();
        }

        public override void Action()
        {

        }
    }
}
