namespace BusinessSol.Models
{
    public class RefCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Referans> Referanslar { get; set;}
    }
}
