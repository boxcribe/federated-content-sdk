# FlightBookingPassengerSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**passenger_id** | **string** | Unique identifier for the passenger. | [optional] 
**type** | **string** | Type of passenger (adult, child, infant, infant with seat). | [optional] 
**title** | **string** | Title of the passenger (e.g., Mr., Mrs.). | [optional] 
**first_name** | **string** | First name of the passenger. | [optional] 
**last_name** | **string** | Last name of the passenger. | [optional] 
**gender** | **string** | Gender of the passenger. | [optional] 
**date_of_birth** | [**\DateTime**](\DateTime.md) | Date of birth of the passenger. | [optional] 
**country** | **string** | Country of the passenger. | [optional] 
**phone_prefix** | **string** | International dialing prefix for phone number. | [optional] 
**phone_number** | **string** | Phone number of the passenger. | [optional] 
**passport_type** | **string** | Type of passport. | [optional] 
**passport_number** | **string** | Passport number of the passenger. | [optional] 
**passport_expiration_date** | [**\DateTime**](\DateTime.md) | Expiration date of the passport. | [optional] 
**passport_country** | **string** | Country of issue of the passport. | [optional] 
**loyalty_airline** | **string** | Airline with which the passenger has loyalty membership. | [optional] 
**loyalty_number** | **string** | Loyalty membership number. | [optional] 
**known_traveler_number** | **string** | Known traveler number. | [optional] 
**passenger_redress_number** | **string** | Redress number of the passenger. | [optional] 
**associated_infant_passenger_id** | **string** | Identifier for any associated infant passenger. | [optional] 
**seats** | [**\Swagger\Client\Model\BookingPassengerSelectedSeatSchema[]**](BookingPassengerSelectedSeatSchema.md) | Array of selected seats, each defined in BookingPassengerSelectedSeatSchema. | [optional] 
**bags** | [**\Swagger\Client\Model\BookingPassengerExtraBagSchema[]**](BookingPassengerExtraBagSchema.md) | Array of extra bags, each defined in BookingPassengerExtraBagSchema. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

