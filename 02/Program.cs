using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello int!");

            // Basis types: int, long, float, double, decimal, bool, char, string
            // en nog meer: sbyte, short, byte, ushort, unit, ulong
            int a = 42;
            int b = 37;
            var c = a + b;

            Console.WriteLine("c = " + c);

            /* Meer commentaar
             * op meer regels
             */

            if (c > 50){
                a = a + 100;
            }else{
                b *= 100;
            }
            Console.WriteLine("a = " + a + ", b = " + b);

            // Loops: 
            // for ( ;; ){}
            // while( expressie ) { statements } 
            for(int i = 0; i < 4; i++){
                Console.WriteLine($"We tellen op: {i}!");
            }
            var j = 4;
            while( j >= 0 ){
                Console.WriteLine($"We tellen af: {j}!");
                j--;
            }

            var s = "Workshop";
            foreach(var c in s){
                Console.WriteLine(c);
            }
        }
    }
}
