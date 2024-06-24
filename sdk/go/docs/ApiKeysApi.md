# {{classname}}

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApikeysGet**](ApiKeysApi.md#ApikeysGet) | **Get** /apikeys | Get api keys
[**ApikeysIdDelete**](ApiKeysApi.md#ApikeysIdDelete) | **Delete** /apikeys/{id} | Delete api key
[**ApikeysIdGet**](ApiKeysApi.md#ApikeysIdGet) | **Get** /apikeys/{id} | Get api key
[**ApikeysIdPatch**](ApiKeysApi.md#ApikeysIdPatch) | **Patch** /apikeys/{id} | Update api key
[**ApikeysPost**](ApiKeysApi.md#ApikeysPost) | **Post** /apikeys | Create api key

# **ApikeysGet**
> InlineResponse2002 ApikeysGet(ctx, optional)
Get api keys

Retrieve a list of api keys with the ability to filter by tenant, environment, sort, limit or page.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ApiKeysApiApikeysGetOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a ApiKeysApiApikeysGetOpts struct
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | **optional.String**| Get all schemas for a Tenant ID | 
 **environment** | **optional.String**| Get all schemas for an Environment (Sandbox or Production) | 
 **sort** | **optional.String**| sort by query in the form of field:desc/asc (ex. name:asc) | 
 **limit** | **optional.Int32**| Maximum number of apiKeys | 
 **page** | **optional.Int32**| Page number | [default to 1]

### Return type

[**InlineResponse2002**](inline_response_200_2.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ApikeysIdDelete**
> ApikeysIdDelete(ctx, id)
Delete api key

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **id** | **string**| Api Key ID | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ApikeysIdGet**
> ApiKey ApikeysIdGet(ctx, id)
Get api key

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **id** | **string**| Api Key ID | 

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ApikeysIdPatch**
> ApiKey ApikeysIdPatch(ctx, body, id)
Update api key

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**ApikeysIdBody**](ApikeysIdBody.md)|  | 
  **id** | **string**| Api Key ID | 

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ApikeysPost**
> ApiKey ApikeysPost(ctx, body)
Create api key

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**ApikeysBody**](ApikeysBody.md)|  | 

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

