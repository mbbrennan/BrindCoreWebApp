using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrindCoreWebApp.Models
{
    public class WebAppContext :DbContext
    {

        public WebAppContext(DbContextOptions<WebAppContext> options) : base(options)
        {
        }

        public WebAppContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Database_Connection"));
        }
        public Microsoft.EntityFrameworkCore.DbSet<Models.Team> Teams { get; set; }
    }
}
