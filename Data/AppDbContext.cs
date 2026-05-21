using Microsoft.EntityFrameworkCore;
using WorkOrderManagement.Models;

namespace WorkOrderManagement.Data;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options)
		: base(options)
	{
	}

	public DbSet<WorkOrder> WorkOrders { get; set; }
}