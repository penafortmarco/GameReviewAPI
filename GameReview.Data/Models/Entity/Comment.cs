using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GameReview.Data.Models.Entity
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ReviewId { get; set; }
        public Review Review { get; set; }

    }
}
