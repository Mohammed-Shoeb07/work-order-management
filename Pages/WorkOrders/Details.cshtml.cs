using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkOrderManagement.Data;
using WorkOrderManagement.Models;

namespace WorkOrderManagement.Pages.WorkOrders;

public class DetailsModel : PageModel
{
    private readonly AppDbContext _context;

    public DetailsModel(AppDbContext context)
    {
        _context = context;
    }

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
}