using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> employeesZagreb = new List<Employee>();
            //List<Location> locations = new List<Location>();
            //string fName;
            //string lName;
            //string position;
            //int counter=0;
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Unesite podatke za zaposlenika");
            //    Console.WriteLine("Ime:");
            //    fName = Console.ReadLine();
            //    Console.WriteLine("Prezime:");
            //    lName = Console.ReadLine();
            //    Console.WriteLine("pozicija");
            //    position = Console.ReadLine();
            //    Employee employee = new Employee(Guid.NewGuid(), fName, lName, position, DateTime.Now);
            //    employeesZagreb.Add(employee);
            //    counter++;
            //} while (counter < 3);

            //Console.WriteLine("Unijeli ste tri nova zaposlenika:");
            //foreach (Employee employee in employeesZagreb)
            //{
            //    Console.WriteLine(employee.GetEmployeeInfo() + "\n");
            //}

            //Console.WriteLine("Pritisnite bilo koju tipku za nastavak");
            //string escKey = Console.ReadLine();
            //if (escKey != null) 
            //{
            //    Console.Clear();
            //}
            //Location zagreb = new Location
            //{
            //    Id = Guid.NewGuid(),
            //    Name = "Zagreb",
            //    Employees = employeesZagreb,
            //    GroupTraining= true
            //};
            //Location osijek = new Location
            //{
            //    Id = Guid.NewGuid(),
            //    Name = "Osijek",
            //    PersonalTrainer = true,
            //    GroupTraining = true
            //};
            //Location zadara = new Location
            //{
            //    Id = Guid.NewGuid(),
            //    Name = "Zadar"
            //};
            //locations.Add(osijek);
            //locations.Add(zadara);
            //locations.Add(zagreb);
            //Console.WriteLine("Teretana je dostupna na sljedećim lokacijama:");
            //foreach (Location location in locations)
            //{
            //    Console.WriteLine(location.ToString() + "\n");
            //}


            string folderPath = "C:\\Users\\Barbara\\Documents\\Week2ConsoleApp\\FridayDocuments";
            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            string fileName = "FirstFile.txt";
            string filePath = $"{folderPath}\\{fileName}";
            if(!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                {  
                    stream.Flush();
                    stream.Close();
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("This is a first test input into a file.");

                }
            }
            catch (Exception ex)
            {

                Console.Error.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}
