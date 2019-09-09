﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaries.Core.DataAccess;
using EmployeeSalaries.SalaryDb.Entities.Concrete;

namespace EmployeeSalaries.SalaryDb.DataAccess.Abstract
{
    public interface IEmployeeDal:IEntityRepository<Employee>
    {
    }
}
