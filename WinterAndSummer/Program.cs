using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterAndSummer
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter temperatures separated by spaces");
                var input = Console.ReadLine().Split(' ');
                var temperatures = new int[input.Length];
                for(int i = 0; i < input.Length; i++)
                {
                    if (!int.TryParse(input[i], out int temperature))
                    {
                        Console.WriteLine("There was an error in input data.");
                        Console.ReadKey();
                        return;
                    }
                    temperatures[i] = temperature;
                }
                var result = solution.WinterAndSummer(temperatures);
                Console.WriteLine(result);
                Console.Write("Again? (y/n)");

            } while (Console.ReadKey(false).Key == ConsoleKey.Y);
        }
    }
}
