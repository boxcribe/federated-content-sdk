# Schema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **str** |  | [optional] 
**tenant_id** | **str** |  | [optional] 
**category_id** | **str** |  | [optional] 
**name** | **str** |  | [optional] 
**slug** | **str** |  | [optional] 
**status** | **str** |  | [optional] [default to 'Active']
**system** | **bool** |  | [optional] [default to False]
**endpoint** | **str** | Endpoint url | [optional] 
**endpoint_name** | **str** | Endpoint name (Group name) | [optional] 
**type** | **str** | Either a Request or Response type (SubGroup name) | [optional] 
**method** | **str** | HTTP method for Request types | [optional] 
**headers** | **dict(str, str)** | Headers for Request type, stored in JSON format | [optional] 
**query** | **dict(str, str)** | Query parameters for Request type, stored in JSON format | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

