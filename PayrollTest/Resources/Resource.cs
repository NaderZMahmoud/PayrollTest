using Newtonsoft.Json;

namespace PayrollTest.API.Resources
{
    public abstract class Resource
    {
        [JsonProperty(Order = -2)]
        public string Href { get; set; }
    }
}
