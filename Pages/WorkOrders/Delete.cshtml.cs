using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkOrderManagement.Data;
using WorkOrderManagement.Models;

namespace WorkOrderManagement.Pages.WorkOrders;

public class DeleteModel : PageModel
{
    private readonly AppDbContext _context;

    public DeleteModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public WorkOrder WorkOrder { get; set; } = new();

    public async Task<IActionResult> OnGetAsync(int id)
    {
        var workOrder = await _context.WorkOrders.FindAsync(id);

        if (workOrder == null)
        {
            return NotFound();
        }

        WorkOrder = workOrder;
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        var workOrder = await _context.WorkOrders.FindAsync(WorkOrder.Id);

        if (workOrder != null)
        {
            _context.WorkOrders.Remove(workOrder);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("/WorkOrders/Index");
    }
}