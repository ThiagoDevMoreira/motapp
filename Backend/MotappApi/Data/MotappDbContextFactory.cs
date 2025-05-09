using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MotappApi.Data
{
    public class MotappDbContextFactory : IDesignTimeDbContextFactory<MotappDbContext>
    {
        public MotappDbContext CreateDbContext(string[] args)
        {
            // Busca configuração do appsettings.json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Usa a connection string definida
            var builder = new DbContextOptionsBuilder<MotappDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseNpgsql(connectionString);

            return new MotappDbContext(builder.Options);
        }
    }
}
