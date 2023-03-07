

public abstract class AzureCredentialFactory : IAzureCredentialFactory
    {
        public abstract TokenCredential GetCredential();

        public static AzureCredentialFactory GetCredentialFactory(AzureKeyVaultOptions options)
        {
            return new ClientSecretCrendentialFactory(options);
        }

        public static AzureCredentialFactory GetCredentialFactory()
        {
            return new DefaultCredentialFactory();
        }

    }
