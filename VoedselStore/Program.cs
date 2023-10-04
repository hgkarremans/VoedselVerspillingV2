using Microsoft.EntityFrameworkCore;
using VoedselStore.Domain.Modals;
using VoedselStore.Infrastructure;
using VoedselVerspilling.Domain.Services;
using VoedselVerspilling.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<StoreDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("VoedselStoreConnection")));
builder.Services.AddScoped<IProductRepository, EFProductRepository>();

var app = builder.Build();
//app.MapGet("/", () => "Hello World!");
app.UseStaticFiles();

app.MapDefaultControllerRoute();
SeedData.EnsurePopulated(app);
app.Run();