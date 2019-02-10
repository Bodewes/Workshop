using System.Collections.Generic;

namespace StationSite.Services.DTO{
    public class RootObject
    {
        public List<Station> payload { get; set; }
    }
    

    public class Namen
    {
        public string lang { get; set; }
        public string kort { get; set; }
        public string middel { get; set; }
    }

    public class Station
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