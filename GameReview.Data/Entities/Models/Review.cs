using System.ComponentModel.DataAnnotations.Schema;

namespace GameReview.Data.Entities.Models
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
        [NotMapped]
        public int LikeCount { get; set; }
        public ICollection<Like>? Likes { get; set; }
        public ICollection<Comment>? Comments { get; set; }

    }
}