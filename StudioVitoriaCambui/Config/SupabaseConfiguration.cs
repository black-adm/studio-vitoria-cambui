using Supabase;

namespace StudioVitoriaCambui.Config
{
    public static class SupabaseConfiguration
    {
        public static void ConfigureSupabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<Supabase.Client>(_ =>
                new Supabase.Client(
                    configuration["SupabaseUrl"],
                    configuration["SupabaseKey"],
                    new SupabaseOptions
                    {
                        AutoRefreshToken = true,
                        AutoConnectRealtime = true
                    })
            );
        }
    }
}