using Employee.Data_Services.Interface;
using Employee.Data_Services.Services;
using Employee.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly EmployeeDbContext _context;
        public readonly IEmployee _employee;
        public EmployeeController(EmployeeDbContext context, IEmployee employee )
        {
            _context = context;
            _employee = employee;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var employee = await _employee.GetByIdAsync(id);
            return employee == null ? NotFound() : Ok(employee);
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployeeAsync(EmployeeTb employee)
        {
            await _employee.AddEmployeeAsync(employee);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = employee.EmployeeID }, employee);
        }
    }
}
