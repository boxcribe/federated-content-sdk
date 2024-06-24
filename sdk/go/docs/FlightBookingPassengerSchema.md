# FlightBookingPassengerSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PassengerId** | **string** | Unique identifier for the passenger. | [optional] [default to null]
**Type_** | **string** | Type of passenger (adult, child, infant, infant with seat). | [optional] [default to null]
**Title** | **string** | Title of the passenger (e.g., Mr., Mrs.). | [optional] [default to null]
**FirstName** | **string** | First name of the passenger. | [optional] [default to null]
**LastName** | **string** | Last name of the passenger. | [optional] [default to null]
**Gender** | **string** | Gender of the passenger. | [optional] [default to null]
**DateOfBirth** | **string** | Date of birth of the passenger. | [optional] [default to null]
**Country** | **string** | Country of the passenger. | [optional] [default to null]
**PhonePrefix** | **string** | International dialing prefix for phone number. | [optional] [default to null]
**PhoneNumber** | **string** | Phone number of the passenger. | [optional] [default to null]
**PassportType** | **string** | Type of passport. | [optional] [default to null]
**PassportNumber** | **string** | Passport number of the passenger. | [optional] [default to null]
**PassportExpirationDate** | **string** | Expiration date of the passport. | [optional] [default to null]
**PassportCountry** | **string** | Country of issue of the passport. | [optional] [default to null]
**LoyaltyAirline** | **string** | Airline with which the passenger has loyalty membership. | [optional] [default to null]
**LoyaltyNumber** | **string** | Loyalty membership number. | [optional] [default to null]
**KnownTravelerNumber** | **string** | Known traveler number. | [optional] [default to null]
**PassengerRedressNumber** | **string** | Redress number of the passenger. | [optional] [default to null]
**AssociatedInfantPassengerId** | **string** | Identifier for any associated infant passenger. | [optional] [default to null]
**Seats** | [**[]BookingPassengerSelectedSeatSchema**](BookingPassengerSelectedSeatSchema.md) | Array of selected seats, each defined in BookingPassengerSelectedSeatSchema. | [optional] [default to null]
**Bags** | [**[]BookingPassengerExtraBagSchema**](BookingPassengerExtraBagSchema.md) | Array of extra bags, each defined in BookingPassengerExtraBagSchema. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

