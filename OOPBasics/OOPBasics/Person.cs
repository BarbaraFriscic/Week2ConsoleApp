using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public abstract class Person : IPerson
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        protected string OIB {get; set;}

        public virtual string GetAddress()
        {
            return $"{Address.Street}, {Address.Zip} {Address.City} - {Address.Country}";
        }
        public static Address SetAddres(string street, string city)
        {
            return new Address { Street = street, City = city };
        }
        public Address SetAddress(string city)
        {
            return new Address { City = city };
        }
        public Address SetAddress(string street, string city, string zip, string country)
        {
            return new Address { Street = street, City = city , Zip = zip , Country = country };
        }
    }
}
