using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // this will be an int array called numbers
            // I want a mememory of int with size 5

            // declaring an array of five int
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++){
                numbers[i] = i;
            }

            for (int j = 0; j < numbers.Length; j++) {
                Console.WriteLine(numbers[j]);
            
            }
            
           

            Console.WriteLine("Hello World!");

        }
    }
}
