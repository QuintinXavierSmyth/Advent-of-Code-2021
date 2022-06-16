using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[2000];
            int i = 0;
            int prev;
            int count = 0;
            //string[] data = System.IO.File.ReadAllLines(@"C:\Users\quintin\Desktop\adventofCode\data.txt");
            using (var file = new StreamReader(@"C:\Users\quintin\Desktop\adventofCode\data.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    numbers[i] = int.Parse(line);
                    i++;
                }
            }
            prev = numbers[0];
            foreach(int n in numbers)
            {
                if (n > prev)
                {
                    count += 1;
                }
                prev = n;
            }
            Console.WriteLine(count);
        }
    }
}
