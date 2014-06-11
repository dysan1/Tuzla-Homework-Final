using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuzla_Final_Homework_Sandy_Smajic
{
    class Program
    {
        public static List<Student> students = new List<Student>(); // List for students
        static void Main(string[] args)
        {
            students.Add(new Student("John", "mail", 18));
            students.Add(new Student("Chris", "mail", 20));
            students.Add(new Student("Seth", "mail", 22));


            students.Sort();
            foreach (Student n in students)
            {
                Console.WriteLine(n.name);
            }
            Console.ReadLine();
        }
    }
}
