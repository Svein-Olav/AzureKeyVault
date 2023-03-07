namespace AzureKeyVaultService;
public class KeyVaultSecretsService : AzureKeyVaultBase, IKeyVaultSecretsService
{
    
     public KeyVaultSecretsService (AzureKeyVaultOptions options) : base(options)
     {
     }

    public KeyVaultSecretsService(string keyVaultName) : base(keyVaultName)
    {
    }

    public string GetSecret(string secretName)
    {
        string returnVerdi;

        try
        {
            KeyVaultSecret secret = _secretClient.GetSecret(secretName, cancellationToken: _cancellationToken);
            returnVerdi = secret.Value ?? string.Empty;
        } catch(Exception ex)
        {
            returnVerdi =ex.Message;
        }
        return returnVerdi;
    }

}
