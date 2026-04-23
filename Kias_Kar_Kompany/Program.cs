using Kias_Kar_Kompany.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Kias_Kar_KompanyContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Kias_Kar_KompanyContext")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// FIX: enable static files (CSS, JS, images)
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// FIX: remove .WithStaticAssets()
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();