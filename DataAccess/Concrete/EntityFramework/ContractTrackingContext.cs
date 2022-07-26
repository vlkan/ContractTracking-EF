﻿using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework;

// Context : connect db and project class
public class ContractTrackingContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Invoice> Invoicings { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<WorkList> WorkLists { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ContractTracking;Trusted_Connection=true");
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlCon"));
    }
}
