using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework;

// Context : connect db and project class
public class ProjectAndEmployeeTrackContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ProjectAndEmployeeTrack;Trusted_Connection=true");
    }

    public DbSet<Customer> Customer { get; set; }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<Payment> Payment { get; set; }
    public DbSet<Project> Project { get; set; }
    public DbSet<WeeklyWorkList> WeeklyWorkList { get; set; }
}
