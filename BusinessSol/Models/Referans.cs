namespace BusinessSol.Models
{
    public class Referans
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RefCategoryId { get; set; }
        public RefCategory RefCategory { get; set; }
    }
}
