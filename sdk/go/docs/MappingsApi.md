# {{classname}}

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MappingsGet**](MappingsApi.md#MappingsGet) | **Get** /mappings | Get mappings
[**MappingsIdDelete**](MappingsApi.md#MappingsIdDelete) | **Delete** /mappings/{id} | Delete mapping
[**MappingsIdGet**](MappingsApi.md#MappingsIdGet) | **Get** /mappings/{id} | Get mapping
[**MappingsIdPatch**](MappingsApi.md#MappingsIdPatch) | **Patch** /mappings/{id} | Update mapping
[**MappingsPost**](MappingsApi.md#MappingsPost) | **Post** /mappings | Create mapping

# **MappingsGet**
> InlineResponse2009 MappingsGet(ctx, optional)
Get mappings

Retrieve a list of mappings with the ability to filter by tenant, category, schema, integration, field, sort, limit or page.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***MappingsApiMappingsGetOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a MappingsApiMappingsGetOpts struct
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**optional.Interface of string**](.md)| Get all mappings for a Tenant ID | 
 **schema** | [**optional.Interface of string**](.md)| Get all mappings for a Schema ID | 
 **field** | [**optional.Interface of string**](.md)| Get all mappings for a Field ID | 
 **integration** | [**optional.Interface of string**](.md)| Get all mappings for an Integration ID | 
 **sort** | **optional.String**| sort by query in the form of mapping:desc/asc (ex. name:asc) | 
 **limit** | **optional.Int32**| Maximum number of mappings | 
 **page** | **optional.Int32**| Page number | [default to 1]

### Return type

[**InlineResponse2009**](inline_response_200_9.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **MappingsIdDelete**
> MappingsIdDelete(ctx, id)
Delete mapping

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **id** | **string**| Mapping id | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **MappingsIdGet**
> Mapping MappingsIdGet(ctx, id)
Get mapping

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **id** | **string**| Mapping id | 

### Return type

[**Mapping**](Mapping.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **MappingsIdPatch**
> Mapping MappingsIdPatch(ctx, body, id)
Update mapping

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**MappingsIdBody**](MappingsIdBody.md)|  | 
  **id** | **string**| Mapping id | 

### Return type

[**Mapping**](Mapping.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **MappingsPost**
> Mapping MappingsPost(ctx, body)
Create mapping

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**MappingsBody**](MappingsBody.md)|  | 

### Return type

[**Mapping**](Mapping.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

