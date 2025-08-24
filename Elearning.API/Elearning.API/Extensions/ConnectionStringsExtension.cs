using Elearning.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Elearning.API.Extensions
{
    public static class ConnectionStringsExtension
    {
        public static void GetConnectionString(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("No Connection String");

            builder.Services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(connectionString);
            });
        }
    }
}
