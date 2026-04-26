using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class EmployeeTb
    {
        [Key]
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string email { get; set; }
        public string Position { get; set; }

    }
}
