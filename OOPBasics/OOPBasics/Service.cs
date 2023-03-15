using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Service
    {
        [Required(AllowEmptyStrings = false)]     
        public string Name { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Name} -- {Price}";
        }
    }
}
