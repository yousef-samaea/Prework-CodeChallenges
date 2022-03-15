using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.ArrayMaxResult());
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
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Select any number");
            number = int.Parse(Console.ReadLine());
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
    }
}
