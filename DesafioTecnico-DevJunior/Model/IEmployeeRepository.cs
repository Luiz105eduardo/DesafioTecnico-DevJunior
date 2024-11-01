using Microsoft.AspNetCore.Mvc;

namespace DesafioTecnico_DevJunior.Model
{
    public interface IEmployeeRepository
    {
        void add(IEmployeeRepository employee);

        List<IEmployeeRepository> Get();
    }
namespace DesafioTecnico_DevJunior.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class EmployeesController : ControllerBase
        {
            private readonly IEmployeeRepository _employeeRepository;

            public EmployeesController(IEmployeeRepository employeeRepository)
            {
                _employeeRepository = employeeRepository;
            }

            [HttpGet]
            public IActionResult GetEmployees()
            {
                var employees = _employeeRepository.Get();
                if (employees == null || employees.Count == 0)
                {
                    return NotFound("No employees found!");
                }
                return Ok(employees);
            }
        }
    }
}

