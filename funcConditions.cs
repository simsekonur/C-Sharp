/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class HelloWorld {
  static void Main() {
        bool isMale = false;
        string status = "el";
        if (status=="hungry"){
            Console.WriteLine("Deneme1");
        }
        else if(status == "elel") {
            Console.WriteLine("Deneme2");
            
        }else {
            Console.WriteLine("Noone of them");
            
        }
        Console.WriteLine(findMax(90,89));
        Console.WriteLine(getMax(1,2,3));
        
  }
  static int findMax(int i1 ,int i2){
      if (i1 < i2 ){
          return i2;
      }
      else {
          return i1;
      }
  }
  static int getMax(int i1, int i2 ,int i3){
      int result ;
      if (i1 >= i2 && i1 >= i3){
          result = i1;
      }
      else if (i2>=i1 && i2>=i3){
          result = i2;
      }
      else {
          result = i3;
      }
      return result;
  }
}
