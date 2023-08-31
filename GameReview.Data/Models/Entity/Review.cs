using System.Text.Json.Serialization;

namespace GameReview.Data.Models.Entity
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }

        [JsonIgnore]
        public ICollection<Like>? Likes { get; set; }
        [JsonIgnore]
        public ICollection<Comment>? Comments { get; set; }

    }
}