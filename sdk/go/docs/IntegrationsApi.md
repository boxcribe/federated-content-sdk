# {{classname}}

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IntegrationsGet**](IntegrationsApi.md#IntegrationsGet) | **Get** /integrations | Get integrations
[**IntegrationsIdDelete**](IntegrationsApi.md#IntegrationsIdDelete) | **Delete** /integrations/{id} | Delete integration
[**IntegrationsIdGet**](IntegrationsApi.md#IntegrationsIdGet) | **Get** /integrations/{id} | Get integration
[**IntegrationsIdPatch**](IntegrationsApi.md#IntegrationsIdPatch) | **Patch** /integrations/{id} | Update integration
[**IntegrationsPost**](IntegrationsApi.md#IntegrationsPost) | **Post** /integrations | Create integration

# **IntegrationsGet**
> InlineResponse2007 IntegrationsGet(ctx, optional)
Get integrations

Retrieve a list of integrations with the ability to filter by tenant, category, sort, limit or page.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***IntegrationsApiIntegrationsGetOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a IntegrationsApiIntegrationsGetOpts struct
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**optional.Interface of string**](.md)| Get all integrations for a Tenant ID | 
 **category** | [**optional.Interface of string**](.md)| Get all integrations for a Category ID | 
 **sort** | **optional.String**| sort by query in the form of field:desc/asc (ex. name:asc) | 
 **limit** | **optional.Int32**| Maximum number of integrations | 
 **page** | **optional.Int32**| Page number | [default to 1]

### Return type

[**InlineResponse2007**](inline_response_200_7.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **IntegrationsIdDelete**
> IntegrationsIdDelete(ctx, id)
Delete integration

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **id** | **string**| Integration id | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **IntegrationsIdGet**
> Integration IntegrationsIdGet(ctx, id)
Get integration

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **id** | **string**| Integration id | 

### Return type

[**Integration**](Integration.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **IntegrationsIdPatch**
> Integration IntegrationsIdPatch(ctx, body, id)
Update integration

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**IntegrationsIdBody**](IntegrationsIdBody.md)|  | 
  **id** | **string**| Integration id | 

### Return type

[**Integration**](Integration.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **IntegrationsPost**
> Integration IntegrationsPost(ctx, body)
Create integration

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**IntegrationsBody**](IntegrationsBody.md)|  | 

### Return type

[**Integration**](Integration.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

