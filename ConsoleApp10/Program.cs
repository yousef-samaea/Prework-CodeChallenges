using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.ArrayMaxResult());
            Console.WriteLine(program.leapYear());
        }
        public string ArrayMaxResult()
        {
            int[] array = new int[5];
            int number;
            Console.WriteLine("Enter 5 numbers from 1 to 10 to start filling the array");
            try
            { 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Select any number");

            number = Convert.ToInt32(Console.ReadLine());

            int countar = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    countar++;
                }
            }
            return "your score is: " + number * countar;
            }
            catch
            {
                Console.WriteLine("only numbers");

            }

        }
        public string leapYear()
        {
            Console.WriteLine("Enter Year : ");
            int Year = Convert.ToInt32(Console.ReadLine());
            if (Year % 4 == 0)
            {
                return "true it is a Leap Year" + Year;
            }
            else
            {
                if (Year % 100 == 0 && Year % 400 == 0)
                {
                    return "true it is a Leap Year" + Year;
                }
                else
                {
                    return "false it is a Leap Year" + Year;
                }
            }

        }
    }
}
