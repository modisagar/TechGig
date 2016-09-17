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
                throw new Exception("Input is not in valid format.");
            }

            day9(number);
        }

        private static void day9(int number)
        {
            double sum = 0;
            
            for (int i = number; i > 0; i = i / 10)
            {
                int rem = i % 10;
                sum = sum + Math.Pow(Convert.ToDouble(rem), Convert.ToDouble(number.ToString().Length));
            }
            
            if (sum == number)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        private static void day8(int number)
        {
            double sum = 0;
            int i = number;
            //for (int i = number; i > 0; i = i / 10)
            //{
            //    int rem = i % 10;
            //    sum = sum + rem * rem * rem;
            //}
            while (i > 0)
            {
                int rem = i % 10;
                sum = sum + Math.Pow(Convert.ToDouble(rem), 3);
                i = i / 10;
            }
            if (sum == number)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            
        }

        private static void day7(int number1, int number2)
        {
            int count = 0;
            for (int i = number1; i < number2; i++)
            {
                if (isPrime(i))
                    count++;
            }
            Console.WriteLine(count);
        }

        private static bool isPrime(int i)
        {
            if (i == 1)
                return false;
            for (long j = 2; j < i; j++)
            {
                if (i % j == 0) // you don't need the first condition
                {
                    return false;
                }
            }
            return true;
        }

        private static void day6(int number)
        {
            int count = 0;
            while (number > 0)
            {
                number = number / 10;
                count++;
            }
            Console.WriteLine(count);
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
