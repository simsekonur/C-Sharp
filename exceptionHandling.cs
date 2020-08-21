using System;
using System.Net.Http.Headers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the other number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);

            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e.Message);
            }
            catch (FormatException f) {
                Console.WriteLine(f.Message);
            }
            


        }
    }
}
