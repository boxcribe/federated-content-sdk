# SwaggerClient::Schema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **String** |  | [optional] 
**tenant_id** | **String** |  | [optional] 
**category_id** | **String** |  | [optional] 
**name** | **String** |  | [optional] 
**slug** | **String** |  | [optional] 
**status** | **String** |  | [optional] [default to &#x27;Active&#x27;]
**system** | **BOOLEAN** |  | [optional] [default to false]
**endpoint** | **String** | Endpoint url | [optional] 
**endpoint_name** | **String** | Endpoint name (Group name) | [optional] 
**type** | **String** | Either a Request or Response type (SubGroup name) | [optional] 
**method** | **String** | HTTP method for Request types | [optional] 
**headers** | **Hash&lt;String, String&gt;** | Headers for Request type, stored in JSON format | [optional] 
**query** | **Hash&lt;String, String&gt;** | Query parameters for Request type, stored in JSON format | [optional] 

