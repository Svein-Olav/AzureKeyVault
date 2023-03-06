namespace AzureKeyVaultService;
public class KeyVaultSecretsService : IKeyVaultSecretsService
{
    public SecretClient _keyVaultClient { get; set; }
    public string   _vaultName { get; set; }

    
    public KeyVaultSecretsService(IOptions<AzureKeyVaultOptions> options)
    {
        _keyVaultClient = new SecretClient(new Uri(options.Value.Vault), new DefaultAzureCredential());        
        _vaultName = options.Value.Vault;
    }
    

    public async Task<string> GetSecret()
    {
        var secret = await _keyVaultClient.GetSecretAsync($"https://{_vaultName}.vault.azure.net/", "MySecret");
        return secret.Value.Value;
       
    }

    public string test()
    {
        return _vaultName;
    }
}
