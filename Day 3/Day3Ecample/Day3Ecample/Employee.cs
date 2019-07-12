using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Ecample
{
    class Employee
    {
        public string firstName;
        public string lastName;

        public Employee()
        {

        }
        

        public string getFullName()
        {
            return $"{this.firstName} {this.lastName}";
        }
    }

    class PartTimeEmployee : Employee
    {
        // Hidin Base Class Methods
        public new string getFullName()
        {
            // Calling base Method
            // base.getFullName()

            // Other way is Type Casting
            //((Employee)employee).getFullName();

            // Another way is to declaring base class variable
            //Employee employee = new PartTimeEmployee()
            return $"{base.firstName} {base.lastName} - Contractor";
        }

        
    }

    class FullTimeEmployee:Employee
    {

    }
}
