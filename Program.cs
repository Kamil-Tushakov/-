using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 4;
            nums[4] = 5;
            Console.WriteLine(nums[3] + nums[0]); // попросим вывести решение арифметического примера
            Console.WriteLine("");
            Console.WriteLine(nums[1]);
            Console.WriteLine("+");
            Console.WriteLine(nums[2]);
            Console.WriteLine("=");
            Console.WriteLine(nums[4]);
            Console.ReadLine();
        }
    }
}
