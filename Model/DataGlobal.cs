using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Model
{
    class DataGlobal
    {
        [JsonProperty(PropertyName = "Country_Region")]
        public string Negara { get; set; }

        [JsonProperty(PropertyName = "Confirmed")]
        public string Positif { get; set; }

        [JsonProperty(PropertyName = "Recovered")]
        public string Sembuh { get; set; }

        [JsonProperty(PropertyName = "Deaths")]
        public string Meninggal { get; set; }
        [JsonProperty(PropertyName = "Last_Update")]
        public string Tanggal { get; set; }
        [JsonProperty(PropertyName = "Lat")]
        public string Latitude { get; set; }

        [JsonProperty(PropertyName = "Long_")]
        public string Longitude { get; set; }
    }
}
