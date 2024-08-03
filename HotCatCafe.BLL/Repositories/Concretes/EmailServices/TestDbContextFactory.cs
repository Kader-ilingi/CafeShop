using HotCatCafe.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HotCatCafe.BLL.Repositories.Concretes.EmailServices
{
    public static class TestDbContextFactory
    {
        public static HotCatCafeContext CreateDbContext()
        {
            var configuration= new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            var optionBuilder = new DbContextOptionsBuilder<HotCatCafeContext>();
            optionBuilder.UseSqlServer(configuration.GetConnectionString("HotCatCafeTestConnection"));
            return new HotCatCafeContext(optionBuilder.Options);
        }
        
    }
}
