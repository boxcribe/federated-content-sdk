# {{classname}}

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FieldsGet**](FieldsApi.md#FieldsGet) | **Get** /fields | Get fields
[**FieldsIdDelete**](FieldsApi.md#FieldsIdDelete) | **Delete** /fields/{id} | Delete field
[**FieldsIdGet**](FieldsApi.md#FieldsIdGet) | **Get** /fields/{id} | Get field
[**FieldsIdPatch**](FieldsApi.md#FieldsIdPatch) | **Patch** /fields/{id} | Update field
[**FieldsPost**](FieldsApi.md#FieldsPost) | **Post** /fields | Create field

# **FieldsGet**
> InlineResponse2006 FieldsGet(ctx, optional)
Get fields

Retrieve a list of fields with the ability to filter by tenant, schema, sort, limit or page.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***FieldsApiFieldsGetOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a FieldsApiFieldsGetOpts struct
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**optional.Interface of string**](.md)| Get all fields for a Tenant ID | 
 **schema** | [**optional.Interface of string**](.md)| Get all fields for a Schema ID | 
 **sort** | **optional.String**| sort by query in the form of field:desc/asc (ex. name:asc) | 
 **limit** | **optional.Int32**| Maximum number of fields | 
 **page** | **optional.Int32**| Page number | [default to 1]

### Return type

[**InlineResponse2006**](inline_response_200_6.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **FieldsIdDelete**
> FieldsIdDelete(ctx, id)
Delete field

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **id** | **string**| Field id | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **FieldsIdGet**
> Field FieldsIdGet(ctx, id)
Get field

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **id** | **string**| Field id | 

### Return type

[**Field**](Field.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **FieldsIdPatch**
> Field FieldsIdPatch(ctx, body, id)
Update field

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**FieldsIdBody**](FieldsIdBody.md)|  | 
  **id** | **string**| Field id | 

### Return type

[**Field**](Field.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **FieldsPost**
> Field FieldsPost(ctx, body)
Create field

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**FieldsBody**](FieldsBody.md)|  | 

### Return type

[**Field**](Field.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

