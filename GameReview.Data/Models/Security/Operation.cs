namespace GameReview.Data.Models.Security
{
    public class Operation
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public Module Module { get; set; }
        public string Name { get; set; }

    }
}