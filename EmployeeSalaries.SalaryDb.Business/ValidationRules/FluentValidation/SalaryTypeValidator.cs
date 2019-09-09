using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaries.SalaryDb.Entities.Concrete;
using FluentValidation;

namespace EmployeeSalaries.SalaryDb.Business.ValidationRules.FluentValidation
{
    public class SalaryTypeValidator : AbstractValidator<SalaryType>
    {
        public SalaryTypeValidator()
        {
            RuleFor(p => p.TypeName).NotEmpty().Length(0, 150);
            RuleFor(p => p.IsActive).NotEmpty();
        }
    }
}
