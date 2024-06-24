# ApikeysBody

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tenantId** | **String** |  | 
**name** | **String** |  | 
**status** | [**StatusEnum**](#StatusEnum) |  |  [optional]
**usageLimit** | [**BigDecimal**](BigDecimal.md) |  |  [optional]
**envName** | [**EnvNameEnum**](#EnvNameEnum) |  |  [optional]

<a name="StatusEnum"></a>
## Enum: StatusEnum
Name | Value
---- | -----
ACTIVE | &quot;Active&quot;
INACTIVE | &quot;Inactive&quot;

<a name="EnvNameEnum"></a>
## Enum: EnvNameEnum
Name | Value
---- | -----
PRODUCTION | &quot;Production&quot;
SANDBOX | &quot;Sandbox&quot;
