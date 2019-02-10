using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var awesome = new Geweldig(42){
                Naam = "FortyTwo",
                Dingen = new List<Ding>(){
                    new Ding(){},
                    new Ding(){},
                    new Ding(){},
                    }
                };

            Console.WriteLine(awesome);
            var json = JsonConvert.SerializeObject(awesome);
            Console.WriteLine("JSON: "+json);
            Console.WriteLine();

            // JsonSerializer s = new Newtonsoft.Json.JsonSerializer();
            // s.Formatting = Formatting.Indented;
            // s.Serialize(Console.Out, awesome);
                
            var ookGeweldig = JsonConvert.DeserializeObject<Geweldig>(json);
            Console.WriteLine(ookGeweldig);
            Console.WriteLine("Aantaldingen: "+ookGeweldig.Dingen.Count);
        }
    }


    public class Geweldig{
        public Geweldig(int secret)
        {
            geheim = secret;
        }
        public string Naam{get;set;}
        private int geheim;

        public List<Ding> Dingen{get;set;}

        public override string ToString(){
            return $"{Naam}'s geheim is {geheim}.";
        }
    }

    public class Ding{
        public int Waarde{get;set;}
        public bool Saai{get;set;}
        public Color Kleur{get;set;}
    }


    public enum Color{
        rood,
        blauw, 
        geel,
    }
}
