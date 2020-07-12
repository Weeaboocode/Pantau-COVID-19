using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsFormsApp4.Model
{
    class Attributess
    {
        [JsonProperty(PropertyName = "attributes")]
        public DataGlobal attributess { get; set; }
    }
}
