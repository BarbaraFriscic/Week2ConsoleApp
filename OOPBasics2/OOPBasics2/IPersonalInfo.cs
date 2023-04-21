using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics2
{
    internal interface IPersonalInfo
    {
         string FirstName { get; set; }
         string LastName { get; set; }
         string Email { get; set; }
         string Address { get; set; }
         DateTime DOB { get; set; }
         string Phone { get; set; }
    }
}
