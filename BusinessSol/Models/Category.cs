using System.ComponentModel.DataAnnotations;

namespace BusinessSol.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
