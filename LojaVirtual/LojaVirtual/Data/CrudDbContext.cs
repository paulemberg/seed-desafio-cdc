using Microsoft.EntityFrameworkCore;
using LojaVirtual.Entities;
using LojaVirtual.Entities.Builders;

namespace LojaVirtual.Data {

public abstract class CrudDbContext : DbContext
{

    public DbSet<Entities.Author> Authors { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfiguration(new AuthorTypeConfiguration());
    }
}

}