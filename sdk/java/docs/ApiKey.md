# ApiKey

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | [**UUID**](UUID.md) |  |  [optional]
**tenantId** | [**UUID**](UUID.md) |  |  [optional]
**name** | **String** |  |  [optional]
**status** | [**StatusEnum**](#StatusEnum) |  |  [optional]
**privateKey** | **String** |  |  [optional]
**publicKey** | **String** |  |  [optional]
**usage** | **Object** | Usage log |  [optional]
**usageLimit** | **Integer** | Usage limit |  [optional]

<a name="StatusEnum"></a>
## Enum: StatusEnum
Name | Value
---- | -----
ACTIVE | &quot;Active&quot;
INACTIVE | &quot;Inactive&quot;
