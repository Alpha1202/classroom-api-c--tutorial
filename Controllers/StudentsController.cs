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
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetById(long id)
        {
           var student = await _context.Students.FindAsync(id);

          if (student == null)
        {
          return NotFound();
        }

          return student;
        }

        // POST action
        [HttpPost]
        public async Task<ActionResult<Student>> Create(Student student)
        {
           _context.Students.Add(student);
           await _context.SaveChangesAsync();

           return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
        }

        // PUT action
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, Student student)
        {
           if (id != student.Id)
        {
           return BadRequest();
        }

           _context.Entry(student).State = EntityState.Modified;
           await _context.SaveChangesAsync();

           return NoContent();
        }

        // DELETE action
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
        {
            return NotFound();
        }

           _context.Students.Remove(student);
           await _context.SaveChangesAsync();

           return NoContent();
        }
    }
}