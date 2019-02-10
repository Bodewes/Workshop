using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cijfers = Enumerable.Range(1,100).ToList();

            var even = cijfers.Where(x => x % 2 == 0);
            Console.WriteLine("Even: " + string.Join(",", even));

            var kwadraat = cijfers.Select(y => new { Invoer =y, Uitvoer = y*y} );
            Console.WriteLine("Aantal: "+ kwadraat.Where(z => z.Uitvoer > 1000 ).Count() );

            var selectie = cijfers.Skip(50).Take(20).OrderByDescending(x => x%10).Where(x => x/10 == x%10);
            Console.WriteLine("Selectie: " + string.Join(",", selectie));

            var euros = cijfers.Select(x => new EuroBedrag(x));
            var dollars = euros.Where(x => x.Centen > 50).Select(x => new DollarBedrag(x.Centen));
            Console.WriteLine("1e Dollar: " + dollars.First());
        }
    }


    public abstract class Bedrag{
        public int Centen{get;set;}
        public Bedrag(int centen)
        {
            this.Centen = centen;
        }

        public abstract string Valuta {get;}

        public override string ToString(){
            return $"{this.Valuta} {this.Centen/100}.{this.Centen%100}";
        }
    }

    public class EuroBedrag : Bedrag{
        public EuroBedrag(int centen) : base(centen){}

        public override string Valuta => "EUR";
    }

    public class DollarBedrag : Bedrag{
        public DollarBedrag(int centen) : base(centen){ }

        public override string Valuta => "USD";
    }

}
