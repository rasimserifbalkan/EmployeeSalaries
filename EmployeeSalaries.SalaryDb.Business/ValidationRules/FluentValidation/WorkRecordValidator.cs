using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaries.SalaryDb.Entities.Concrete;
using FluentValidation;

namespace EmployeeSalaries.SalaryDb.Business.ValidationRules.FluentValidation
{
    public class WorkRecordValidator : AbstractValidator<WorkRecord>
    {
        public WorkRecordValidator()
        {
            RuleFor(p => p.EmployeeId).NotEqual(0);
            RuleFor(p => p.WorkStart).GreaterThan(DateTime.Today);
        }
    }
}
