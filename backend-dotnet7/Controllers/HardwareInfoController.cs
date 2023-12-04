using AutoMapper;
using backend_dotnet7.Core.Constants;
using backend_dotnet7.Core.DbContext;
using backend_dotnet7.Core.Dtos.HardwareInfo;
using backend_dotnet7.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_dotnet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HardwareInfoController : ControllerBase
    {
        private ApplicationDbContext _context { get; }
        private IMapper _mapper { get; }

        private readonly IWebHostEnvironment _webHostEnvironment;


        public HardwareInfoController(ApplicationDbContext context, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
        }


        [HttpPost]
        [Route("Create")]
       // [Authorize(Roles = StaticUserRoles.OwnerAdmin)]

        public async Task<IActionResult> CreateHardwareInfo([FromBody] HardwareInfoCreateDto dto)
        {
            HardwareInfo newHardwareInfo = _mapper.Map<HardwareInfo>(dto);
            await _context.HardwareInfos.AddAsync(newHardwareInfo);
            await _context.SaveChangesAsync();

            return Ok("HardwareInfo Created Successfully");
        }

        [HttpGet]
        [Route("Get")]
     //   [Authorize(Roles = StaticUserRoles.OwnerAdmin)]

        public async Task<ActionResult<IEnumerable<HardwareInfoGetDto>>> GetHardwareInfos()
        {
            var hardwareInfos = await _context.HardwareInfos.OrderByDescending(q => q.CreatedAt).ToListAsync();
            var convertedhardwareInfos = _mapper.Map<IEnumerable<HardwareInfoGetDto>>(hardwareInfos);

            return Ok(convertedhardwareInfos);
        }
    }
}
