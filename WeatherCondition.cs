using Newtonsoft.Json;

namespace Weather
{
    public class WeatherCondition
    {
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; } 

    }
}