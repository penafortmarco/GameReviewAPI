using GameReview.Data.Models.Security;
using System.Text.Json.Serialization;

namespace GameReview.Data.Models.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePicture { get; set; }
        public int RolId { get; set; }
        [JsonIgnore]
        public Rol Rol { get; set; }
    }
}
