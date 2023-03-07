namespace AzureKeyVaultService;
public interface IKeyVaultSecretsService
{
    public  string GetSecret(string secretName);    
}