using System;
using System.Globalization;

namespace Project2
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers(10);
            int[] reverse = Reverse(numbers);
            PrintNumbers(reverse);
        }
        public static int[] GenerateNumbers(int length)
        {
            int[] numbers = new int[length];
            for (int i = 1; i <= length; i++)
            {
                numbers[i - 1] = i;
            }
            return numbers;
        }
        public static int[] Reverse(int[] numbers)
        {
            int[] tmp = new int[numbers.Length]; 
            for (int i = 0; i < numbers.Length; i++)
            {
                tmp[i] = numbers[i];
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                int one = tmp[i];
                int two = tmp[(numbers.Length - 1) - i];
                int temp = one;
                numbers[i] = two;
                numbers[(numbers.Length - 1) - i] = temp;
            }
            return numbers;
        }
        public static void PrintNumbers (int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
            }
        }
    }
}
