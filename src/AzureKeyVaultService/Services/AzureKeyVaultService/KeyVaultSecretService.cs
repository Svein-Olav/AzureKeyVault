namespace AzureKeyVaultService;
public class KeyVaultSecretsService : IKeyVaultSecretsService
{
    private readonly IKeyVaultClient _keyVaultClient;
    private readonly string _secretName;
    private readonly string _secretVersion;
    private readonly string _vaultName;

    public KeyVaultSecretsService(IKeyVaultClient keyVaultClient, string secretName, string secretVersion, string vaultName)
    {
        _keyVaultClient = keyVaultClient;
        _secretName = secretName;
        _secretVersion = secretVersion;
        _vaultName = vaultName;
    }

    public async Task<string> GetSecret()
    {
        var secret = await _keyVaultClient.GetSecretAsync($"https://{_vaultName}.vault.azure.net/secrets/{_secretName}/{_secretVersion}");
        return secret.Value;
    }
}
