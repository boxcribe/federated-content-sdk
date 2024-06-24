# SchemasIdBody

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tenantId** | **String** | The unique identifier of the tenant |  [optional]
**categoryId** | **String** | The unique identifier of the category |  [optional]
**name** | **String** | Name of the schema |  [optional]
**slug** | **String** | Slug for the schema |  [optional]
**status** | [**StatusEnum**](#StatusEnum) | Status of the schema |  [optional]
**system** | **Boolean** | Whether the schema is a system schema |  [optional]
**endpoint** | **String** | Endpoint URL |  [optional]
**endpointName** | **String** | Endpoint name (Group name) |  [optional]
**type** | [**TypeEnum**](#TypeEnum) | Type of the schema (Request or Response) |  [optional]
**method** | [**MethodEnum**](#MethodEnum) | HTTP method for Request types |  [optional]
**headers** | **Map&lt;String, String&gt;** | Headers for Request type, stored in JSON format |  [optional]
**query** | **Map&lt;String, String&gt;** | Query parameters for Request type, stored in JSON format |  [optional]

<a name="StatusEnum"></a>
## Enum: StatusEnum
Name | Value
---- | -----
ACTIVE | &quot;Active&quot;
INACTIVE | &quot;Inactive&quot;

<a name="TypeEnum"></a>
## Enum: TypeEnum
Name | Value
---- | -----
REQUEST | &quot;Request&quot;
RESPONSE | &quot;Response&quot;

<a name="MethodEnum"></a>
## Enum: MethodEnum
Name | Value
---- | -----
GET | &quot;GET&quot;
POST | &quot;POST&quot;
PATCH | &quot;PATCH&quot;
DELETE | &quot;DELETE&quot;
