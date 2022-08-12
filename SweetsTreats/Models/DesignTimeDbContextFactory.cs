using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SweetsTreats.Models
{
  public class SweetsTreatsContextFactory : IDesignTimeDbContextFactory<SweetsTreatsContext>
  {

    SweetsTreatsContext IDesignTimeDbContextFactory<SweetsTreatsContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<SweetsTreatsContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new SweetsTreatsContext(builder.Options);
    }
  }
}