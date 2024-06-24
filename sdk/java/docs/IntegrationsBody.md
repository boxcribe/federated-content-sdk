# IntegrationsBody

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tenantId** | **String** |  |  [optional]
**categoryId** | **String** |  | 
**name** | **String** |  | 
**type** | **String** |  |  [optional]
**slug** | **String** |  | 
**logo** | **String** |  |  [optional]
**status** | [**StatusEnum**](#StatusEnum) |  |  [optional]
**credentialsProduction** | [**IntegrationsCredentialsProduction**](IntegrationsCredentialsProduction.md) |  |  [optional]
**credentialsSandbox** | [**IntegrationsCredentialsProduction**](IntegrationsCredentialsProduction.md) |  |  [optional]
**envProduction** | **String** |  |  [optional]
**envSandbox** | **String** |  |  [optional]
**settingsProduction** | [**IntegrationsSettingsProduction**](IntegrationsSettingsProduction.md) |  |  [optional]
**settingsSandbox** | [**IntegrationsSettingsProduction**](IntegrationsSettingsProduction.md) |  |  [optional]

<a name="StatusEnum"></a>
## Enum: StatusEnum
Name | Value
---- | -----
ACTIVE | &quot;Active&quot;
INACTIVE | &quot;Inactive&quot;
