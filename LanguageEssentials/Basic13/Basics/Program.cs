using System;
using System.Collections.Generic;

namespace Basics
{
    class Basics
    {
        // Print 1-255 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // public static void PrintNumbers()
        // {
        //     for (int i = 1; i <= 255; i++)
        //     {
        //         System.Console.WriteLine(i);
        //     }
        // }
        // // Print 1-255, odds only ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // public static void PrintOdds()
        // {
        //     for (int i = 1; i <= 255; i++)
        //     {
        //         if (i % 2 == 1)
        //         {
        //             System.Console.WriteLine(i);
        //         }
        //     }
        // }
        // Print sum ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // public static void PrintSum()
        // {
        //     int sum = 0;
        //     for (int i = 1; i <= 255; i++)
        //     {
        //         sum += i;
        //         Console.WriteLine("New Number: {0} Sum {1}", i, sum);
        //     }
        // }
        // Iterating through an Array ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // public static void LoopArray()
        // {
        //     int[] numbers = { 1, 2, 3, 4, 5};
        //     foreach (int number in numbers)
        //     {
        //         Console.WriteLine(number);
        //     }
        // }
        // Find Max ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // public static void FindMax(params int[] numbers)
        // {
        //     int max = numbers[0];
        //     for (int i = 0; i < numbers.Length; i++)
        //     {
        //         if (numbers[i] > max)
        //         {
        //             max = numbers[i];
        //         }
        //     }
        //     Console.WriteLine("The highest value is: " + max);
        // }

        // // Get Average ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // public static void GetAverage(params int[] nums)
        // {
        //     int sum = 0;
        //     foreach (var num in nums)
        //     {
        //         sum += num;
        //     }
        //     Console.WriteLine("The Average is: " + (sum / (nums.Length)));
        // }
        // // Array with odd Numbers ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // public static void OddArray()
        // {
        //     var y = new List<int>();
        //     for (int i = 1; i <= 255; i++)
        //     {
        //         if (i % 2 == 1)
        //         {
        //             y.Add(i);
        //         }
        //     }

        //     Console.WriteLine("Odd Array between 1-255: ");
        //     foreach (var i in y)
        //     {
        //         Console.Write(+i + ", ");
        //     }
        // }
        // // Greater than Y ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // public static void GreaterThanY(int[] numbers, int y)
        // {
        //     int count = 0;
        //     foreach (var number in numbers)
        //     {
        //         if (number > y)
        //         {
        //             count++;
        //         }

        //     }
        //     Console.WriteLine($"Number in array greater than {y}: {count}");
        // }
        // // Square the Values ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // public static void SquareArrayValues(int[] numbers)
        // {
        //     for (int i = 0; i < numbers.Length; i++)
        //     {
        //         numbers[i] *= numbers[i];
        //         Console.WriteLine(numbers[i]);
        //     }
        // }
        // // Eliminate Negative Numbers ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // public static void EliminateNegatives(int[] numbers)
        // {
        //     for (int i = 0; i < numbers.Length; i++)
        //     {
        //         // If numbers are negatives, it will print 0.
        //         if (numbers[i] < 0)
        //         {
        //             numbers[i] = 0;
        //         }
        //         Console.WriteLine(numbers[i]);
        //     }
        // }
        // // Min, Max, and Average ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // public static void MinMaxAverage(int[] numbers)
        // {
        //     int sum = 0;
        //     int max = 0;
        //     int min = 0;
        //     for (int i = 0; i < numbers.Length; i++)
        //     {
        //         sum += numbers[i];
        //         if (numbers[i] > max)
        //         {
        //             max = numbers[i];
        //         }
        //         else if (numbers[i] < min)
        //         {
        //             min = numbers[i];
        //         }
        //     }
        //     int avg = sum / numbers.Length;
        //     Console.WriteLine("Min: {0}" + "\n" + "Max: {1}" + "\n" + "Avg: {2}", min, max, avg);
        // }
        // // Shifting the values in an array ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // public static void ShiftValues(int[] numbers)
        // {
        //     for (int i = 0; i < numbers.Length - 1; i++)
        //     {
        //         int temp = numbers[i];
        //         numbers[i] = numbers[i + 1];
        //         numbers[i + 1] = temp;
        //     }
        //     numbers[numbers.Length - 1] = 0;
        //     foreach (int value in numbers)
        //     {
        //         Console.WriteLine(value);
        //     }
        // }
        // // Number to String ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //         public static object[] NumToString(int[] numbers)
        //         {

        //         }
        //     }
        // }



//         class Program
//         {
//             static void Main(string[] args)
//             {
//                 // Basics.PrintNumbers();
//                 // Basics.PrintOdds();
//                 // Basics.PrintSum();
//                 // Basics.LoopArray();
//                 // Basics.FindMax(-3, -5, -7);
//                 // Basics.GetAverage(2, 3, 10);
//                 // Basics.OddArray();
//                 // int[] numbers = new int[5] { 1, 3, 5, 7, 3 };
//                 // Basics.GreaterThanY(numbers, 4);
//                 // int[] numbers = new int[4] { 1, 5, 10, -10 };
//                 // Basics.SquareArrayValues(numbers);
//                 // int[] numbers = new int[4] { 1, 5, 10, -2 };
//                 // Basics.EliminateNegatives(numbers);
//                 // int[] numbers = new int[4] { 1, 5, 10, -2 };
//                 // Basics.MinMaxAverage(numbers);
//                 // int[] numbers = new int[5] { 1, 5, 10, 7, -2 };
//                 // Basics.ShiftValues(numbers);
//             }
//         }
//     }
// }
