using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;
using WebApi.Model;

namespace WebApi.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        //private IConfiguration _configuration;
        public DbSet<Employee> Employees { get; set; }

        //public ConnectionContext(IConfiguration configuration, DbContextOptions options) : base(options)
        //{
        //    _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WebApi;Trusted_Connection=True;MultipleActiveResultSets=true");
        //{
        //    var typeDatabase = _configuration["TypeDatabase"];
        //    var connectionString = _configuration.GetConnectionString(typeDatabase);

        //    if (typeDatabase == "SqlServer")
        //    {
        //        optionsBuilder.UseSqlServer(connectionString);
        //    }
        //}
    }
}
