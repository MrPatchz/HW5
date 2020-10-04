using System;
using System.Runtime.ExceptionServices;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize both arrays only putting values in one
            int[] array1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] array2 = new int[array1.Length];
            //Copy each element in one array to the other
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
            }
            //Print all the elements in one array
            Console.WriteLine("First array is: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + ",");
            }
            //Print all the elements of the second array
            Console.WriteLine("\nSecond array is: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + ",");
            }
        }
    }
}
