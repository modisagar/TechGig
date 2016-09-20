using System;

namespace CandidateCode
{
    class CandidateCode
    {
        static void Main(string[] args)
        {
            //input matrix
            int[,] matrix1 = getMatrix();
            int[,] matrix2 = getMatrix();
            //add 2 matrix
            if (matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.GetLength(1) == matrix2.GetLength(1))
            {
                int[,] resultMatrix = addMatrix(matrix1, matrix2);
                //print the result matrix
                day12(resultMatrix);
            }
            else
                Console.WriteLine("matrix dimentions are not matching");
            
        }

        private static void day12(int[,] resultMatrix)
        {
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    if (j == resultMatrix.GetLength(1)-1)
                        Console.Write(string.Format("{0}", resultMatrix[i, j]));
                    else
                        Console.Write(string.Format("{0} ", resultMatrix[i, j]));
                }
                Console.WriteLine();
            }
        }

        private static int[,] addMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] matrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrix;
        }

        private static int[,] getMatrix()
        {
            int row, col = 0;
            int[] arr = new int[2];
            string rowcol = Console.ReadLine(); // get the size of matrix
            try
            {
                arr = Array.ConvertAll(rowcol.Split(' '), int.Parse);
                row = arr[0];
                col = arr[1];
            }
            catch (Exception)
            {
                throw new Exception("Input is not in valid format.");
            }

            int[,] matrix = new int[row, col];//blank Matrix
            for (int i = 0; i < row; i++)
            {
                string getrow = Console.ReadLine();//get matrix row
                int[] temparr = new int[col];
                temparr = Array.ConvertAll(getrow.Split(new char[] { ' ' }, col), int.Parse);//get col data
                for (int j = 0; j < temparr.Length; j++)
                {
                    matrix[i, j] = temparr[j];//assign data to matrix in row col
                }
            }

            return matrix;
        }

        private static void day11(string sampleText)
        {
            int upper = 0;
            int lower = 0;
            foreach (char item in sampleText)
            {
                if (char.IsUpper(item))
                    upper++;
                else if (char.IsLower(item))
                    lower++;
            }
            Console.WriteLine(upper);
            Console.WriteLine(lower);

        }

        private static void day10(int number, int[] arr)
        {
            int first = int.MinValue;
            int second = int.MinValue;

            foreach (int i in arr)
            {
                if (i > first)
                {
                    second = first;
                    first = i;
                }
                else if (i > second)
                    second = i;
            }
            Console.WriteLine(second);
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
