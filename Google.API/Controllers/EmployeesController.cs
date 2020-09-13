using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Google.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Google.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        IEmployeesBL _employeesBL;

        private readonly ILogger<EmployeesController> _logger;

        public EmployeesController(ILogger<EmployeesController> logger, IEmployeesBL employeesBL)
        {
            _logger = logger;
            _employeesBL = employeesBL;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_employeesBL.GetEmployees());
        }
    }
}
