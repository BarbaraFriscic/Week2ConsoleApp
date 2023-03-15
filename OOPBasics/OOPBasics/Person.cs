using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public abstract class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        protected string OIB {get; set;}

        public virtual string GetAddress()
        {
            return $"{Address.Street}, {Address.Zip} {Address.City} - {Address.Country}";
        }
    }
}
