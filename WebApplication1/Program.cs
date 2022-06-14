using Microsoft.EntityFrameworkCore;
using Web.Logic.Categories;
using Web.Logic.Countries;
using Web.Logic.NewsNamespace;
using Web.Logic.Commentaries;
using Web.Storage.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICategoryManager, CategoryManager>(); // Зависимость. CategoryManager связан
                                                                 // с ICategoryManager интерфейсом
builder.Services.AddScoped<ICountryManager, CountryManager>();
builder.Services.AddScoped<INewsManager, NewsManager>();
builder.Services.AddScoped<ICommentaryManager, CommentaryManager>();
// Add Database Context
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(param => param.UseSqlServer(connectionString));
builder.Services.AddRazorPages();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
