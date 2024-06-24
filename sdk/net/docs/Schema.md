# IO.Swagger.Model.Schema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** |  | [optional] 
**TenantId** | **Guid?** |  | [optional] 
**CategoryId** | **Guid?** |  | [optional] 
**Name** | **string** |  | [optional] 
**Slug** | **string** |  | [optional] 
**Status** | **string** |  | [optional] [default to StatusEnum.ActiveEnum]
**System** | **bool?** |  | [optional] [default to false]
**Endpoint** | **string** | Endpoint url | [optional] 
**EndpointName** | **string** | Endpoint name (Group name) | [optional] 
**Type** | **string** | Either a Request or Response type (SubGroup name) | [optional] 
**Method** | **string** | HTTP method for Request types | [optional] 
**Headers** | **Dictionary&lt;string, string&gt;** | Headers for Request type, stored in JSON format | [optional] 
**Query** | **Dictionary&lt;string, string&gt;** | Query parameters for Request type, stored in JSON format | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

