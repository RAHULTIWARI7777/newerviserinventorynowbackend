using backend_dotnet7.Core.Entities;
using backend_dotnet7.Core.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace backend_dotnet7.Core.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Log> Logs { get; set; }
        public DbSet<Message> Messages { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<HardwareInfo> HardwareInfos { get; set; }
        public DbSet<EmployeeHardwareInfo> EmployeeHardwareInfos { get; set; }








        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Config anything we want for Identity
            builder.Entity<ApplicationUser>(e =>
            {
                e.ToTable("Users");
            });

            builder.Entity<IdentityUserClaim<string>>(e =>
            {
                e.ToTable("UserClaims");
            });

            builder.Entity<IdentityUserLogin<string>>(e =>
            {
                e.ToTable("UserLogins");
            });

            builder.Entity<IdentityUserToken<string>>(e =>
            {
                e.ToTable("UserTokens");
            });

            builder.Entity<IdentityRole>(e =>
            {
                e.ToTable("Roles");
            });

            builder.Entity<IdentityRoleClaim<string>>(e =>
            {
                e.ToTable("RoleClaims");
            });

            builder.Entity<IdentityUserRole<string>>(e =>
            {
                e.ToTable("UserRoles");
            });

            // Config for Employee, HardwareInfo, EmployeeHardwareInfo
            builder.Entity<Employee>()
                .HasMany(e => e.EmployeeHardwareInfos)
                .WithOne(ehi => ehi.Employee)
                .HasForeignKey(ehi => ehi.EmployeeId);

            builder.Entity<HardwareInfo>()
                .HasMany(hi => hi.EmployeeHardwareInfos)
                .WithOne(ehi => ehi.HardwareInfo)
                .HasForeignKey(ehi => ehi.HardwareInfoId);

            builder.Entity<HardwareInfo>()
                .Property(hardwareInfo => hardwareInfo.Type)
                .HasConversion<string>();

            var typeConverter = new ValueConverter<HardwareType, string>(
                v => v.ToString(),
                v => (HardwareType)Enum.Parse(typeof(HardwareType), v)
            );

            builder.Entity<HardwareInfo>()
                .Property(hardwareInfo => hardwareInfo.Type)
                .HasConversion(typeConverter);
        }

    }
}
