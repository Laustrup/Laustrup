using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using App_Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BandwichContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("BandwichContext")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<BandwichContext>();builder.Services.AddDbContext<BandwichContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("BandwichContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "Bandwich/{controller=Home}/{action=Index}/{id?}"
);

app.Run();
