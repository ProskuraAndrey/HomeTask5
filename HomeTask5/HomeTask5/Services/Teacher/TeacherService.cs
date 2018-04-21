using System;
using HomeTask5.Services.Person;
using System.Collections.Generic;

namespace HomeTask5.Services.Teacher
{
    public class TeacherService : PersonService
    {
        public TeacherService(string firstName, string lastName, int age) : base(firstName, lastName, age)
        { }

        private Departments _departmentEmployee;
        public Departments DepartmentEmployee
        {
            get { return _departmentEmployee; }
            set { _departmentEmployee = value; }
        }

        private Subjects _taughtSubject;
        public Subjects TaughtSubject
        {
            get { return _taughtSubject; }
            set { _taughtSubject = value; }
        }

        public override void Action() { }
    }
}
