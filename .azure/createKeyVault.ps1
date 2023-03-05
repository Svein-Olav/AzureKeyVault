<#
.DESCRIPTION
Installerer komponent for styre tilganger
#>

# Navn må resource groupe
$resourceGroup = 'RG-Kompetanse-Dev'

az deployment group create --name DeploymentKeyVault --resource-group $resourceGroup `
    --template-file KeyVault.bicep 