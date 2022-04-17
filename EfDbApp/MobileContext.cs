using System.Data.Entity;

public class MobileContext : DbContext
{
    public MobileContext() : base("DefaultConnection")
    {

    }
    public DbSet<Phone> Phones { get; set; }
}