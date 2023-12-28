using Microsoft.EntityFrameworkCore;
using WebAppData.Models;
using Microsoft.Extensions.DependencyInjection;
using WebAppData.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CourseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CourseContext") ?? throw new InvalidOperationException("Connection string 'CourseContext' not found.")));
builder.Services.AddDbContext<CategoryContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CategoryContext") ?? throw new InvalidOperationException("Connection string 'CategoryContext' not found.")));
builder.Services.AddDbContext<CollegeContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CollegeConStr")));
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
