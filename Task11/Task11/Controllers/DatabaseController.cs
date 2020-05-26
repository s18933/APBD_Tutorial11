using Microsoft.AspNetCore.Mvc;
using Task11.Models;
using Task11.Requests_Responces;
using Task11.Services;

namespace Task11.Controllers
{
    [Route("api/database")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        private IDatabaseDbService _service;
        public readonly DatabaseDbContext _context;
        public DatabaseController(IDatabaseDbService service, DatabaseDbContext context)
        {
            _service = service;
            _context = context;
        }

        [HttpGet("doctorsList")]
        public IActionResult GetDoctors() 
        {
            var doctors = _service.GetDoctors();
            if (doctors == null)
            {
                return BadRequest("400 Bad Request Error!");
            }
            return Ok(doctors);
        }
        [HttpPost("insertDoctor")]
        public IActionResult InsertDoctors(DoctorRequest request)
        {
            var res = _service.InsertDoctors(request);
            if (res == null)
            {
                return BadRequest("400 Bad Request Error!");
            }
            return Ok(res);
        }
        [HttpPut("updateDoctor")]
        public IActionResult UpdateDoctors(DoctorRequest request)
        {
            var res = _service.UpdateDoctors(request);
            if (res == null)
            {
                return BadRequest("400 Bad Request Error!");
            }
            return Ok(res);
        }

        [HttpDelete("deleteDoctor")]
        public IActionResult DelecteDoctors(DoctorRequest request)
        {
            var res = _service.DeleteDoctors(request);
            if (res == null)
            {
                return BadRequest("400 Bad Request Error!");
            }
            return Ok(res);
        }
        [HttpGet("moodPill")]
        public IActionResult GetMoodPill() 
        {
            return Ok("Some pills for some mood: https://www.youtube.com/watch?v=62Vjm0UGfv8&list=RD62Vjm0UGfv8&start_radio=1");
        }
    }
}