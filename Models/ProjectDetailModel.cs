using System.Text.Json.Serialization;

namespace BlazorApp.Bootstrap5.Models
{
    public class ProjectDetailModel
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; } = string.Empty;

        [JsonPropertyName("shortDescription")]
        public string ProjectDescription { get; set; } = string.Empty;
        public string SkillTags { get; set; } = string.Empty;

        [JsonPropertyName("PersonalProject")]
        public bool IsPersonalProject { get; set; } = false;
        public string GitHubRepoUrl { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string Term { get; set; } = string.Empty;
        public int TeamSize { get; set; }

        [JsonPropertyName("fullDescription")]
        public string CompleteDescription { get; set; } = string.Empty;

        [JsonPropertyName("techTools")]
        public string ToolUsed { get; set; } = string.Empty;

        [JsonPropertyName("rolesResp")]
        public List<RolesResponsibilitiesModel> RolesAndResp { get; set; } = new();
    }
}
