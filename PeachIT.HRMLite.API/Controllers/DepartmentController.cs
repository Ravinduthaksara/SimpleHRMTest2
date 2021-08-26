using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PeachIT.HRMLite.Contracts;
using PeachIT.HRMLite.Models;
using Microsoft.Extensions.Logging;
using PeachIT.HRMLite.Domain;

namespace PeachIT.HRMLite.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : Controller
    {
        private readonly ILogger<DepartmentController> _logger;
        private readonly IDepartmentService departmentService;

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IEnumerable<Department> Get()
        {
            return departmentService.GetDepartment();
        }

        [HttpPost]
        public int SaveDepartment([FromBody] DepartmentModel departmentModel)
        {
            return departmentService.SaveDepartment(departmentModel);
        }
    }
}
