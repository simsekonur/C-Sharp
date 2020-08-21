using System;

class Program {
    static void Main(string [] args){
        Console.Write("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        //whathever it comes from console.readline will
        //be converted into an integer
        Console.WriteLine(num1+num2);
    }
    
    
    
}
