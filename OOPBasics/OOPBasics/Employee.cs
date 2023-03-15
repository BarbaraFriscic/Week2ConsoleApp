using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Employee : Person
    {
        public Guid Id { get; set; }
        public DateTime DateOfEmployment { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}\n{FirstName} {LastName}\nEmployment date: {DateOfEmployment}\nAddress: {Address}\nDOB: {DOB}\nEmail: {Email}";
        }
    }
}
