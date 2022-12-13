using System.Text.Json.Serialization;

namespace BlazorApp.Bootstrap5.Models
{
    public class AboutMeModel
    {
        [JsonPropertyName("testimonals")]
        public List<TestimonalsModel> Testimonals { get; set; } = new();
    }
}
