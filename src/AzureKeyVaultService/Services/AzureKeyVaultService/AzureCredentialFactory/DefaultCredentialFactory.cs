public class DefaultCredentialFactory : AzureCredentialFactory, IAzureCredentialFactory
    {
        public override TokenCredential GetCredential()
        {
            var defaultAzureCredentialOptions = new DefaultAzureCredentialOptions
            {
                 Diagnostics =
                    {
                        LoggedHeaderNames = { "x-ms-request-id" },
                        LoggedQueryParameters = { "api-version" },
                        IsAccountIdentifierLoggingEnabled = true,
                        IsLoggingContentEnabled = true,
                        IsLoggingEnabled = true,                        
                    }
            };
                            
            defaultAzureCredentialOptions.ExcludeAzureCliCredential = false ;
            defaultAzureCredentialOptions.ExcludeEnvironmentCredential = true;
            defaultAzureCredentialOptions.ExcludeInteractiveBrowserCredential = true;
            defaultAzureCredentialOptions.ExcludeManagedIdentityCredential = true;
            defaultAzureCredentialOptions.ExcludeSharedTokenCacheCredential = true;
            defaultAzureCredentialOptions.ExcludeVisualStudioCodeCredential = true;
            defaultAzureCredentialOptions.ExcludeVisualStudioCredential = true;

            

            var credential = new DefaultAzureCredential(defaultAzureCredentialOptions);

            return credential;

        }
    }