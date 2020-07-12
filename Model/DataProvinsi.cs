using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Model
{
    class DataProvinsi
    {
        [JsonProperty(PropertyName = "Provinsi")]
        public string Provinsi { get; set; }

        [JsonProperty(PropertyName = "Kasus_Posi")]
        public string Positif { get; set; }

        [JsonProperty(PropertyName = "Kasus_Semb")]
        public string Sembuh { get; set; }

        [JsonProperty(PropertyName = "Kasus_Meni")]
        public string Meninggal { get; set; }
    }
}
