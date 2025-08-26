using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Elearning.Infrastructure.Data
{
    public class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            try
            {
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<ApplicationDbContextSeed>();
                logger.LogError(ex.Message);
            }
        }

    }
}
