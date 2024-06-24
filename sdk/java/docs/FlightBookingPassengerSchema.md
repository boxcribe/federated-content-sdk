# FlightBookingPassengerSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**passengerId** | [**UUID**](UUID.md) | Unique identifier for the passenger. |  [optional]
**type** | **String** | Type of passenger (adult, child, infant, infant with seat). |  [optional]
**title** | **String** | Title of the passenger (e.g., Mr., Mrs.). |  [optional]
**firstName** | **String** | First name of the passenger. |  [optional]
**lastName** | **String** | Last name of the passenger. |  [optional]
**gender** | **String** | Gender of the passenger. |  [optional]
**dateOfBirth** | [**LocalDate**](LocalDate.md) | Date of birth of the passenger. |  [optional]
**country** | **String** | Country of the passenger. |  [optional]
**phonePrefix** | **String** | International dialing prefix for phone number. |  [optional]
**phoneNumber** | **String** | Phone number of the passenger. |  [optional]
**passportType** | **String** | Type of passport. |  [optional]
**passportNumber** | **String** | Passport number of the passenger. |  [optional]
**passportExpirationDate** | [**LocalDate**](LocalDate.md) | Expiration date of the passport. |  [optional]
**passportCountry** | **String** | Country of issue of the passport. |  [optional]
**loyaltyAirline** | **String** | Airline with which the passenger has loyalty membership. |  [optional]
**loyaltyNumber** | **String** | Loyalty membership number. |  [optional]
**knownTravelerNumber** | **String** | Known traveler number. |  [optional]
**passengerRedressNumber** | **String** | Redress number of the passenger. |  [optional]
**associatedInfantPassengerId** | [**UUID**](UUID.md) | Identifier for any associated infant passenger. |  [optional]
**seats** | [**List&lt;BookingPassengerSelectedSeatSchema&gt;**](BookingPassengerSelectedSeatSchema.md) | Array of selected seats, each defined in BookingPassengerSelectedSeatSchema. |  [optional]
**bags** | [**List&lt;BookingPassengerExtraBagSchema&gt;**](BookingPassengerExtraBagSchema.md) | Array of extra bags, each defined in BookingPassengerExtraBagSchema. |  [optional]
