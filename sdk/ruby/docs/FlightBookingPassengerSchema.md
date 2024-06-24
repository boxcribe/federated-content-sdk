# SwaggerClient::FlightBookingPassengerSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**passenger_id** | **String** | Unique identifier for the passenger. | [optional] 
**type** | **String** | Type of passenger (adult, child, infant, infant with seat). | [optional] 
**title** | **String** | Title of the passenger (e.g., Mr., Mrs.). | [optional] 
**first_name** | **String** | First name of the passenger. | [optional] 
**last_name** | **String** | Last name of the passenger. | [optional] 
**gender** | **String** | Gender of the passenger. | [optional] 
**date_of_birth** | **Date** | Date of birth of the passenger. | [optional] 
**country** | **String** | Country of the passenger. | [optional] 
**phone_prefix** | **String** | International dialing prefix for phone number. | [optional] 
**phone_number** | **String** | Phone number of the passenger. | [optional] 
**passport_type** | **String** | Type of passport. | [optional] 
**passport_number** | **String** | Passport number of the passenger. | [optional] 
**passport_expiration_date** | **Date** | Expiration date of the passport. | [optional] 
**passport_country** | **String** | Country of issue of the passport. | [optional] 
**loyalty_airline** | **String** | Airline with which the passenger has loyalty membership. | [optional] 
**loyalty_number** | **String** | Loyalty membership number. | [optional] 
**known_traveler_number** | **String** | Known traveler number. | [optional] 
**passenger_redress_number** | **String** | Redress number of the passenger. | [optional] 
**associated_infant_passenger_id** | **String** | Identifier for any associated infant passenger. | [optional] 
**seats** | [**Array&lt;BookingPassengerSelectedSeatSchema&gt;**](BookingPassengerSelectedSeatSchema.md) | Array of selected seats, each defined in BookingPassengerSelectedSeatSchema. | [optional] 
**bags** | [**Array&lt;BookingPassengerExtraBagSchema&gt;**](BookingPassengerExtraBagSchema.md) | Array of extra bags, each defined in BookingPassengerExtraBagSchema. | [optional] 

