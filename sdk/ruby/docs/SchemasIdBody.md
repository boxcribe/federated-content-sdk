# SwaggerClient::SchemasIdBody

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tenant_id** | **String** | The unique identifier of the tenant | [optional] 
**category_id** | **String** | The unique identifier of the category | [optional] 
**name** | **String** | Name of the schema | [optional] 
**slug** | **String** | Slug for the schema | [optional] 
**status** | **String** | Status of the schema | [optional] 
**system** | **BOOLEAN** | Whether the schema is a system schema | [optional] 
**endpoint** | **String** | Endpoint URL | [optional] 
**endpoint_name** | **String** | Endpoint name (Group name) | [optional] 
**type** | **String** | Type of the schema (Request or Response) | [optional] 
**method** | **String** | HTTP method for Request types | [optional] 
**headers** | **Hash&lt;String, String&gt;** | Headers for Request type, stored in JSON format | [optional] 
**query** | **Hash&lt;String, String&gt;** | Query parameters for Request type, stored in JSON format | [optional] 

