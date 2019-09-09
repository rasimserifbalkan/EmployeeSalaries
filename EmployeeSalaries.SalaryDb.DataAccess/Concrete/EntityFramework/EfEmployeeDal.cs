using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaries.Core.DataAccess.EntityFramework;
using EmployeeSalaries.SalaryDb.DataAccess.Abstract;
using EmployeeSalaries.SalaryDb.Entities.Concrete;

namespace EmployeeSalaries.SalaryDb.DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, SalaryDbContext>, IEmployeeDal
    {
    }
}
