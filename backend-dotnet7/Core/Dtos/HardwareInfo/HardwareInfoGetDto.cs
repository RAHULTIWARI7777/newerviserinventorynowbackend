using backend_dotnet7.Core.Enums;

namespace backend_dotnet7.Core.Dtos.HardwareInfo
{
    public class HardwareInfoGetDto
    {
        public HardwareType Type { get; set; }
        public string SerialNo { get; set; }
        public string PurchaseDate { get; set; }

        public string WarrantyEndDate { get; set; }

        public string Condition { get; set; }

        public string Location { get; set; }

        public string Notes { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public string AssetTag { get; set; }

        public string Brand { get; set; }

        public string PurchaseOrderNumber { get; set; }

        public string AssignedDate { get; set; }

        public string? RetiredDate { get; set; }

        public string MaintenanceSchedule { get; set; }

        public string AssignedBy { get; set; }

        public string? LastServiceDate { get; set; }

        public string? ReplacementDate { get; set; }

        public string SupportContact { get; set; }

        public string DisposalMethod { get; set; }

        public long ID { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
