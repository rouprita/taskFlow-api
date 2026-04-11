using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskflowApi.Data;
using TaskflowApi.Models;

namespace TaskflowApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TasksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/tasks
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tasks = await _context.Tasks.ToListAsync();
            return Ok(tasks);
        }

        // POST: api/tasks
        [HttpPost]
        public async Task<IActionResult> Create(TaskItem task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAll), new { id = task.Id }, task);
        }

        // PUT: api/tasks/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, TaskItem updated)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null) return NotFound();
            task.Title = updated.Title;
            task.Status = updated.Status;
            await _context.SaveChangesAsync();
            return Ok(task);
        }

        // DELETE: api/tasks/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null) return NotFound();
            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}