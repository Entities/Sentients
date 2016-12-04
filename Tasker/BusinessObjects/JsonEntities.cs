using Newtonsoft.Json;

namespace BusinessObjects
{
    public class JsonEntities
    {
        [JsonProperty("System.AreaPath")]
        public string AreaPath { get; set; }
    }
}
