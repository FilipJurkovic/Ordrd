using Microsoft.EntityFrameworkCore;
using Ordrd.Models;

namespace Ordrd.Data

{
    public class OrdrdContext : DbContext
    {
        public DbSet<Food> Foods { get; set; } = null!;
        public DbSet<Option> Options { get; set; } = null!;
        public DbSet<Extra> Extras { get; set; } = null!;
        public DbSet<OrderedFood> OrderedFoods { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}