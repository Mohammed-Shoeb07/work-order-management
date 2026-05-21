using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkOrderManagement.Data;
using WorkOrderManagement.Models;

namespace WorkOrderManagement.Pages.WorkOrders;

public class CreateModel : PageModel
{
    private readonly AppDbContext _context;

    public CreateModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public WorkOrder WorkOrder { get; set; } = new();

    public void OnGet()
    {
        WorkOrder.Status = "Open";
    }

    public async Task<IActionResult> OnPostAsync()
    {
        WorkOrder.Id = 0;
        WorkOrder.CreatedAt = DateTime.UtcNow;

        _context.WorkOrders.Add(WorkOrder);
        await _context.SaveChangesAsync();

        return RedirectToPage("/WorkOrders/Index");
    }
}