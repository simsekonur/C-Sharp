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

            Console.WriteLine(numbers.Length);


            int[,] twoDimensional = { { 1, 2 }, { 3, 4 }, { 5, 6 },{7,8 },{9,10 },{11,12 } };


            int rows = twoDimensional.GetUpperBound(0) - twoDimensional.GetLowerBound(0) + 1;
            Console.WriteLine("Rows:"+rows);
            int cols = twoDimensional.GetUpperBound(1) - twoDimensional.GetLowerBound(1)+1;
            Console.WriteLine("Columns:"+cols);
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {

                    Console.WriteLine(twoDimensional[i,j]);
                }
            
            }

            Console.WriteLine("Hello World!");


        }
    }
}
