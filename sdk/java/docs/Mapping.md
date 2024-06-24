# Mapping

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | [**UUID**](UUID.md) |  |  [optional]
**tenantId** | [**UUID**](UUID.md) |  |  [optional]
**schemaId** | [**UUID**](UUID.md) |  |  [optional]
**fieldId** | [**UUID**](UUID.md) |  |  [optional]
**integrationId** | [**UUID**](UUID.md) |  |  [optional]
**status** | [**StatusEnum**](#StatusEnum) |  |  [optional]
**mapping** | **Object** | Equivalent mapping path/formula for field_id into the integration_id response item schema |  [optional]

<a name="StatusEnum"></a>
## Enum: StatusEnum
Name | Value
---- | -----
ACTIVE | &quot;Active&quot;
INACTIVE | &quot;Inactive&quot;
