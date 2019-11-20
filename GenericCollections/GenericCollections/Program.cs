using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> countryLookup = new Dictionary<int, string>();

            countryLookup[36] = "Hungary";
            countryLookup[33] = "France";
            countryLookup[31] = "Netherlands";
            countryLookup[1] = "USA, Canada";

            string input = "";
            int num = 0;

            do
            {
                try
                {
                    Console.Write("Enter country code (number): ");
                    input = Console.ReadLine();
                    num = int.Parse(input);

                    if(!countryLookup.ContainsKey(num))
                    {
                        Console.WriteLine("\nNot in list.\n");
                    }
                    
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Invalid input. Enter number(s)");
                    continue;
                }
            }
            while (!IsAllDigits(input) || !countryLookup.ContainsKey(num));

            Console.WriteLine("\nNumber {0} code is for {1}.\n", num, countryLookup[num]);

            foreach (var item in countryLookup)
            {
                int code = item.Key;
                string country = item.Value;
                Console.WriteLine("Code {0} = {1}", code, country);
            }

            
                       
            Console.Read();
        }

        static bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}
