# UsersUserIdBody

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**firstName** | **String** |  |  [optional]
**lastName** | **String** |  |  [optional]
**email** | **String** | must be unique |  [optional]
**password** | **String** | At least one number and one letter |  [optional]
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
