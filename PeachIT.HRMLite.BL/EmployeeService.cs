using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using PeachIT.HRMLite.Contracts;
using PeachIT.HRMLite.DAL;
using PeachIT.HRMLite.Domain;
using PeachIT.HRMLite.Models;

namespace PeachIT.HRMLite.BL
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HRMLiteContext context;
        private readonly IMapper mapper;

        public EmployeeService(HRMLiteContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public List<EmployeeModel> GetEmployees()
        {
            var employees = context.Employees.ToList();
            return mapper.Map<List<EmployeeModel>>(employees);
        }

        public int SaveEmployee(EmployeeModel employeeModel)
        {
            if (employeeModel == null)
                throw new ArgumentNullException();

            Employee employee = employeeModel.Id > 0 ?
                context.Employees.Single<Employee>(p => p.Id == employeeModel.Id) :
                new Employee();

            employee = mapper.Map<Employee>(employeeModel);
            context.Add(employee);
            context.SaveChanges();

            return employee.Id;
        }
    }
}
