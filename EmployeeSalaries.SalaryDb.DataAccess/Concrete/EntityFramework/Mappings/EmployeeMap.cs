using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaries.SalaryDb.Entities.Concrete;

namespace EmployeeSalaries.SalaryDb.DataAccess.Concrete.EntityFramework.Mappings
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            ToTable(@"Employees", @"SalaryDb");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("ID");
            Property(x => x.FirstName).HasColumnName("FirstName");
            Property(x => x.LastName).HasColumnName("LastName");
            Property(x => x.IdentityNumber).HasColumnName("IdentityNumber");
            Property(x => x.SalaryTypeId).HasColumnName("SalaryTypeId");
          
        }
    }
}
