using HomeTask5.Services.Student;
using HomeTask5.Services.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentService ss = new StudentService("Ivanov", "Ivan",15);

            TeacherService ts = new TeacherService("Sidorov", "Kiril", 45);

            Console.ReadLine();
        }
    }
}
