using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson_8_part_2
{
    class Program
    {

        //многомерные зубчатые массивы
        static void Main(string[] args)
        {
            Random random = new Random();
            int[][][] array  = new int[random.Next(5, 10)][][];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[random.Next(5, 10)][];

                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = new int[random.Next(5, 10)];

                    for (int z = 0; z < array[i][j].Length; z++)
                    {
                        array[i][j][z] = random.Next(1000);
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Page № " + (i+1));

                for (int j = 0; j < array[i].Length; j++)
                {
                    for (int z = 0; z < array[i][j].Length; z++)
                    {
                        Console.Write(array[i][j][z] + " ");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }

        }
    }
}
