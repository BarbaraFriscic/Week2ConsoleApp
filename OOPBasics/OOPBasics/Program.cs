using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Location zagreb = new Location();
            zagreb.Name = "Zagreb";
            zagreb.Address = new Address { Country = "Croatia", City = "Zagreb", Zip = "10000", Street = "Kralja Zvonimira 18" };
            
            Service haircut1 = new Service();
            haircut1.Name = "Short Hair Cut";
            haircut1.Price = 100;
            haircut1.Category = new Category { Id = Guid.NewGuid(), Name = "Haircut" };

            Client firstClient = new Client
            {
                FirstName = "Maja",
                LastName = "Ivanović",
                Id = Guid.NewGuid(),
                Address = new Address { City = "Zagreb" }
            };

        }
    }
}
