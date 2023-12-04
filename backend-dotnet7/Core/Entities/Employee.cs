using System.ComponentModel.DataAnnotations;

namespace backend_dotnet7.Core.Entities
{
    public class Employee : BaseEntity<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }

        
        public string JoiningDate { get; set; }

        public string DocumentUrl { get; set; }



        //Relations
        public ICollection<EmployeeHardwareInfo> EmployeeHardwareInfos { get; set; }
    }
}