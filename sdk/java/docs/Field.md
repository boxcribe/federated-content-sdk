# Field

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | [**UUID**](UUID.md) |  |  [optional]
**tenantId** | [**UUID**](UUID.md) |  |  [optional]
**schemaId** | [**UUID**](UUID.md) |  |  [optional]
**name** | **String** |  |  [optional]
**slug** | **String** |  |  [optional]
**type** | **String** |  |  [optional]
**description** | **String** |  |  [optional]
**status** | [**StatusEnum**](#StatusEnum) |  |  [optional]
**isSearchable** | **Boolean** |  |  [optional]
**isSortable** | **Boolean** |  |  [optional]
**system** | **Boolean** |  |  [optional]

<a name="StatusEnum"></a>
## Enum: StatusEnum
Name | Value
---- | -----
ACTIVE | &quot;Active&quot;
INACTIVE | &quot;Inactive&quot;
