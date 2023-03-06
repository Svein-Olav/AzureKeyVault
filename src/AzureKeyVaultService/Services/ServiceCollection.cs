
public static class ServiceCollection
{
    public static IServiceCollection AddSystemInformation(this IServiceCollection services)
    {
            services.AddScoped<IKeyVaultSecretsService, KeyVaultSecretsService>();
            

            return services;
    }

    
}
    
