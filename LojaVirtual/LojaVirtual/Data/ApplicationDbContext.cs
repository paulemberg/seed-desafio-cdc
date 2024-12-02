using Microsoft.EntityFrameworkCore;

namespace LojaVirtual.Data;

public class ApplicationDbContext : CrudDbContext
{
    public ApplicationDbContext(DbContextOptions<CrudDbContext> options)
    {
    }
}