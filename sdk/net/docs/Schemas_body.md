# IO.Swagger.Model.SchemasBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **Guid?** | The unique identifier of the tenant | [optional] 
**CategoryId** | **Guid?** | The unique identifier of the category | 
**Name** | **string** | Name of the schema | 
**Slug** | **string** | Slug for the schema | 
**Status** | **string** | Status of the schema | [optional] 
**System** | **bool?** | Whether the schema is a system schema | [optional] 
**Endpoint** | **string** | Endpoint URL | [optional] 
**EndpointName** | **string** | Endpoint name (Group name) | [optional] 
**Type** | **string** | Type of the schema (Request or Response) | 
**Method** | **string** | HTTP method for Request types | [optional] 
**Headers** | **Dictionary&lt;string, string&gt;** | Headers for Request type, stored in JSON format | [optional] 
**Query** | **Dictionary&lt;string, string&gt;** | Query parameters for Request type, stored in JSON format | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

