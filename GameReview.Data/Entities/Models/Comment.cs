using System.Text.Json.Serialization;

namespace GameReview.Data.Entities.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ReviewId { get; set; }
        [JsonIgnore]
        public Review Review { get; set; }

    }
}
