using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stad stad0 = new Stad("Groningen");
            Stad stad1 = new Hoofdstad("Amsterdam", 3);

            Console.WriteLine(stad0);
            Console.WriteLine(stad1);
        }
    }

    class Stad{
        public Stad(string naam)
        {
            Naam = naam;
        }

        public string Naam{get; private set;}

        public void Hernoem(string nieuweNaam){
            Naam = nieuweNaam;
        }
    }

    class Hoofdstad : Stad{
        private readonly int paleizen;
        public Hoofdstad(string naam, int aantalPaleizen) : base(naam)
        {
            paleizen = aantalPaleizen;
        }

        public int AantalPaleizen => paleizen;

        public override string ToString() {
            return $"{Naam} (Paleizen:{AantalPaleizen})";
        }
    }
}
