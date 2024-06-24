# Schema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] [default to null]
**TenantId** | **string** |  | [optional] [default to null]
**CategoryId** | **string** |  | [optional] [default to null]
**Name** | **string** |  | [optional] [default to null]
**Slug** | **string** |  | [optional] [default to null]
**Status** | **string** |  | [optional] [default to STATUS.ACTIVE]
**System** | **bool** |  | [optional] [default to false]
**Endpoint** | **string** | Endpoint url | [optional] [default to null]
**EndpointName** | **string** | Endpoint name (Group name) | [optional] [default to null]
**Type_** | **string** | Either a Request or Response type (SubGroup name) | [optional] [default to null]
**Method** | **string** | HTTP method for Request types | [optional] [default to null]
**Headers** | **map[string]string** | Headers for Request type, stored in JSON format | [optional] [default to null]
**Query** | **map[string]string** | Query parameters for Request type, stored in JSON format | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

