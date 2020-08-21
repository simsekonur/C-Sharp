using System;

class Program {
    static void Main(string [] args){
        Console.Write("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        //whathever it comes from console.readline will
        //be converted into an integer
        Console.WriteLine(num1+num2);
    }
    
    
    
}
