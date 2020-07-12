using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Model
{
    class DataIndonesia
    {
        [JsonProperty(PropertyName = "name")]
        public string Provinsi { get; set; }
        [JsonProperty(PropertyName = "positif")]
        public string Positif { get; set; }
        [JsonProperty(PropertyName = "sembuh")]
        public string Sembuh { get; set; }
        [JsonProperty(PropertyName = "meninggal")]
        public string Meninggal { get; set; }
    }
}
