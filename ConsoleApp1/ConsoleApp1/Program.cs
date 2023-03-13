using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result;
            double sqrResult;
            int inputNum;
            double inputNumDec;

            //Console.WriteLine("Unesite prirodan broj");

            //Int32.TryParse(Console.ReadLine(), out inputNum);


            //if (inputNum != 0)
            //{
            //    sqrResult = Convert.ToInt32(Math.Sqrt(inputNum));
            //    result = $"Korijen broja {inputNum} = {sqrResult}";

            //}
            //else
            //    result = "Neispravan unos, nije moguće izvršiti operaciju korjenovanje.";

            //Console.WriteLine(result);

            /*
            Double.TryParse(Console.ReadLine(), out inputNumDec);
            if (inputNumDec != 0)
            {
                sqrResult = Convert.ToDouble(Math.Sqrt(inputNumDec));
                result = $"Korijen broja {inputNumDec} = {sqrResult}";

            }
            else
                result = "Neispravan unos, nije moguće izvršiti operaciju korjenovanje.";

            Console.WriteLine(result); */

            /*
            string inputWord;

            Console.WriteLine("Molimo unesite riječ");
            inputWord = Console.ReadLine();
            string[] arrayOfStrings = new string[5];
            arrayOfStrings[0]=inputWord.Substring(1);
            arrayOfStrings[1]=inputWord.Substring(2);
            arrayOfStrings[2] = inputWord.Substring(3, 2);
            arrayOfStrings[3] = inputWord.ToUpper();
            arrayOfStrings[4] = inputWord.ToLower();

            foreach (string stringElement in arrayOfStrings)
            {
                Console.WriteLine(stringElement+"\n");
            } */

            string ReverseWord(string word)
            {
                
               
            }
            Console.WriteLine("Molimo unesite riječ");
            string inputWord = Console.ReadLine();
            Console.WriteLine($"Reversed: {inputWord}");



            Console.ReadLine();
        }
    }
}
