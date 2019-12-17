using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using classroom_api_c__tutorial.Data;
using classroom_api_c__tutorial.Models;

namespace classroom_api_c__tutorial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly StudentContext _context;

        public StudentsController(StudentContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAll() =>
            _context.Students.ToList();

        // GET by ID action

        // POST action

        // PUT action

        // DELETE action
    }
}