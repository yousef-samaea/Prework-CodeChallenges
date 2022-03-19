using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 1 };
            int[,] narr = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            ArrayMaxResul();
            leapYear();
            Console.WriteLine("the Result for perfectSequence: " + perfectSequence(arr));
            Console.WriteLine("the Result for SumOfRows : ");
            int[] result = SumOfRows(narr, 3, 5);
            printarr(result);

        }
        static void ArrayMaxResul()
        {
            int[] array = new int[5];

            Console.WriteLine("Enter 5 numbers from 1 to 10 to start filling the array");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Select any number");
            int number;
            number = Convert.ToInt32(Console.ReadLine());

            int countar = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    countar++;
                }
            }
            int resalt = number * countar;
            Console.WriteLine("your score is: " + resalt);
        }
        static void leapYear()
        {
            Console.WriteLine("Enter Year : ");
            int Year = Convert.ToInt32(Console.ReadLine());
            if (Year % 4 == 0)
            {
                Console.WriteLine("true it is a Leap Year " + Year);
            }
            else
            {
                if (Year % 100 == 0 && Year % 400 == 0)
                {
                    Console.WriteLine("true it is a Leap Year " + Year);
                }
                else
                {
                    Console.WriteLine("false it is a Leap Year " + Year);
                }
            }

        }
        static String perfectSequence(int[] arr)
        {
            Boolean Positive = true;
            int sum = 0;
            int product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Positive = false;
                }
                else
                {
                    sum = sum + arr[i];
                    product = product * arr[i];
                }
            }
            if (Positive == true && sum == product)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
        static int[] SumOfRows(int[,] arr, int rows, int colms)
        {
            int[] sum = new int[rows];


            for (int i = 0; i < rows; i++)
            {
                for (int ii = 0; ii < colms; ii++)
                {
                    sum[i] += arr[i, ii];
                }
            }
            return sum;
        }
        static void printarr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

        }

    }
}
