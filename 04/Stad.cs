using System;

namespace Datastructures{
    class Stad{
        private int inwoners;
        public Stad(string naam)
        {
            Naam = naam;
            Random r = new Random();
            inwoners = r.Next(0,100) * 1000;
        }

        public string Naam{get; private set;}
        public int Inwoners => inwoners;

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