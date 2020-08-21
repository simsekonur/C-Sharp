/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System ;

class program {
    static void Main (string []args){
        bool key = true ;
        while (key){
            Console.Write("Enter the operation, to quit please enter -1:");
            string oper = Console.ReadLine();
            if (oper == "-1"){
                Console.WriteLine("Exiting the program...");
                break ;
            }
            Console.Write("Enter the num1:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the num2:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            if(oper=="+"){
                Console.WriteLine(num1+num2);
            }
            else if(oper=="-"){
                Console.WriteLine(num1-num2);
            }
            else if(oper=="*"){
                Console.WriteLine(num1*num2);
            }
            else if(oper=="/"){
                Console.WriteLine(num1/num2);
            }
            else {
                Console.WriteLine("Invalid operation..");
            }
        
        }
           
        
    }
}
