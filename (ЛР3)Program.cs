using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rand = new Random();
            for (int y = 0; y < 20; y++)
            {
                array[y] = rand.Next(-100, 100);
                {
                    Console.WriteLine(array[y]);
                  
                    Console.ReadLine();
                }     
            }
        }
    }
}
