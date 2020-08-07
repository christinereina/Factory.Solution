using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryrContext : DbContext
  {
    public virtual DbSet<Engineer> Engineer { get; set; }
    public DbSet<Machine> Machines { get; set; }
    public DbSet<EngineerMachine> EngineerMachine { get; set;}
    public FactoryContext(DbContextOptions options) : base(options) { }
  }
}