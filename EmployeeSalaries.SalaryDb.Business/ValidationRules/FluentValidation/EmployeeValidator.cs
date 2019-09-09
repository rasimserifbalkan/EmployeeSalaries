using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaries.SalaryDb.Entities.Concrete;
using FluentValidation;

namespace EmployeeSalaries.SalaryDb.Business.ValidationRules.FluentValidation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty().Length(0, 20);
            RuleFor(p => p.IdentityNumber).NotEmpty().GreaterThan(0).LessThan(99999999999);
            RuleFor(p => p.LastName).NotEmpty().Length(0, 20);
            RuleFor(p => p.SalaryTypeId).NotEqual(0);
        }
    }
}
