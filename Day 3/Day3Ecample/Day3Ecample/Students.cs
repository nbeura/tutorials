using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Ecample
{
    class Student
    {
        string firstName;
        string lastName;

        public Student()
            :this("No First Name specified","No Last Name Specified")
        {

        }
        public Student(string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string getFullName()
        {
            return $"{this.firstName} {this.lastName}";
        }

        ~Student()
        {

        }
    }
}
