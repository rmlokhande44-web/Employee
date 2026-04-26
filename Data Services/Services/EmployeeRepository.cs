using Employee.Data_Services.Interface;
using Employee.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee.Data_Services.Services
{
    public class EmployeeRepository : IEmployee
    {
        private readonly EmployeeDbContext _context;
        public EmployeeRepository(EmployeeDbContext context) => _context = context;

        public async Task<IEnumerable<EmployeeTb>> GetAllEmployeeAsync() =>
            await _context.EmployeeTb.ToListAsync();

        public async Task<EmployeeTb?> GetByIdAsync(int id) =>
            await _context.EmployeeTb.FindAsync(id);

        public async Task AddEmployeeAsync(EmployeeTb employee)
        {
            _context.EmployeeTb.Add(employee);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeAsync(EmployeeTb employee)
        {
            _context.EmployeeTb.Update(employee);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            var employee = await _context.EmployeeTb.FindAsync(id);
            if (employee != null)
            {
                _context.EmployeeTb.Remove(employee);
                await _context.SaveChangesAsync();
            }
        }
    }
}
