using System ;

class program {
    static void Main (string []args){
       
        Console.WriteLine(calculatePower(5,3));
       
        
    }
    static int calculatePower(int baseNum,int powNum){
        int temp = baseNum;
       
        while (powNum > 1){
            baseNum *= temp ;
            
            powNum--;
            
        }
        return baseNum;
    }
}
