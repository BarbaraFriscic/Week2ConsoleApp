using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Client :Person
    {
        public Guid Id { get; set; }

        public override string GetAddress()
        {
            return $"{Address.City}";
        }
    }
}
