using System.Text.Json.Serialization;

namespace BlazorApp.Bootstrap5.Models
{
    public class ExperienceModel
    {
        public string CompanyName { get; set; } = string.Empty;

        [JsonPropertyName("shortDescription")]
        public string Description { get; set; } = string.Empty;

        public string FullTerm { get; set; } = string.Empty;
        public List<DesignationModel> Designations { get; set; } = new();
    }
}
