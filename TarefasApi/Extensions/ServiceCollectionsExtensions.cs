using System.Data.SqlClient;
using static TarefasApi.Data.TarefaContext;

namespace TarefasApi.Extensions
{
    public static class ServiceCollectionsExtensions
    {
        public static WebApplicationBuilder AddPersistence(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddScoped<GetConnection>(sp =>
            async () =>
            { 
                var conncetion = new SqlConnection(connectionString);
                await conncetion.OpenAsync();
                return conncetion;
            });
            return builder;
        }
    }
}
