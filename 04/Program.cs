using System;
using System.Collections.Generic;

namespace Datastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var nederland = new Land();
            nederland.Naam = "Hollandia";
            
            nederland.StichtStad("Groningen");
            nederland.StichtStad("Amstedam");
            nederland.StichtStad("Den Haag");
            nederland.StichtStad("Haren");
            nederland.StichtStad("Leeuwarden");
            nederland.StichtStad("Assen");
            nederland.StichtStad("Lutjebroek");
            Console.WriteLine($"{nederland.Naam} heeft {nederland.GroteSteden()} grote steden");

        }
    }

    class Land{
        public string Naam{get;set;}
        List<Stad> steden = new List<Stad>();
        
        public void StichtStad(string naam){
            var s = new Stad(naam);
            steden.Add(s);
        }

        public int GroteSteden(){
            var k = 0;
            for(int i = 0; i < steden.Count; i++){
                if (steden[i].Inwoners > 50_000){
                    k++;
                }
            }
            return k;
        }
    }


}
