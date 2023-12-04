using System.ComponentModel.DataAnnotations;

namespace backend_dotnet7.Core.Dtos.Employee
{
    public class EmployeeGetDto
    {
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }

        
        public string JoiningDate { get; set; }

        public string DocumentUrl { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
