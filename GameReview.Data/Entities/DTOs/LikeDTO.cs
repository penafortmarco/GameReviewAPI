using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReview.Data.Entities.DTOs
{
    public class LikeDTO
    {
        public int ReviewId { get; set; }
        public int UserId { get; set; }
    }
}
