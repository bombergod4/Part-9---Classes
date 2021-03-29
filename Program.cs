using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_9___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            //Student person = new Student("Joe", "Mama");
            //Console.WriteLine(person.Firstname);
            //person.Firstname = "Deez";
            //Console.WriteLine(person.Firstname);
            //Console.WriteLine(person);
            //person.ResetStudentNumber();
            //Console.WriteLine(person);
            students.Add(new Student("Deez", "Nuts"));
            students.Add(new Student("Ben", "Dover"));
            students.Add(new Student("Candice", "Bereel"));

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }
            for (int i = 0; i < 2; i ++)
            {
                Console.WriteLine("Enter a first name, then a last name");
                students.Add(new Student (Console.ReadLine(), Console.ReadLine()));
                Console.WriteLine(students[i+3]);
            }
            for (int i = 0; i == students.Count; i ++)
            {
                Console.WriteLine(students[i]);
            }
               

        }
    }
}
