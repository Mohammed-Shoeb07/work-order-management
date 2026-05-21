using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkOrderManagement.Data;
using WorkOrderManagement.Models;

namespace WorkOrderManagement.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WorkOrdersController : ControllerBase
{
    private readonly AppDbContext _context;

    public WorkOrdersController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<WorkOrder>>> GetAll()
    {
        return await _context.WorkOrders
            .OrderByDescending(w => w.CreatedAt)
            .ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<WorkOrder>> GetById(int id)
    {
        var workOrder = await _context.WorkOrders.FindAsync(id);

        if (workOrder == null)
        {
            return NotFound();
        }

        return workOrder;
    }

    [HttpPost]
    public async Task<ActionResult<WorkOrder>> Create(WorkOrder workOrder)
    {
        workOrder.Id = 0;
        workOrder.CreatedAt = DateTime.UtcNow;

        _context.WorkOrders.Add(workOrder);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = workOrder.Id }, workOrder);
    }

    [HttpPut("{id}/status")]
    public async Task<IActionResult> UpdateStatus(int id, [FromBody] string status)
    {
        var workOrder = await _context.WorkOrders.FindAsync(id);

        if (workOrder == null)
        {
            return NotFound();
        }

        workOrder.Status = status;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var workOrder = await _context.WorkOrders.FindAsync(id);

        if (workOrder == null)
        {
            return NotFound();
        }

        _context.WorkOrders.Remove(workOrder);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}