# FlightOfferSegmentSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**segmentId** | [**UUID**](UUID.md) | Unique identifier for the flight segment. |  [optional]
**duration** | **Integer** | Total duration of the flight segment in minutes. |  [optional]
**originName** | **String** | Name of the origin airport. |  [optional]
**originCode** | **String** | IATA code of the origin airport. |  [optional]
**originLatitude** | **Float** | Latitude of the origin airport. |  [optional]
**originLongitude** | **Float** | Longitude of the origin airport. |  [optional]
**originTerminal** | **String** | Terminal at the origin airport. |  [optional]
**destinationName** | **String** | Name of the destination airport. |  [optional]
**destinationCode** | **String** | IATA code of the destination airport. |  [optional]
**destinationLatitude** | **Float** | Latitude of the destination airport. |  [optional]
**destinationLongitude** | **Float** | Longitude of the destination airport. |  [optional]
**destinationTerminal** | **String** | Terminal at the destination airport. |  [optional]
**departureDateTime** | **String** | Scheduled departure date and time. |  [optional]
**arrivalDateTime** | **String** | Scheduled arrival date and time. |  [optional]
**operatingAirlineName** | **String** | Name of the operating airline. |  [optional]
**operatingAirlineCode** | **String** | Code of the operating airline. |  [optional]
**operatingAirlineLogo** | **String** | Logo of the operating airline. |  [optional]
**marketingAirlineName** | **String** | Name of the marketing airline. |  [optional]
**marketingAirlineCode** | **String** | Code of the marketing airline. |  [optional]
**marketingAirlineLogo** | **String** | Logo of the marketing airline. |  [optional]
**aircraftName** | **String** | Name of the aircraft. |  [optional]
**aircraftCode** | **String** | Code of the aircraft. |  [optional]
**fareBrandName** | **String** | Name of the fare brand. |  [optional]
**passengers** | [**List&lt;FlightOfferSegmentPassengerSchema&gt;**](FlightOfferSegmentPassengerSchema.md) | Array of FlightOfferSegmentPassengerSchema detailing passenger information. |  [optional]
