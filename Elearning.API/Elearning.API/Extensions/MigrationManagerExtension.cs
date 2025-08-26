using Elearning.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Elearning.API.Extensions
{
    public static class MigrationManagerExtension
    {
        public static async Task ApplyMigrationsAsync(this IHost app)
        {
            using var scope = app.Services.CreateScope();
            var services = scope.ServiceProvider;
            var loggerFactory = services.GetRequiredService<ILoggerFactory>();
            try
            {
                var context = services.GetRequiredService<ApplicationDbContext>();
                await context.Database.MigrateAsync(); // make migration auto
                await ApplicationDbContextSeed.SeedAsync(context, loggerFactory);
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<Program>();
                logger.LogError(ex, "An error occurred during migration !!");
            }
        }
    }
}
