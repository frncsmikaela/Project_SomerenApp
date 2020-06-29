using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }

        //constrcutor
        public Teacher(string firstName, string lastName, int number)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
        }
    }
}
