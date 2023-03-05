 Param(
    [Parameter(Mandatory=$true)]
    [ValidateNotNullOrEmpty()]
    [string]$subscriptionID
)

 # Logg på azure med riktig bruker
 az login

 # Setter riktig subscription
 az account set --subscription $subscriptionID

 # Vis subscription informasjon
 az account show

 #Resource group må eksistere
 az group create -l westeurope -n RG-Kompetanse-Dev