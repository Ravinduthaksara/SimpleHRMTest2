using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PeachIT.HRMLite.Contracts;
using PeachIT.HRMLite.Models;
using System.Collections.Generic;

namespace PeachIT.HRMLite.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployeeService employeeService;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            this.employeeService = employeeService;
        }

        [HttpGet]
        public IEnumerable<EmployeeModel> Get()
        {
            return employeeService.GetEmployees();
        }

        [HttpPost]
        public int SaveEmployee([FromBody] EmployeeModel employeeModel)
        {
            return employeeService.SaveEmployee(employeeModel);
        }
    }
}




