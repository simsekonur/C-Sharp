using System ;

class program {
    static void Main (string []args){
       
        int secretNumber = 32 ;
        
        int guess = -1;
        
        while(guess!= secretNumber){
            Console.Write("Enter the guess:");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess < secretNumber){
                Console.WriteLine("Guess is smaller,say higher..");
            }
            else {
                Console.WriteLine("Say small number");
            }
        }
        Console.WriteLine("You guessed correctly!");
        
    }
}
