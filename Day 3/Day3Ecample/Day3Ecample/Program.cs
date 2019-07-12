using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Ecample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Arghya","Biswas");

            Console.WriteLine("{0}", student.getFullName());

            Console.ReadKey();
        }
    }
}
