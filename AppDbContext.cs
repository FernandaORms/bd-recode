using Microsoft.EntityFrameworkCore;
namespace dbcodefirst
{
    public class AppDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          optionsBuilder.UseSqlServer("Data Source=DESKTOP-1KRMKFK;" +
          "Initial Catalog= EFCoreDB; Integrated Security=True");
        }
    }
}