using System.Text.Json.Serialization;

namespace BlazorApp.Bootstrap5.Models
{
    public class PortfolioModel
    {
        [JsonPropertyName("aboutme")]
        public AboutMeModel AboutMeModel { get; set; } = new();

        [JsonPropertyName("projects")]
        public List<ProjectDetailModel> ProjectDetailModel { get; set; } = new();

        [JsonPropertyName("experiences")]
        public List<ExperienceModel> ExperienceModel { get; set; } = new();
    }
}
