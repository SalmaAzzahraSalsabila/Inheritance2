using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "MIke";
            person.Age = 20;
            person.GetNameAndAge();

            Teacher teacher = new Teacher();
            teacher.Name = "Thomas";
            teacher.Age = 35;
            teacher.TeacherId = "190302";
            teacher.Subject = "Math";
            teacher.GetNameAndAge();

            Students students = new Students();
            students.Name = "Sara";
            students.Age = 19;
            students.StudentsId = "10506";
            students.Email = "sara1234@amikom.ac.id";
            students.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
