public class ClientSecretCrendentialFactory : AzureCredentialFactory, IAzureCredentialFactory
    {
        AzureKeyVaultOptions _options;

        public ClientSecretCrendentialFactory(AzureKeyVaultOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (string.IsNullOrEmpty(options.AZURE_CLIENT_SECRET)) throw new ArgumentException("Mangler AZURE_CLIENT_SECRET");
            if (string.IsNullOrEmpty(options.AZURE_CLIENT_ID)) throw new ArgumentException("Mangler AZURE_CLIENT_ID");
            if (string.IsNullOrEmpty(options.AZURE_TENANT_ID)) throw new ArgumentException("Mangler AZURE_TENANT_ID");
            if (string.IsNullOrEmpty(options.KEY_VAULT_NAME)) throw new ArgumentException("Mangler KEY_VAULT_NAME");

            _options = options;
        }
        public override TokenCredential GetCredential()
        {
            var credential = new ClientSecretCredential(_options.AZURE_TENANT_ID, _options.AZURE_CLIENT_ID, _options.AZURE_CLIENT_SECRET);
            return credential;
        }
    }