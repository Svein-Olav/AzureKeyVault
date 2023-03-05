param location string = resourceGroup().location

resource symbolicname 'Microsoft.KeyVault/vaults@2022-07-01' = {
  name: 'kv-kompetanse'
  location:location
  tags: {
    kv: 'kompetanse'    
  }
  properties: {    
    sku: {
      family: 'A'
      name: 'standard'
     }      
    accessPolicies: []
    tenantId : '54475f80-1baa-4ea9-9185-c0de5cc603fe'    
    enabledForDeployment: false
    enabledForDiskEncryption: false
    enabledForTemplateDeployment: true
    enableSoftDelete: false
    softDeleteRetentionInDays: 7
    enableRbacAuthorization: true
    vaultUri: 'https://kompetanse-keyvault-test.vault.azure.net/'
    provisioningState: 'Succeeded'
  }
}
