using Newtonsoft.Json;

namespace Spectra.Model.Client.Models
{
    public class Export
    {
        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("iteration_id")]
        public string IterationId { get; set; }

        [JsonProperty("project_name")]
        public string ProjectName { get; set; }

        [JsonProperty("image_count")]
        public int ImageCount { get; set; }

        [JsonProperty("zipped_project")]
        public string ZippedProject { get; set; }
    }
}
