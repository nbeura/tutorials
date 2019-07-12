using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleOOP
{
    class Student
    {
        public string firstName;
        public string lastName;

        public Student()
        {

        }

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string getFullName()
        {
            //return firstName + " " + lastName;
            //return string.Format("{0} {1}", firstName, lastName);
            return $"{firstName} {lastName}";
        }

        ~Student()
        {

        }
    }
}
