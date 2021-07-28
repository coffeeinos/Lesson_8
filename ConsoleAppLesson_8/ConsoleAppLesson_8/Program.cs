using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // многомерные массивы

            int[,,] array = new int[5, 6, 7];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int y = 0; y < array.GetLength(2); y++)
                    {
                        array[i, j, y] = random.Next(1000);
                    }
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int y = 0; y < array.GetLength(2); y++)
                    {
                        Console.Write(array[i, j, y] + " "); 
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
        }
    }
}
