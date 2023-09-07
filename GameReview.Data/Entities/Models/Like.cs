using System.Text.Json.Serialization;

namespace GameReview.Data.Entities.Models
{
    public class Like
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
        public int ReviewId { get; set; }
        [JsonIgnore]
        public Review Review { get; set; }
    }
}
