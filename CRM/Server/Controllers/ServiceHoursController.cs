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
    public class ServiceHoursController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ServiceHoursController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ServiceHours
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceHours>>> GetServiceHours()
        {
          if (_context.ServiceHours == null)
          {
              return NotFound();
          }
            return await _context.ServiceHours.ToListAsync();
        }

        // GET: api/ServiceHours/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceHours>> GetServiceHours(int id)
        {
          if (_context.ServiceHours == null)
          {
              return NotFound();
          }
            var serviceHours = await _context.ServiceHours.FindAsync(id);

            if (serviceHours == null)
            {
                return NotFound();
            }

            return serviceHours;
        }

        // PUT: api/ServiceHours/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServiceHours(int id, ServiceHours serviceHours)
        {
            if (id != serviceHours.Id)
            {
                return BadRequest();
            }

            _context.Entry(serviceHours).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiceHoursExists(id))
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

        // POST: api/ServiceHours
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ServiceHours>> PostServiceHours(ServiceHours serviceHours)
        {
          if (_context.ServiceHours == null)
          {
              return Problem("Entity set 'ApplicationDbContext.ServiceHours'  is null.");
          }
            _context.ServiceHours.Add(serviceHours);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetServiceHours", new { id = serviceHours.Id }, serviceHours);
        }

        private bool ServiceHoursExists(int id)
        {
            return (_context.ServiceHours?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
