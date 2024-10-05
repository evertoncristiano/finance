using Microsoft.EntityFrameworkCore;

namespace Finance.API.Models;

public class FinanceContext : DbContext
{
    public FinanceContext(DbContextOptions<FinanceContext> options)
        : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; } = null!;
}