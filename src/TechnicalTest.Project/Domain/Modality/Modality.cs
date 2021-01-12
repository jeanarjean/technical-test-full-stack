using JsonSubTypes;

using Newtonsoft.Json;

namespace TechnicalTest.Project.Domain.Modality
{
    [JsonConverter(typeof(JsonSubtypes), "type")]

    public abstract class Modality
    {
        public string Type { get; set; }

        public string Name { get; set; }
    }
}