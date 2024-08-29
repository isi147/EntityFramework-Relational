using ConsoleApp24.Entites;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp24.Context;

//ELeqali table ile iwlemek ucun 3 yol

//1.ci standart yoldu
//2.Data annotation
//3.Fluent Api


public class AcdemyContext:DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=STHQ0116-01;Initial Catalog = AcademyyDb;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

        base.OnConfiguring(optionsBuilder);
    }
}
