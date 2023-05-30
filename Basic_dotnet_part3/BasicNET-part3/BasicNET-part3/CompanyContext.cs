using BasicNET_part3.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicNET_part3
{
    public class CompanyContext: DbContext
    {
        private readonly string connectionString = @"Server=EN1410586\SQLEXPRESS;Database=Company;Trusted_Connection=True;Trusted_Connection=SSPI;Encrypt=false;";

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Address> Addresses { get; set; }
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }        
    }
}
