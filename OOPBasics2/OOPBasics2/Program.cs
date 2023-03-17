using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics2
{
    internal class Program
    {
        public static void CopyFromOneFileToAnother(string filePathCopyFrom, string filePathCopyTo)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(filePathCopyFrom))
                {
                    using (StreamWriter streamWriter = File.AppendText(filePathCopyTo))
                    {
                        streamWriter.WriteLine("ATTEMPTING TO COPY FROM ONE FILE TO ANOTHER");
                        streamWriter.WriteLine(streamReader.ReadToEnd());
                        
                    }
                }
            }
            catch (Exception ex)
            {

                Console.Error.WriteLine(ex.Message);
            }
        }
        public static void CreateFile(string filePath, string inputText)
        {
            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                {
                    stream.Flush();
                    stream.Close();
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(inputText);

                }
            }
            catch (Exception ex)
            {

                Console.Error.WriteLine(ex.Message);
            }
        }

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
    //Friday

            string folderPath = "C:\\Users\\Barbara\\Documents\\Week2ConsoleApp\\FridayDocuments";
            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            string firstFileName = "FirstFile.txt";
            string firstFilePath = $"{folderPath}\\{firstFileName}";
            if(!File.Exists(firstFilePath))
            {
                File.Create(firstFilePath);
            }

            //CreateFile(firstFilePath, "This is a fourth test input into a file.");
                     
            //string inputString = "Hello, new line";
            //File.AppendAllText(firstFilePath, inputString);

            string secondFileName = "SecondFile.txt";
            string secondFilePath = $"{folderPath}\\{secondFileName}";
            if (!File.Exists(secondFilePath))
            {
                File.Create(secondFilePath);
            }
           
            //CopyFromOneFileToAnother(secondFilePath, firstFilePath);

       //PdfSharp     
            string pdfFileName = "FirstPdfDocument.pdf";
            string pdfFilePath = $"{folderPath}\\{pdfFileName}";

            using (MemoryStream stream = new MemoryStream())
            {
                using (FileStream fileStream = new FileStream(secondFilePath, FileMode.Open))
                {
                    fileStream.CopyTo(stream);
                }
                PdfService.GenerateNewPdfFileFromStream(pdfFilePath, stream);
            }

            //PdfService.GenerateNewPdfFileFromString(pdfFilePath, "New string in a pdf file.");



            Console.ReadKey();

        }
    }
}
