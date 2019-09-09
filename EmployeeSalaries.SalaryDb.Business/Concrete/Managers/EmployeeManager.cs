using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaries.SalaryDb.Business.Abstract;
using EmployeeSalaries.SalaryDb.DataAccess.Abstract;
using EmployeeSalaries.SalaryDb.Entities.Concrete;
using EmployeeSalaries.Core.Aspects.Postsharp;
using EmployeeSalaries.SalaryDb.Business.ValidationRules.FluentValidation;

namespace EmployeeSalaries.SalaryDb.Business.Concrete.Managers
{
   public class EmployeeManager : IEmployeeService
   {
       private IEmployeeDal _employeeDal;

       public EmployeeManager(IEmployeeDal employeeDal)
       {
           _employeeDal = employeeDal;
       }

       public List<Employee> GetAll()
       {
           return _employeeDal.GetList();
       }

        public Employee GetById(int id)
        {
            return _employeeDal.Get(x => x.Id.Equals(id));
        }

        public Employee GetByIdentityNumber(long identityNumber)
        {
            return _employeeDal.Get(x => x.IdentityNumber.Equals(identityNumber));
        }
        [FluentValidationAspect(typeof(EmployeeValidator))]
        public Employee Insert(Employee employee)
        {
            _employeeDal.Add(employee);
            return employee;
        }
    }
}
