using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ordrd.Models
{
    public class Option
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public List<Extra> Extras { get; set; } = null!;
    }

    public class Extra
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
    }
}
