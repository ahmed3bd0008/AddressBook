using Entities.Configuration;
using Entities.Modal;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Entities
{
    public class RepoDbContext: IdentityDbContext<IdentityUser<int>, IdentityRole<int>, int>
    {
        public RepoDbContext(DbContextOptions options):base(options)
        {
            
        }
        DbSet<AddressBook> AddressBooks { set; get; }
        DbSet<Job> Jobs { set; get; }
        DbSet<Department> Departments { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //  modelBuilder.ApplyConfiguration(new JobConfiguration());
            //  modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            //  modelBuilder.ApplyConfiguration(new AddressBookConfiguration());
        }
    }
}
