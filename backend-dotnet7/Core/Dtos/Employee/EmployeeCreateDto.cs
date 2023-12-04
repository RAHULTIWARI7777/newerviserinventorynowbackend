using System.ComponentModel.DataAnnotations;

namespace backend_dotnet7.Core.Dtos.Employee
{
    public class EmployeeCreateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }

        
        public string JoiningDate { get; set; }


    }
}
