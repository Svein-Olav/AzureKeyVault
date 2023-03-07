namespace Microsoft.Extensions.DependencyInjection;
public static class ServiceCollection
{
    public static string DEFAULT_KEYVAULT_NAME = "kv-kompetanse";

    public static IServiceCollection AddKeyVaultConfig(
             this IServiceCollection services, IConfiguration config)
        {
            services.Configure<AzureKeyVaultOptions>(config.GetSection("AzureKeyVault"));
            
            return services;
        }
    
    public static IServiceCollection AddKeyVaultServices(this IServiceCollection services)
    {
            services.AddTransient<IKeyVaultSecretsService>( p => new KeyVaultSecretsService(DEFAULT_KEYVAULT_NAME));            
            return services;
    }

    
}
    
