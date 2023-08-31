using GameReview.Data.Models.Security;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GameReview.Data.Models.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RolId { get; set; }
        public Rol Rol { get; set; }
    }
}
