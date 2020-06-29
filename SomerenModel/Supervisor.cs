using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Supervisor
    {
        public int LecturerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //constructor 
        public Supervisor(int lecturerID, string firstName, string lastName)
        {
            LecturerID = lecturerID;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
