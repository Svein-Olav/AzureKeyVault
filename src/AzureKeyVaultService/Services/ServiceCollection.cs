namespace Microsoft.Extensions.DependencyInjection;
public static class ServiceCollection
{
    public static IServiceCollection AddKeyVaultConfig(
             this IServiceCollection services, IConfiguration config)
        {
            services.Configure<AzureKeyVaultOptions>(config.GetSection("AzureKeyVault"));
            
            return services;
        }
    
    public static IServiceCollection AddKeyVaultServices(this IServiceCollection services)
    {
            services.AddScoped<IKeyVaultSecretsService, KeyVaultSecretsService>();            
            return services;
    }

    
}
    
