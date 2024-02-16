using BookStore2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddIdentity<Appuser, IdentityRole>().AddEntityFrameworkStores<Appdbcontext>();
builder.Services.AddScoped<IBooksRepo, BooksRepo>();

builder.Services.AddSession(options => {
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});


builder.Services.AddDbContext<Appdbcontext>(

    options => { options.UseSqlServer("Server = .\\SQLEXPRESS; Database = TheBookStore; Integrated Security = SSPI; TrustServerCertificate =True; "); }
    );


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseSession();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Register}/{id?}");

app.Run();
