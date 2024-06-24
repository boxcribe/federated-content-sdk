# Log

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | [**UUID**](UUID.md) |  |  [optional]
**url** | **String** |  |  [optional]
**headers** | **Object** |  |  [optional]
**request** | **Object** |  |  [optional]
**response** | **Object** |  |  [optional]
**date** | [**OffsetDateTime**](OffsetDateTime.md) |  |  [optional]
**integrationId** | [**UUID**](UUID.md) |  |  [optional]
**tenantId** | [**UUID**](UUID.md) |  |  [optional]
**method** | [**MethodEnum**](#MethodEnum) |  |  [optional]
**endpointShortname** | **String** |  |  [optional]
**responseTime** | **Integer** |  |  [optional]
**responseCode** | **Integer** |  |  [optional]

<a name="MethodEnum"></a>
## Enum: MethodEnum
Name | Value
---- | -----
GET | &quot;GET&quot;
POST | &quot;POST&quot;
PATCH | &quot;PATCH&quot;
DELETE | &quot;DELETE&quot;
