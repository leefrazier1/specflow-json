using Newtonsoft.Json;

namespace SpecResults.Model
{
    public class StepResult
    {
        public string Duration { get; set; }

        public string Status { get; set; }

        [JsonProperty("error_message")]
        public string Error { get; set; }
    }
}