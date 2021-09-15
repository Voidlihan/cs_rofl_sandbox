using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_sandbox1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int a = 2;
            int b = 0;
            int c = rand.Next(b, a);
            if(c > 0)
            {
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("lox");
                    Console.ResetColor();
                }
            }
            else
            {
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ne lox");
                    Console.ResetColor();
                }
            }
            //int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            //int rows = mas.GetUpperBound(0) + 1;
            //int columns = mas.Length / rows;
            //do
            //{
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < columns; j++)
            //        {
            //            mas[i, j] *= mas[i, j];
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.Write($"{mas[i, j]} \t");
            //            Console.ResetColor();
            //        }
            //    }
            //}
            //while (1 > 0);
        }
    }
}
