using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] taskTime = { 98, 84, 7, 634, 543, 44, 3, 264, 13}; //Creates an integer array that contains multiple task times in miliseconds.

            Console.WriteLine("The unnaranged task times are:\n"); //Prints a message to the console indicating the following times are unnaranged.

            for (int i = 0; i < taskTime.Length; i++) //Loops throught he taskTime array for it's length and prints each integer "i" to the console.
            {
                Console.WriteLine($"{taskTime[i]}ms");
            }

            int temp; //Declare integer variable, temp, and inititalze to 0. will hold a temporary value during swaps
            int swapTimes = 0; //Declare integer variable, swapTimes, and inititalze to 0. will count the number of times a value is swapped.

            for (int i = 0; i < taskTime.Length - 1; i++) //The outer loop itterates through each item "i" in the array except the last one.
            {
                for (int j = 0; j < taskTime.Length - (1 + i); j++) //The inner loop compares each item "j" with the next item "j" in the array.
                {
                    if (taskTime[j] > taskTime[j + 1]) //Checks wether the current item "j" is larger or smaller than the next item "j" in the array.
                    {
                        temp = taskTime[j + 1]; //Assigns the "temp" variable with the value of next item "j" in the array.
                        taskTime[j + 1] = taskTime[j]; //Assigns the value of item "j" to the position of the next item "j", 
                        taskTime[j] = temp; //Assigns the value of the "temp" variable to the position of the current item "j"
                        swapTimes++; //increases the swapTimes by 1.
                    }
                }
            }

            Console.WriteLine("\nThese task times arranged in ascending order are:\n"); //Prints a message to the console indicating the following times are arranged in ascending order.

            for (int k = 0; k < taskTime.Length; k++) //Loops through the taskTime array and prints the new arranged order to the console.
            {
                Console.WriteLine($"{taskTime[k]}ms");
            }

            Console.WriteLine($"\nValues swaped places {swapTimes} times"); //Prints the amount of times items were swapped in the bubble sort.
        }
    }
}
