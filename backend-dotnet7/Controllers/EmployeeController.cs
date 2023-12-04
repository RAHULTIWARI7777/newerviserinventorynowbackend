using AutoMapper;
using backend_dotnet7.Core.Constants;
using backend_dotnet7.Core.DbContext;
using backend_dotnet7.Core.Dtos.Employee;
using backend_dotnet7.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_dotnet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {


        private ApplicationDbContext _context { get; }
        private IMapper _mapper { get; }
        // private readonly IWebHostEnvironment _webHostEnvironment; , IWebHostEnvironment webHostEnvironment  _webHostEnvironment = webHostEnvironment;
        public EmployeeController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
           

        }


        [HttpPost]
        [Route("Create")]
     //   [Authorize(Roles = StaticUserRoles.OwnerAdmin)]
        public async Task<IActionResult> CreateEmployee([FromForm] EmployeeCreateDto dto, IFormFile pdfFile)
        {
            // Firt => Save pdf to Server
            // Then => save url into our entity
            var fiveMegaByte = 20 * 1024 * 1024;
            var pdfMimeType = "application/pdf";

            if (pdfFile.Length > fiveMegaByte || pdfFile.ContentType != pdfMimeType)
            {
                return BadRequest("File is not valid");
            }

            var documentUrl = Guid.NewGuid().ToString() + ".pdf";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "documents", "pdfs", documentUrl);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await pdfFile.CopyToAsync(stream);
            }
            var newEmployee = _mapper.Map<Employee>(dto);
            newEmployee.DocumentUrl = documentUrl;
            await _context.Employees.AddAsync(newEmployee);
            await _context.SaveChangesAsync();

            return Ok("Employee Created Successfully");
        }



        [HttpGet]
        [Route("Get")]
        // [Authorize(Roles = StaticUserRoles.OwnerAdmin)]
        public async Task<ActionResult<IEnumerable<EmployeeGetDto>>> GetEmployees()
        {
            var employees = await _context.Employees.OrderBy(q => q.CreatedAt).ToListAsync();
            var convertedEmployees = _mapper.Map<IEnumerable<EmployeeGetDto>>(employees);

            return Ok(convertedEmployees);
        }


        [HttpGet]
        [Route("download/{url}")]
        public IActionResult DownloadPdfFile(string url)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "documents", "pdfs", url);

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound("File Not Found");
            }

            var pdfBytes = System.IO.File.ReadAllBytes(filePath);
            var file = File(pdfBytes, "application/pdf", url);
            return file;
        }
    }
}