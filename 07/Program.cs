using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Web
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var r = new NSReader();
            await r.ReadStations();
          
        }
    }

    public class NSReader{
        const string API_KEY = "<je ns api key hier>";

        public async Task ReadStations(){

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-api-key", API_KEY);
            var response = await client.GetAsync("https://ns-api.nl/reisinfo/api/v2/stations");

            if (response.StatusCode != HttpStatusCode.OK){
                Console.WriteLine($"Oopsie Woepsie, dat ging niet lekker: {response.ReasonPhrase}");
                return;
            }

            var json = await response.Content.ReadAsStringAsync();

            //Console.WriteLine(json);

            var data = JsonConvert.DeserializeObject<RootObject>(json);

            Console.WriteLine($"Aantal stations: {data.payload.Count}");

            var perLand = data.payload.GroupBy(p => p.land);
            foreach(var land in perLand){
                Console.WriteLine($"In {land.Key} zijn {land.Count()} stations bekend");
            }

        }

    }










    public class RootObject
    {
        public List<Payload> payload { get; set; }
    }
    

    public class Namen
    {
        public string lang { get; set; }
        public string kort { get; set; }
        public string middel { get; set; }
    }

    public class Payload
    {
        public List<object> sporen { get; set; }
        public List<object> synoniemen { get; set; }
        public bool heeftFaciliteiten { get; set; }
        public bool heeftVertrektijden { get; set; }
        public bool heeftReisassistentie { get; set; }
        public string code { get; set; }
        public Namen namen { get; set; }
        public string stationType { get; set; }
        public string land { get; set; }
        public string UICCode { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public int radius { get; set; }
        public int naderenRadius { get; set; }
        public string EVACode { get; set; }
    }



}
