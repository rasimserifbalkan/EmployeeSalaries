using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaries.SalaryDb.Entities.Concrete;

namespace EmployeeSalaries.SalaryDb.Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        Employee GetById(int id);
        Employee GetByIdentityNumber(long identityNumber);

        Employee Insert(Employee employee);
    }
}
