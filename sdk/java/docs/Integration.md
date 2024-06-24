# Integration

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | [**UUID**](UUID.md) |  |  [optional]
**tenantId** | [**UUID**](UUID.md) |  |  [optional]
**categoryId** | [**UUID**](UUID.md) |  |  [optional]
**name** | **String** |  |  [optional]
**slug** | **String** |  |  [optional]
**logo** | **String** |  |  [optional]
**status** | [**StatusEnum**](#StatusEnum) |  |  [optional]
**credentialsProduction** | **Object** | Production Credentials |  [optional]
**credentialsSandbox** | **Object** | Sandbox Credentials |  [optional]
**envProduction** | [**EnvProductionEnum**](#EnvProductionEnum) |  |  [optional]
**envSandbox** | [**EnvSandboxEnum**](#EnvSandboxEnum) |  |  [optional]
**settingsProduction** | **Object** | Production Settings |  [optional]
**settingsSandbox** | **Object** | Sandbox Settings |  [optional]

<a name="StatusEnum"></a>
## Enum: StatusEnum
Name | Value
---- | -----
ACTIVE | &quot;Active&quot;
INACTIVE | &quot;Inactive&quot;

<a name="EnvProductionEnum"></a>
## Enum: EnvProductionEnum
Name | Value
---- | -----
PRODUCTION | &quot;Production&quot;
SANDBOX | &quot;Sandbox&quot;

<a name="EnvSandboxEnum"></a>
## Enum: EnvSandboxEnum
Name | Value
---- | -----
PRODUCTION | &quot;Production&quot;
SANDBOX | &quot;Sandbox&quot;
