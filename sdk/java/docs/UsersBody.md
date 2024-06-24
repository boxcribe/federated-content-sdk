# UsersBody

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**companyId** | **String** |  | 
**firstName** | **String** |  | 
**lastName** | **String** |  | 
**email** | **String** | must be unique | 
**password** | **String** | At least one number and one letter | 
**phoneNumber** | **String** |  |  [optional]
**phonePrefix** | **String** |  |  [optional]
**country** | **String** |  |  [optional]
**image** | **String** |  |  [optional]
**status** | [**StatusEnum**](#StatusEnum) |  |  [optional]

<a name="StatusEnum"></a>
## Enum: StatusEnum
Name | Value
---- | -----
ACTIVE | &quot;Active&quot;
INACTIVE | &quot;Inactive&quot;
