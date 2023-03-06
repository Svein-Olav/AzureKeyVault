namespace AzureKeyVaultService;
public interface IKeyVaultSecretsService
{
    public  Task<string> GetSecret();
    public string test();
}