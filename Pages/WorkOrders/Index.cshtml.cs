using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WorkOrderManagement.Data;
using WorkOrderManagement.Models;

namespace WorkOrderManagement.Pages.WorkOrders;

public class IndexModel : PageModel
{
	private readonly AppDbContext _context;

	public IndexModel(AppDbContext context)
	{
		_context = context;
	}

	public List<WorkOrder> WorkOrders { get; set; } = new();

	public async Task OnGetAsync()
	{
		WorkOrders = await _context.WorkOrders
			.OrderByDescending(w => w.CreatedAt)
			.ToListAsync();
	}
}