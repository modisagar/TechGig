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
            string stdin = Console.ReadLine();
            day2(stdin);
            
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
