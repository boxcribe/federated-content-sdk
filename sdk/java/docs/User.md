# User

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | [**BigDecimal**](BigDecimal.md) |  |  [optional]
**companyId** | [**UUID**](UUID.md) |  |  [optional]
**type** | [**TypeEnum**](#TypeEnum) |  |  [optional]
**status** | [**StatusEnum**](#StatusEnum) |  |  [optional]
**firstName** | **String** |  | 
**lastName** | **String** |  | 
**email** | **String** |  | 
**emailVerified** | **Boolean** |  |  [optional]
**password** | **String** |  | 
**phoneNumber** | **String** |  |  [optional]
**phonePrefix** | **String** |  |  [optional]
**country** | **String** |  |  [optional]

<a name="TypeEnum"></a>
## Enum: TypeEnum
Name | Value
---- | -----
ADMIN | &quot;admin&quot;
COMPANY | &quot;company&quot;

<a name="StatusEnum"></a>
## Enum: StatusEnum
Name | Value
---- | -----
ACTIVE | &quot;Active&quot;
INACTIVE | &quot;Inactive&quot;
