public abstract class AzureKeyVaultBase
    {
        private static CancellationTokenSource s_cancellationTokenSource;
        private Uri _vaultUri;
        protected CertificateClient _certificateClient;
        protected SecretClient _secretClient;
        protected KeyClient _keyClient;
        protected CancellationToken _cancellationToken;

        private Uri _KeyVaultURI(string vaultName) => new Uri($"https://{vaultName}.vault.azure.net");

        public AzureKeyVaultBase() { }

        public AzureKeyVaultBase(AzureKeyVaultOptions options)
        {
            AzureCredentialFactory azureCredentialFactory = AzureCredentialFactory.GetCredentialFactory(options);
            var credential = azureCredentialFactory.GetCredential();

            OpprettKlienter(credential, options.KEY_VAULT_NAME);
        }

        public AzureKeyVaultBase(string keyVaultName)
        {
            AzureCredentialFactory azureCredentialFactory = AzureCredentialFactory.GetCredentialFactory();
            var credential = azureCredentialFactory.GetCredential();

            OpprettKlienter(credential, keyVaultName);
        }


        private void OpprettKlienter(TokenCredential credential, string keyVaultName)
        {
            s_cancellationTokenSource = new CancellationTokenSource();
            _cancellationToken = s_cancellationTokenSource.Token;

            _vaultUri = _KeyVaultURI(keyVaultName);

            _certificateClient = new CertificateClient(_vaultUri, credential);
            _secretClient = new SecretClient(_vaultUri, credential);
            _keyClient = new KeyClient(_vaultUri, credential);

        }
    }