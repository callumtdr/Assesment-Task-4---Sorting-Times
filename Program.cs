using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] taskTime = { 98, 84, 7, 634, 543, 44, 3, 264, 13};
            Console.WriteLine("The unnaranged task times are:\n");
            for (int i = 0; i < taskTime.Length; i++)
            {
                Console.WriteLine($"{taskTime[i]}ms");
            }
            Console.WriteLine("\nThese task times arranged numerically from shortest to longest are:\n");
            int temp;
            int swapTimes = 0;

            for (int i = 0; i < taskTime.Length - 1; i++)
            {
                for (int j = 0; j < taskTime.Length - (1 + i); j++)
                {
                    if (taskTime[j] > taskTime[j + 1])
                    {
                        temp = taskTime[j + 1];
                        taskTime[j + 1] = taskTime[j];
                        taskTime[j] = temp;
                        swapTimes++;
                    }
                }
            }

            for (int k = 0; k < taskTime.Length; k++)
            {
                Console.WriteLine($"{taskTime[k]}ms");
            }

            Console.WriteLine($"Values swaped places {swapTimes} times");
        }
    }
}
