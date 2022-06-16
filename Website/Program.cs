using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Web.Logic.Categories;
using Web.Logic.Countries;
using Web.Logic.NewsNamespace;
using Web.Logic.Commentaries;
using Web.Logic.Admins;
using Website.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AppDbContext>();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICategoryManager, CategoryManager>(); // Зависимость. CategoryManager связан
                                                                 // с ICategoryManager интерфейсом
builder.Services.AddScoped<ICountryManager, CountryManager>();
builder.Services.AddScoped<INewsManager, NewsManager>();
builder.Services.AddScoped<ICommentaryManager, CommentaryManager>();
builder.Services.AddScoped<IAdminManager, AdminManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
