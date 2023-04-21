using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        Address Address { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
        DateTime DOB { get; set; }

        string GetAddress();

        
    }
}
