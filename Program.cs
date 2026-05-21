using Microsoft.EntityFrameworkCore;
using System.Threading;
using WorkOrderManagement.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Retry database connection because SQL Server container
// may take time to fully start inside Docker.
var retries = 10;
var delay = TimeSpan.FromSeconds(10);

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    for (int i = 0; i < retries; i++)
    {
        try
        {
            context.Database.Migrate();
            break;
        }
        catch
        {
            if (i == retries - 1)
                throw;

            Thread.Sleep(delay);
        }
    }
}

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.MapRazorPages();

app.Run();