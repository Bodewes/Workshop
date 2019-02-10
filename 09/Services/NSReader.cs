using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace StationSite.Services{
    public class NSReader : IReadStations{

        private readonly string API_KEY;

        public NSReader(IConfiguration config)
        {
            this.API_KEY = config["NSAPIKEY"];
        }

        public async Task<List<DTO.Station>> ReadStations(){

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-api-key", API_KEY);
            var response = await client.GetAsync("https://ns-api.nl/reisinfo/api/v2/stations");

            if (response.StatusCode != HttpStatusCode.OK){
                //Console.WriteLine($"Oopsie Woepsie, dat ging niet lekker: {response.ReasonPhrase}");
                throw new Exception($"Kon geen data ophalen: {response.ReasonPhrase}");
            }

            var json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<DTO.RootObject>(json);

            return data.payload;
        }

    }
 }