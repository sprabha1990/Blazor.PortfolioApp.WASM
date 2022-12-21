using System.Text.Json.Serialization;

namespace BlazorApp.Bootstrap5.Models
{
    public class PostsModel
    {
        public string PostTitle { get; set; } = string.Empty;
        public string PublishedDate { get; set; } = string.Empty;

        [JsonPropertyName("shortDesc")]
        public string PostContent { get; set; } = string.Empty;

        public string PostUrl { get; set; } = string.Empty;
        public int LikesCount { get; set; }
        public int CommentCount { get; set; }
        public int BookmarkCount { get; set; }
        public string Tags { get; set; } = string.Empty;
    }
}
