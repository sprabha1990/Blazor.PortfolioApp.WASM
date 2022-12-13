using System.Text.Json.Serialization;

namespace BlazorApp.Bootstrap5.Models
{
    public class PortfolioModel
    {
        [JsonPropertyName("aboutme")]
        public AboutMeModel AboutMeModel { get; set; } = new();
    }
}
