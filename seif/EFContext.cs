using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
namespace seif
{
    class EFContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=testEFDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { DE_Id = 1, DE_Name = "it " },
                new Department { DE_Id = 2, DE_Name = "Cs" });

            modelBuilder.Entity<Employee>().HasData(
                new Employee { dp_Id = 1, Emp_Id = 1, Emp_Name = "Seif" }); 

        }
    }
}