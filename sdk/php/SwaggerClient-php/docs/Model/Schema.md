# Schema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **string** |  | [optional] 
**tenant_id** | **string** |  | [optional] 
**category_id** | **string** |  | [optional] 
**name** | **string** |  | [optional] 
**slug** | **string** |  | [optional] 
**status** | **string** |  | [optional] [default to 'Active']
**system** | **bool** |  | [optional] [default to false]
**endpoint** | **string** | Endpoint url | [optional] 
**endpoint_name** | **string** | Endpoint name (Group name) | [optional] 
**type** | **string** | Either a Request or Response type (SubGroup name) | [optional] 
**method** | **string** | HTTP method for Request types | [optional] 
**headers** | **map[string,string]** | Headers for Request type, stored in JSON format | [optional] 
**query** | **map[string,string]** | Query parameters for Request type, stored in JSON format | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

