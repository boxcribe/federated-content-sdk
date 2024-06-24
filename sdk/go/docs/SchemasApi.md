# {{classname}}

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SchemasGet**](SchemasApi.md#SchemasGet) | **Get** /schemas | Get schemas
[**SchemasGroupedByEndpointGet**](SchemasApi.md#SchemasGroupedByEndpointGet) | **Get** /schemas/groupedByEndpoint | Get schemas grouped by endpoint
[**SchemasIdDelete**](SchemasApi.md#SchemasIdDelete) | **Delete** /schemas/{id} | Delete schema
[**SchemasIdGet**](SchemasApi.md#SchemasIdGet) | **Get** /schemas/{id} | Get schema
[**SchemasIdPatch**](SchemasApi.md#SchemasIdPatch) | **Patch** /schemas/{id} | Update schema
[**SchemasPost**](SchemasApi.md#SchemasPost) | **Post** /schemas | Create schema

# **SchemasGet**
> InlineResponse20010 SchemasGet(ctx, optional)
Get schemas

Retrieve a list of schemas with the ability to filter by tenant, category, sort, limit, or page.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SchemasApiSchemasGetOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a SchemasApiSchemasGetOpts struct
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**optional.Interface of string**](.md)| Get all schemas for a Tenant ID | 
 **category** | [**optional.Interface of string**](.md)| Get all schemas for a Category ID | 
 **sort** | **optional.String**| Sort by query in the form of field:desc/asc (ex. name:asc) | 
 **limit** | **optional.Int32**| Maximum number of schemas | 
 **page** | **optional.Int32**| Page number | [default to 1]

### Return type

[**InlineResponse20010**](inline_response_200_10.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **SchemasGroupedByEndpointGet**
> InlineResponse20011 SchemasGroupedByEndpointGet(ctx, optional)
Get schemas grouped by endpoint

Retrieve a list of schemas grouped by their endpoint with the ability to filter by tenant, category, sort, limit, or page.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SchemasApiSchemasGroupedByEndpointGetOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a SchemasApiSchemasGroupedByEndpointGetOpts struct
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**optional.Interface of string**](.md)| Get all schemas for a Tenant ID | 
 **category** | [**optional.Interface of string**](.md)| Get all schemas for a Category ID | 
 **sort** | **optional.String**| Sort by query in the form of field:desc/asc (ex. endpoint:asc) | 
 **limit** | **optional.Int32**| Maximum number of schemas | 
 **page** | **optional.Int32**| Page number | [default to 1]

### Return type

[**InlineResponse20011**](inline_response_200_11.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **SchemasIdDelete**
> SchemasIdDelete(ctx, id)
Delete schema

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **id** | **string**| Schema id | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **SchemasIdGet**
> Schema SchemasIdGet(ctx, id)
Get schema

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **id** | **string**| Schema id | 

### Return type

[**Schema**](Schema.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **SchemasIdPatch**
> Schema SchemasIdPatch(ctx, body, id)
Update schema

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**SchemasIdBody**](SchemasIdBody.md)|  | 
  **id** | **string**| Schema id | 

### Return type

[**Schema**](Schema.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **SchemasPost**
> Schema SchemasPost(ctx, body)
Create schema

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**SchemasBody**](SchemasBody.md)|  | 

### Return type

[**Schema**](Schema.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

