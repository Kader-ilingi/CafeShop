
using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract;
using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.BaseStorageService;
using HotCatCafe.BLL.Repositories.Concretes.BaseService;
using HotCatCafe.BLL.Repositories.Concretes.EntityServices;
using HotCatCafe.DAL.Context;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//AddDbContext
builder.Services.AddDbContext<HotCatCafeContext>(options=>options.UseSqlServer("Server=LAPTOP-7RVI861P\\SQLEXPRESS;Database=HtCafeDb;Trusted_Connection=True;TrustServerCertificate=True;"));
//Dependecy injection
//IStorageService
builder.Services.AddScoped(typeof(IStorageService<>), typeof(StorageService<>));

//Entity services
builder.Services.AddScoped<ICategoryRepository, CategoryService>();

builder.Services.AddScoped<IProductRepository, ProductService>();




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

//Areas endpointi buraya alýndý
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
    endpoints.MapControllerRoute(
     name: "default",
     pattern: "{controller=Home}/{action=Index}/{id?}"
   );

    
});



//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
