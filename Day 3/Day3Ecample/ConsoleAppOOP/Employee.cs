using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP
{
    class Employee
    {
        string firstName;
        string lastName;

        public void printFullName()
        {
            Console.WriteLine("{0} {1}", firstName, lastName);
        }
    }

    class ParmanentEmployee : Employee
    {

    }

    class TemporaryEmployee
    {

    }
}
