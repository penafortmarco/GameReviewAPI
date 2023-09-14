using System.Text.Json.Serialization;

namespace GameReview.Data.Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePicture { get; set; }
        [JsonIgnore]
        public ICollection<Review>? Reviews { get; set; }
    }
}
