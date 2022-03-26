using DemoApartment.DBOperations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ***** UseSqlServer <---> ManagementDbContext ***** //
builder.Services.AddDbContext<ManagementDbContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ***** DataGenerator ***** //
DataGenerator.Seed(app);

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();