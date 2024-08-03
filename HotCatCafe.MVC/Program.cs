using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.BaseStorageService;
using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.EmailService;
using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.EntityServices;
using HotCatCafe.BLL.Repositories.Concretes.BaseService;
using HotCatCafe.BLL.Repositories.Concretes.EmailServices;
using HotCatCafe.BLL.Repositories.Concretes.EntityServices;
using HotCatCafe.DAL.Context;
using HotCatCafe.Model.Entities;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
//var builderc = Host.CreateDefaultBuilder(args).ConfigureAppConfiguration((context, config) =>
//{
//    var env = context.HostingEnvironment;
//    config.SetBasePath(Directory.GetCurrentDirectory())
//          .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

//}).ConfigureServices((context, services) =>
//{
//    // Configuration nesnesini alýn
//    var configuration = context.Configuration;

//    // DbContext'i ekleyin
//    services.AddDbContext<HotCatCafeContext>(options =>
//        options.UseSqlServer(configuration.GetConnectionString("HotCatCafeTestConnection")));

//    // Diðer servisleri ekleyin
//    services.AddScoped<IEmailService, EmailService>();

//    // MVC veya Razor Pages'i ekleyin
//    services.AddControllersWithViews(); // Veya services.AddRazorPages();

//});

// Add services to the container.
builder.Services.AddControllersWithViews();
//AddDbContext
//Context
builder.Services.AddDbContext<HotCatCafeContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("HotCatCafeTestConnection")));// // MigrationsAssembly ayarý


//builder.Services.AddDbContext<HotCatCafeContext>(options=>options.UseSqlServer/*("Server=LAPTOP-7RVI861P\\SQLEXPRESS;Database=HotCatCafeDb;Trusted_Connection=True;TrustServerCertificate=True;"));*/
//******************configure SmtpSettings
builder.Services.Configure<SmtpSettings>(builder.Configuration.GetSection("SmtpSettings"));


//register EmailService
//builder.Services.AddTransient<IEmailService, EmailService>();

////Register existing services
//builder.Services.AddScoped<typeof(IStorageService<>), typeof(StorageService<>));

////IStorageService
builder.Services.AddScoped(typeof(IStorageService<>), typeof(StorageService<>));

//Entity services
builder.Services.AddScoped<ICategoryRepository, CategoryService>();

builder.Services.AddScoped<IProductRepository, ProductService>();
builder.Services.AddScoped<IEmailService, EmailService>();



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

//app.UseAuthorization();

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
