using FluentAssertions;
using NUnit.Framework;
using PeachIT.HRMLite.Contracts;
using PeachIT.HRMLite.Domain;
using PeachIT.HRMLite.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PeachIT.HRMLite.BL.Test
{
    public class EmployeeServiceTest : TestBase
    { 
        private IEmployeeService service;

        [SetUp]
        public void Setup()
        {
            service = (IEmployeeService)services.GetService(typeof(IEmployeeService));
        }

        [Test]
        public void GetAllEmployees_ShouldNotReturnData()
        {
            var result = service.GetEmployees();

            result.Count.Should().BeGreaterOrEqualTo(0);
            result.Should().BeOfType<List<EmployeeModel>>();
        }

        [Test]
        public void SaveEmployee_WithValidModel_ShouldAddUserSurvey()
        {
            var employeeName = Guid.NewGuid().ToString();
            var result = service.SaveEmployee(new EmployeeModel()
            {
                Name = employeeName,
                Address = Guid.NewGuid().ToString()
            });
            

            var employee = context.Employees.First<Employee>(p => p.Name == employeeName);
            employee.Should().NotBeNull();
        }
    }
}
