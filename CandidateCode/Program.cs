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
            int number = 0;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Input is not in valid format.");
                Environment.Exit(0);
            }

            day5(number);
            
        }

        private static void day5(int number)
        {
            int output = 1;

            for (int i = number; i >= 1; i--)
            {
                output = output * i;
            }
            
            
            Console.WriteLine(output);
        }

        private static void day4(int age)
        {
            if (age < 10)
                Console.WriteLine("I am happy as having no responsibilities.");
            else if (age >= 10 && age < 18)
                Console.WriteLine("I am still happy but starts feeling pressure of life.");
            else
                Console.WriteLine("I am very much happy as i handled the pressure very well.");
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
