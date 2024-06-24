# FlightBookingPassengerSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**passenger_id** | **str** | Unique identifier for the passenger. | [optional] 
**type** | **str** | Type of passenger (adult, child, infant, infant with seat). | [optional] 
**title** | **str** | Title of the passenger (e.g., Mr., Mrs.). | [optional] 
**first_name** | **str** | First name of the passenger. | [optional] 
**last_name** | **str** | Last name of the passenger. | [optional] 
**gender** | **str** | Gender of the passenger. | [optional] 
**date_of_birth** | **date** | Date of birth of the passenger. | [optional] 
**country** | **str** | Country of the passenger. | [optional] 
**phone_prefix** | **str** | International dialing prefix for phone number. | [optional] 
**phone_number** | **str** | Phone number of the passenger. | [optional] 
**passport_type** | **str** | Type of passport. | [optional] 
**passport_number** | **str** | Passport number of the passenger. | [optional] 
**passport_expiration_date** | **date** | Expiration date of the passport. | [optional] 
**passport_country** | **str** | Country of issue of the passport. | [optional] 
**loyalty_airline** | **str** | Airline with which the passenger has loyalty membership. | [optional] 
**loyalty_number** | **str** | Loyalty membership number. | [optional] 
**known_traveler_number** | **str** | Known traveler number. | [optional] 
**passenger_redress_number** | **str** | Redress number of the passenger. | [optional] 
**associated_infant_passenger_id** | **str** | Identifier for any associated infant passenger. | [optional] 
**seats** | [**list[BookingPassengerSelectedSeatSchema]**](BookingPassengerSelectedSeatSchema.md) | Array of selected seats, each defined in BookingPassengerSelectedSeatSchema. | [optional] 
**bags** | [**list[BookingPassengerExtraBagSchema]**](BookingPassengerExtraBagSchema.md) | Array of extra bags, each defined in BookingPassengerExtraBagSchema. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

