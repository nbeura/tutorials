using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student;
            student = new Student("Student","ESSPL");

            

            //Student student = new Student();

            //student.firstName = "Student";
            //student.lastName = "ESSPL";


            string fullName = student.getFullName();
            Console.WriteLine(fullName);


            Student student1 = new Student();
            student1.firstName = "Student 1";
            student1.lastName = "ESSPL";

            Console.ReadKey();
        }

    }
}
