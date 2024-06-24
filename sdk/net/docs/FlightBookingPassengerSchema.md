# IO.Swagger.Model.FlightBookingPassengerSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PassengerId** | **Guid?** | Unique identifier for the passenger. | [optional] 
**Type** | **string** | Type of passenger (adult, child, infant, infant with seat). | [optional] 
**Title** | **string** | Title of the passenger (e.g., Mr., Mrs.). | [optional] 
**FirstName** | **string** | First name of the passenger. | [optional] 
**LastName** | **string** | Last name of the passenger. | [optional] 
**Gender** | **string** | Gender of the passenger. | [optional] 
**DateOfBirth** | **DateTime?** | Date of birth of the passenger. | [optional] 
**Country** | **string** | Country of the passenger. | [optional] 
**PhonePrefix** | **string** | International dialing prefix for phone number. | [optional] 
**PhoneNumber** | **string** | Phone number of the passenger. | [optional] 
**PassportType** | **string** | Type of passport. | [optional] 
**PassportNumber** | **string** | Passport number of the passenger. | [optional] 
**PassportExpirationDate** | **DateTime?** | Expiration date of the passport. | [optional] 
**PassportCountry** | **string** | Country of issue of the passport. | [optional] 
**LoyaltyAirline** | **string** | Airline with which the passenger has loyalty membership. | [optional] 
**LoyaltyNumber** | **string** | Loyalty membership number. | [optional] 
**KnownTravelerNumber** | **string** | Known traveler number. | [optional] 
**PassengerRedressNumber** | **string** | Redress number of the passenger. | [optional] 
**AssociatedInfantPassengerId** | **Guid?** | Identifier for any associated infant passenger. | [optional] 
**Seats** | [**List&lt;BookingPassengerSelectedSeatSchema&gt;**](BookingPassengerSelectedSeatSchema.md) | Array of selected seats, each defined in BookingPassengerSelectedSeatSchema. | [optional] 
**Bags** | [**List&lt;BookingPassengerExtraBagSchema&gt;**](BookingPassengerExtraBagSchema.md) | Array of extra bags, each defined in BookingPassengerExtraBagSchema. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

