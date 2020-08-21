using System ;

class program {
    static void Main (string []args){
       
        int secretNumber = 32 ;
        
        int guess = -1;
        int remainingHealth= 3 ;
        
        
        while(guess!= secretNumber){
            Console.Write("Enter the guess:");
            guess = Convert.ToInt32(Console.ReadLine());
            remainingHealth--;
            if (remainingHealth==0){
                Console.WriteLine("You lost the game..");
                break ;
            }
            else if (guess < secretNumber){
                Console.WriteLine("Say higher..");
            }
            else if (guess > secretNumber){
                Console.WriteLine("Say small number");
            }
            else {
                Console.WriteLine("You guessed correctly!");
            }
        }
       
        
    }
}
