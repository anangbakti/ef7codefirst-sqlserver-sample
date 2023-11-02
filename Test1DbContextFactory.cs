using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Test1DbContextFactory : IDesignTimeDbContextFactory<Test1DbContext>
    {
        static string? connectionString = null;


        static Test1DbContextFactory() {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            connectionString = config["ConnectionStrings:Test1Connection"];
            Console.WriteLine("ConnectionString:" + connectionString);
        }        

        public Test1DbContext CreateDbContext(string[] args) {
            var optionsBuilder = new DbContextOptionsBuilder<Test1DbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            return new Test1DbContext(optionsBuilder.Options);  
        }
    }
}
