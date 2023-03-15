using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Location
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<Service> Services { get; set; }

        public override string ToString()
        {
            string listOfService = "";
            foreach (Service service in Services) 
            {
                listOfService += service.ToString() + "\n";
            }
            return $"{Name}\nServices:\n{listOfService}";
        }
    }
}
