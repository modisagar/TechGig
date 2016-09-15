using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateCode
{
    class CandidateCode
    {
        static void Main(string[] args)
        {
            double principle=0;
            int interest=0;
            int year=0;
            int output=0;

            //Console.WriteLine("Give principle amount:");
            try
            {
                principle = double.Parse(Console.ReadLine().ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Principle is not in correct format");
                System.Environment.Exit(0);
            }
            //Console.WriteLine("Give Interest rate:");
            try
            {
                interest = int.Parse(Console.ReadLine().ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Interest is not in correct format");
                System.Environment.Exit(0);
            }
            //Console.WriteLine("Give Year(s):");
            try
            {
                year = int.Parse(Console.ReadLine().ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Interest is not in correct format");
                System.Environment.Exit(0);
            }

            output = day3(principle, interest, year);
            Console.WriteLine(output);
            
        }

        private static int day3(double principle, int interest, int year)
        {
            return (int)Math.Round((principle * interest * year) / 100);
        }

        private static void day2(string str)
        {
            
            if (!string.IsNullOrEmpty(str))
            {
                Int32 intValue;
                float doubleValue;
                
                if (Int32.TryParse(str, out intValue))
                    Console.WriteLine("This input is of type Integer.");
                else if (float.TryParse(str, out doubleValue))
                    Console.WriteLine("This input is of type Float.");
                else if (str is string)
                    Console.WriteLine("This input is of type String.");
                else
                    Console.WriteLine("This is something else."); 
            }
        }
        
        private static void day1(string stdin)
        {
            Console.WriteLine("Hello Techgig");
            Console.WriteLine(stdin);
        }
    }
}
