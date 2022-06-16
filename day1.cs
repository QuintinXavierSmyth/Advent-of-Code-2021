using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[2000];
            int j = 0;
            int count = 0;
            using (var file = new StreamReader(@"C:\Users\quintin\Documents\GitHub\Advent-of-Code-2021\data.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    numbers[j] = int.Parse(line);
                    j++;
                }
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i]>numbers[i-1])
                {
                    count += 1;
                }
            }

            Console.WriteLine("Part 1: " + count);
            count = 0;
            for (int i = 3; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 3])
                {
                    count += 1;
                }
            }

            Console.WriteLine("Part 2: " + count);
        }
    }
}
