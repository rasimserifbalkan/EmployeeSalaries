using System;
using EmployeeSalaries.SalaryDb.Business.Concrete.Managers;
using EmployeeSalaries.SalaryDb.DataAccess.Abstract;
using EmployeeSalaries.SalaryDb.Entities.Concrete;
using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EmployeeSalaries.SalaryDb.Business.Tests
{
    [TestClass]
    public class EmployeeManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Employee_validation_check()
        {
            Mock<IEmployeeDal> mock = new Mock<IEmployeeDal>();
            EmployeeManager employeeManager = new EmployeeManager(mock.Object);
            employeeManager.Insert(new Employee());
        }
    }
}
