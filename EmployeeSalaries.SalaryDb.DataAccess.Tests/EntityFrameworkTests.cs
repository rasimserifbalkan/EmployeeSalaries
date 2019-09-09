using System;
using EmployeeSalaries.SalaryDb.DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeSalaries.SalaryDb.DataAccess.Tests
{
    [TestClass]
    public class EntityFrameworkTests
    {
        /// <summary>
        /// Dönen kayıtlar 0 a eşit değil ise
        /// </summary>
        [TestMethod]
        public void Get_Employees_All()
        {
            EfEmployeeDal efEmployeeDal = new EfEmployeeDal();
            var result = efEmployeeDal.GetList();
            Assert.AreNotEqual(0,result.Count);
        }
    }
}
