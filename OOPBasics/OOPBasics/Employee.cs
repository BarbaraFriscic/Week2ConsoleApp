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
    }
}
