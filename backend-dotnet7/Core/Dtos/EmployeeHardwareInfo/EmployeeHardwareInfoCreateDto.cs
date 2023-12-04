namespace backend_dotnet7.Core.Dtos.EmployeeHardwareInfo
{
    public class EmployeeHardwareInfoCreateDto
    {
        public string Remarks { get; set; }
        public long EmployeeId { get; set; }

        public long HardwareInfoId { get; set; }
    }
}
