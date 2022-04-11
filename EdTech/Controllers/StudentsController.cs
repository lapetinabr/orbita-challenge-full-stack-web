using EdTech.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdTech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentsDBContext _context;

        public StudentsController(StudentsDBContext context)
        {
            _context = context;
        }
        [EnableCors("Cors")]
        //Get: api/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Students>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }
        [EnableCors("Cors")]
        //Get: api/Students
        [HttpGet("{id}")]
        public async Task<ActionResult<Students>> GetStudents(int id)
        {
            var students = await _context.Students.FindAsync(id);

            if (students == null)
            {
                return NotFound();
            }

            return students;
        }
        [EnableCors("Cors")]
        //Put: api/Students
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudents(int id, Students students)
        {
            students.id_student = id;

            _context.Entry(students).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        [EnableCors("Cors")]
        //Post: api/Students
        [HttpPost]
        public async Task<ActionResult<Students>> PostStudents(Students students)
        {
            _context.Students.Add(students);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudents", new { id = students.id_student }, students);
        }
        [EnableCors("Cors")]
        //Delete: api/Students
        [HttpDelete("{id}")]
        public async Task<ActionResult<Students>> DeleteStudents(int id)
        {
            var students = await _context.Students.FindAsync(id);
            if (students == null)
            {
                return NotFound();
            }

            _context.Students.Remove(students);
            await _context.SaveChangesAsync();

            return students;
        }


        private bool StudentsExists(int id)
        {
            return _context.Students.Any(e => e.id_student == id);
        }






    }

    







}
