using AutoMapper;
using backend_dotnet7.Core.Constants;
using backend_dotnet7.Core.DbContext;
using backend_dotnet7.Core.Dtos.EmployeeHardwareInfo;
using backend_dotnet7.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_dotnet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeHardwareInfoController : ControllerBase
    {
        private ApplicationDbContext _context { get; }
        private IMapper _mapper { get; }

        public EmployeeHardwareInfoController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Create
        [HttpPost]
        [Route("Create")]
        [Authorize(Roles = StaticUserRoles.OwnerAdmin)]
        public async Task<IActionResult> CreateEmployeeHardwareInfo([FromBody] EmployeeHardwareInfoCreateDto dto)
        {
            var newEmployeeHardwareInfo = _mapper.Map<EmployeeHardwareInfo>(dto);
            await _context.EmployeeHardwareInfos.AddAsync(newEmployeeHardwareInfo);
            await _context.SaveChangesAsync();

            return Ok("EmployeeHardwareInfo Created Successfully");
        }




        [HttpGet]
        [Route("Get")]
        [Authorize(Roles = StaticUserRoles.OwnerAdmin)]
        public async Task<ActionResult<IEnumerable<EmployeeHardwareInfoGetDto>>> GetEmployeeHardwareInfos()
        {
            var employeeHardwareInfos = await _context.EmployeeHardwareInfos
                .Include(ehi => ehi.Employee)
                .Include(ehi => ehi.HardwareInfo) // Include HardwareInfo
                .OrderByDescending(ehi => ehi.CreatedAt)
                .ToListAsync();

            var convertedEmployeeHardwareInfos = _mapper.Map<IEnumerable<EmployeeHardwareInfoGetDto>>(employeeHardwareInfos);

            return Ok(convertedEmployeeHardwareInfos);
        }
    }
}
