using Microsoft.EntityFrameworkCore;
using MvcDB.Web.Data;
using MvcDB.Web.Components;
using System.Net.Http;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();

// Configure Razor components and Blazor Server.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddCircuitOptions(options => options.DetailedErrors = true);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Configure Database context with SQLite
string connStr = builder.Configuration.GetConnectionString("DefaultConnection")!;
builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlite(connStr)
);

var app = builder.Build(); // ^^^^^^^ services above ^^^^^^^

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseRouting();
app.UseAntiforgery();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

// Configure Razor components routes for Blazor.

using (var scope = app.Services.CreateScope()) {
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();    
    context.Database.Migrate();
}

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
