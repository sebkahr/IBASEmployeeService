namespace IBASEmployeeService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using IBASEmployeeService.Models;
    
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }
        
        private static List<Employee> _employees = new List<Employee>()
        {
            new Employee() {
                Id = "21",
                Name = "Mette Bangsbo",
                Email = "meba@ibas.dk",
                Department = new Department() {
                    Id = 1,
                    Name = "Salg"
                }
            },
            new Employee() {
                Id = "22",
                Name = "Hans Merkel",
                Email = "hame@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
                Id = "23",
                Name = "Karsten Mikkelsen",
                Email = "kami@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
                Id = "24",
                Name = "Mikkel Hansen",
                Email = "miha@ibas.dk",
                Department = new Department() {
                    Id = 3,
                    Name = "it"
                }
            },
            new Employee() {
                Id = "25",
                Name = "Karl Henriksen",
                Email = "kahe@ibas.dk",
                Department = new Department() {
                    Id = 3,
                    Name = "it"
                }
            },
            new Employee() {
                Id = "26",
                Name = "Sebastian Hansen",
                Email = "seha@ibas.dk",
                Department = new Department() {
                    Id = 3,
                    Name = "it"
                }
            },
            new Employee() {
                Id = "27",
                Name = "Simone Hansen",
                Email = "siha@ibas.dk",
                Department = new Department() {
                    Id = 4,
                    Name = "Kantinen"
                }
            },
            new Employee()
            {
                Id = "28",
                Name = "John Doe",
                Email = "jodo@ibas.dk",
                Department = new Department()
                {
                    Id = 4,
                    Name = "Kantinen"
                }
            }
        }; 
        
        [HttpGet("GetEmployees")] 
        public IEnumerable<Employee> Get() 
        { 
            return _employees; 
        }

        [HttpGet("GetEmployeeByDepartmentId/{departmentId}")]
        public IEnumerable<Employee> GetByDepartmentId(int departmentId)
        {
            return _employees.Where(e => e.Department?.Id == departmentId);
        }
    }


}