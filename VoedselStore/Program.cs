using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using VoedselStore.Domain.Services;
using VoedselStore.Infrastructure;
using VoedselStore.Infrastructure.ContextClasses;
using VoedselVerspilling.Domain.Services;
using VoedselVerspilling.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<StoreDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("VoedselStoreConnection")));
builder.Services.AddScoped<IProductRepository, EFProductRepository>();
builder.Services.AddScoped<ICanteenRepository, EFCanteenRepository>();
builder.Services.AddScoped<IEmployeeRepository, EFEmployeeRepository>();
builder.Services.AddScoped<IMealBoxRepository, EFMealBoxRepository>();
builder.Services.AddScoped<IStudentRepository, EFStudentRepository>();

builder.Services.AddDbContext<AppIdentityDbContext>(options =>
 options.UseSqlServer(
 builder.Configuration["ConnectionStrings:IdentityConnection"]));
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
 .AddEntityFrameworkStores<AppIdentityDbContext>();

var app = builder.Build();

app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();


SeedData.EnsurePopulated(app);
IdentitySeedData.EnsurePopulated(app);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();