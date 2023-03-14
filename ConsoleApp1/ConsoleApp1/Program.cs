using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

            
            string ReverseInput(string word)
            {
                string reversedWord;
                char[] wordToChar = word.ToCharArray();
                Array.Reverse(wordToChar);
                reversedWord = new string(wordToChar);
                
                return reversedWord;
            }
            /*
            Console.WriteLine("Molimo unesite riječ");
            string inputWord = Console.ReadLine();
            Console.WriteLine($"Reversed: {ReverseWord(inputWord)}");  */


            //Area of a rectangle
            //Console.WriteLine("Napišite: Pravokutnik ili kvadrat?");
            //int sideA;
            //int sideB; 

            //string userInputGeoLik = Console.ReadLine();

            //if(userInputGeoLik.ToLower() == "pravokutnik")
            //{
            //    Console.WriteLine("Unesite duljinu prvog para stranica:");
            //   Int32.TryParse(Console.ReadLine(), out sideA);
            //    Console.WriteLine("Unesite dužinu drugog para stranica");
            //   Int32.TryParse(Console.ReadLine(), out sideB);
            //    Console.WriteLine($"Površina pravokutnika čije su duljine stranica a={sideA} i b={sideB} iznosi:\n{sideA*sideB}");
            //}
            //else if(userInputGeoLik.ToLower() == "kvadrat")
            //{
            //    Console.WriteLine("Unesite duljinu stranica kvadrata:");
            //    Int32.TryParse(Console.ReadLine(), out sideA);
            //    Console.WriteLine($"Površina kvadrata duljine stranica a={sideA} iznosi:\n{sideA*sideA}");

            //}
            //else
            //{
            //    Console.WriteLine("Neispravan unos.");
            //    Console.ReadLine();
            //    Console.Clear();
            //    Program.Main(args);
            //}
            string name;
            int i;
            float f;
            bool isActive;
            double b;
            char z;
            int? m; //nullable operator: ?
            var a = 'z';
            var d = 1;
            String velikiString;
            string maliString;


            //Day2

            //string ReverseString2(string str)
            //{
            //    return new string(str.Reverse().ToArray()); 
            //}
            //Console.WriteLine("Unesite riječ");
            //string userWord = Console.ReadLine();
            //Console.WriteLine($"Vaš riječ, ali izokrenuta: {ReverseString2(userWord)}");

            //var haystack_1 = new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false };
            //var haystack_2 = new object[] { "283497238987234", "a dog", "a cat", "some random junk", "a piece of hay", "needle", "something somebody lost a while ago" };
            //var haystack_3 = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 8, 7, 5, 4, 3, 4, 5, 6, 67, 5, 5, 3, 3, 4, 2, 34, 234, 23, 4, 234, 324, 324, "needle", 1, 2, 3, 4, 5, 5, 6, 5, 4, 32, 3, 45, 54 };


            //string FindNeedle(object[] haystack)
            //{
            //   int needlePosition = -1;
            //   for(int index= 0; index< haystack.Length; index++)
            //    {                   
            //        if (haystack[index].ToString() == "needle" )
            //        {
            //            needlePosition = index;
            //        }
            //    }
            //    return $"Found the needle at position {needlePosition} ";
            // }
            //Console.WriteLine(FindNeedle(haystack_1));

            Console.WriteLine("Unesite broj");
            try
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber < 100)
                {
                    while (userNumber <= 100 )
                    {
                        Console.WriteLine(userNumber++);
                    }
                }
                else if( userNumber > 100 ) 
                {
                    while (userNumber >= 100 )
                    {
                        Console.WriteLine(userNumber--);
                    }
                }
                string userInput;
                do
                {
                    Console.WriteLine("Želite li ponovno igrati unesite y, za izlazak iz aplikacije unesite x.");
                    userInput = Console.ReadLine();

                } while (userInput.ToLower() != "y" && userInput.ToLower() != "x");
                if( userInput.ToLower() == "y")
                {
                    Console.Clear();
                    Program.Main(args);
                }
                else if (userInput.ToLower() == "x") 
                { 
                    Console.Clear();
                    Environment.Exit(0);
                }                 
            }
            catch (Exception)
            {

                Console.Error.WriteLine("Neispravan unos.");
                Console.ReadLine();
                Console.Clear();
                Program.Main(args);
            }
            
            


            Console.ReadLine();
        }
    }
}
