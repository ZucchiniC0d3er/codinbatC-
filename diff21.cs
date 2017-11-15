using System;

namespace HelloWorldApplication {

   class HelloWorld {

      static void Main(string[] args) {
      Console.WriteLine(diff21(21));
      }
      public static int diff21(int n) {
          if(n > 21){
            return (Math.Abs(21-n)*2);
          }
          return (21 -n);
    }

   }
}