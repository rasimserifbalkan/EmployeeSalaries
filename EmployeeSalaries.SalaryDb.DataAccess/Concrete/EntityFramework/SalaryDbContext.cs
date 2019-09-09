using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Data.Entity;
using EmployeeSalaries.SalaryDb.DataAccess.Concrete.EntityFramework.Mappings;
using EmployeeSalaries.SalaryDb.Entities.Concrete;

namespace EmployeeSalaries.SalaryDb.DataAccess.Concrete.EntityFramework
{
    public class SalaryDbContext : DbContext
    {
        public SalaryDbContext()
            : base("data source=159.253.45.25;initial catalog=SalaryDb;user id=SalaryDb;password=@2Hly03v;MultipleActiveResultSets=True;App=EntityFramework")
        {
            Database.SetInitializer<SalaryDbContext>(null);
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<SalaryType> SalaryTypes { get; set; }
        public virtual DbSet<WorkRecord> WorkRecords { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.WorkRecords)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalaryType>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.SalaryType)
                .WillCascadeOnDelete(false);

           modelBuilder.Configurations.Add(new EmployeeMap());
        }
    }
}
