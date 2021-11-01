using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public class WeatherApiResponse
    {
        [JsonProperty("location")]
        public WeatherLocation Location { get; set; }
        [JsonProperty("current")]
        public WeatherCurrent Current { get; set; }
    }
}
