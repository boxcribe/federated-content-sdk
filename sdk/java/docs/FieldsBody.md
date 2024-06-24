# FieldsBody

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tenantId** | **String** | The unique identifier of the tenant |  [optional]
**schemaId** | **String** | The unique identifier of the schema | 
**name** | **String** | Name of the field | 
**type** | **String** | Type of the field (e.g., string, number) | 
**slug** | **String** | Slug for the field | 
**description** | **String** | Description of the field |  [optional]
**status** | [**StatusEnum**](#StatusEnum) | Status of the field, indicating if it is active |  [optional]
**isSearchable** | **Boolean** | Flag indicating if the field can be used in search operations |  [optional]
**isSortable** | **Boolean** | Flag indicating if the field can be sorted |  [optional]
**system** | **Boolean** | Indicates if the field is a system field |  [optional]

<a name="StatusEnum"></a>
## Enum: StatusEnum
Name | Value
---- | -----
ACTIVE | &quot;Active&quot;
INACTIVE | &quot;Inactive&quot;
