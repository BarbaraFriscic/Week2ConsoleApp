using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    internal class Program
    {
        //public static void Validate(object model)
        //{
        //    string errorMessage = "";
        //    List<ValidationResult> results = new List<ValidationResult>();
        //    ValidationContext context = new ValidationContext(model);
        //    bool isValid = Validator.TryValidateObject(model, context, results, true);
        //    if(!isValid)
        //    {
        //        foreach (ValidationResult result in results) 
        //        {
        //            errorMessage += result.ErrorMessage +"\n";
        //        }
        //        throw new Exception(errorMessage);
        //    }
        //}

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
                Address = Client.SetAddres("Ivana Gundulića 18A", "Osijek") // static metoda
            };

            //Console.WriteLine($"{firstClient.Address.Street.ToString()}\n{firstClient.Address.City.ToString()}");

            //Console.WriteLine("Update city:");
            //firstClient.Address = firstClient.SetAddress("Zagreb"); // nije static metoda
            //Console.WriteLine(firstClient.Address.City.ToString());

            //Console.WriteLine("Unesite podatke za novu uslugu");
            //string escKey = "x";
            //List<Service> servicesList = new List<Service>();
            //do
            //{
            //    Service newService = new Service();
            //    Console.WriteLine("Ime usluge:");
            //    newService.Name = Console.ReadLine();
            //    Console.WriteLine("Unesite cijenu usluge:");
            //    newService.Price = Convert.ToDecimal(Console.ReadLine());
            //    servicesList.Add(newService);
            //    Console.WriteLine("Ako želite završiti unos pritisnite x. Za nastavk unosa pritisnite bilo koju tipku.");
            //    escKey = Console.ReadLine();
            //} while (escKey != "x");

            //foreach (Service service in servicesList)
            //{
            //    Console.WriteLine(service.ToString());
            //}

            //Employee firstEmployee = new Employee
            //{
            //    Id = Guid.NewGuid(),
            //    DateOfEmployment = DateTime.Now,
            //    DOB = new DateTime(1993, 12, 27),

            //};
            //try
            //{
            //    Console.WriteLine("Unesite ime zaposlenika:");
            //    firstEmployee.FirstName = Console.ReadLine();


            //    Console.WriteLine("Unesite prezime zaposlenika:");
            //    firstEmployee.LastName = Console.ReadLine();


            //    Console.WriteLine("Unesite email zaposlenika");
            //    firstEmployee.Email = Console.ReadLine();
            //    //Validate(firstEmployee);

            //    Console.Write(firstEmployee.ToString());

            //}
            //catch (Exception ex)
            //{

            //    Console.Error.WriteLine(ex.Message);
            //    Console.ReadLine();
            //    Console.Clear();
            //   // Program.Main(args);
            //}
            //Console.WriteLine("Unesite ime zaposlenika:");
            //firstEmployee.FirstName = Console.ReadLine();
            //Console.WriteLine("Unesite prezime zaposlenika:");
            //firstEmployee.LastName = Console.ReadLine();
            //Console.WriteLine("Unesite email zaposlenika");
            //firstEmployee.Email = Console.ReadLine();

            //Console.Write(firstEmployee.ToString());

            // Person person = new Person(); //Ne može instancirati objekt apstraktne klase

            Console.WriteLine("Unesite podatke za novu uslugu");
            string escKey = "x";
            
            List<Service> servicesList = new List<Service>();
            zagreb.Services = servicesList;
            do
            {
                Service newService = new Service();
                Console.WriteLine("Ime usluge:");
                newService.Name = Console.ReadLine();
                Console.WriteLine("Unesite cijenu usluge:");
                newService.Price = Convert.ToDecimal(Console.ReadLine());
                servicesList.Add(newService);
                Console.WriteLine("Ako želite završiti unos pritisnite x. Za nastavk unosa pritisnite bilo koju tipku.");
                escKey = Console.ReadLine();
            } while (escKey != "x");

            Console.WriteLine(zagreb.ToString());
            

            Console.ReadKey();
        }
    }
}
