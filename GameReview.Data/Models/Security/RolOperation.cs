namespace GameReview.Data.Models.Security
{
    public class RolOperation
    {
        public int Id { get; set; }
        public int RolId { get; set; }
        public Rol Rol { get; set; }
        public int OperationId { get; set; }
        public Operation Operation { get; set; }
    }
}
