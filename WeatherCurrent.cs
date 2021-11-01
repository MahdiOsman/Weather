using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public class WeatherCurrent
    {
        [JsonProperty("temp_c")]
        public string TempC { get; set; }
        [JsonProperty("temp_f")]
        public string TempF { get; set; }
        [JsonProperty("condition")]
        public WeatherCondition Condition { get; set; }
    }
}
