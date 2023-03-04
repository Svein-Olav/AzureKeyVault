
public static class ServiceCollection
{
    public static IServiceCollection AddSystemInformation(this IServiceCollection services)
    {
            services.AddScoped<IAzureKeyVaultService, AzureKeyVaultService>();
            

            return services;
    }

    
}
    
