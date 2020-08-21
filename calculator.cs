using System ;

class program {
    static void Main (string []args){
        Console.Write("Enter the operation:");
        string oper = Console.ReadLine();
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
