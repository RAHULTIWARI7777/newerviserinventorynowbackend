﻿namespace backend_dotnet7.Core.Entities
{
    public class EmployeeHardwareInfo : BaseEntity<long>
    {

        public string Remarks { get; set; }


        //Relations 

        public long EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public long HardwareInfoId { get; set; }
        public HardwareInfo HardwareInfo { get; set; }

    }
}