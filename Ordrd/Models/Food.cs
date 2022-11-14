using System.ComponentModel.DataAnnotations.Schema;

namespace Ordrd.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public List<Option> Options { get; set; } = null!;

    }
}
