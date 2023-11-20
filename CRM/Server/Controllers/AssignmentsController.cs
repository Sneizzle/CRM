using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRM.Server.Data;
using CRM.Shared.Model;

namespace CRM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AssignmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Assignments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Assignment>>> GetAssignments()
        {
          if (_context.Assignments == null)
          {
              return NotFound();
          }
            return await _context.Assignments.ToListAsync();
        }

        // GET: api/Assignments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Assignment>> GetAssignment(int id)
        {
          if (_context.Assignments == null)
          {
              return NotFound();
          }
            var assignment = await _context.Assignments.FindAsync(id);

            if (assignment == null)
            {
                return NotFound();
            }

            return assignment;
        }

        // PUT: api/Assignments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssignment(int id, Assignment assignment)
        {
     
            if (id != assignment.Id)
            {
                return BadRequest();
            }

            _context.Entry(assignment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssignmentExists(id))
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

        // POST: api/Assignments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Assignment>> PostAssignment(Assignment assignment)
        {
            assignment.DateCreated = DateTime.Now;
          if (_context.Assignments == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Assignments'  is null.");
          }
            _context.Assignments.Add(assignment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAssignment", new { id = assignment.Id }, assignment);
        }

        private bool AssignmentExists(int id)
        {
            return (_context.Assignments?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
