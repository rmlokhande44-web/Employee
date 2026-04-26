using Employee.Models;

namespace Employee.Data_Services.Interface
{
    public interface IEmployee
    {
        Task<EmployeeTb> GetByIdAsync (int id);
        Task AddEmployeeAsync (EmployeeTb employee);
        Task UpdateEmployeeAsync (EmployeeTb employee);
        Task DeleteEmployeeAsync(int id);
        Task<IEnumerable<EmployeeTb>> GetAllEmployeeAsync();
    }
}
 