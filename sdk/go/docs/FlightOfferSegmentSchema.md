# FlightOfferSegmentSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SegmentId** | **string** | Unique identifier for the flight segment. | [optional] [default to null]
**Duration** | **int32** | Total duration of the flight segment in minutes. | [optional] [default to null]
**OriginName** | **string** | Name of the origin airport. | [optional] [default to null]
**OriginCode** | **string** | IATA code of the origin airport. | [optional] [default to null]
**OriginLatitude** | **float32** | Latitude of the origin airport. | [optional] [default to null]
**OriginLongitude** | **float32** | Longitude of the origin airport. | [optional] [default to null]
**OriginTerminal** | **string** | Terminal at the origin airport. | [optional] [default to null]
**DestinationName** | **string** | Name of the destination airport. | [optional] [default to null]
**DestinationCode** | **string** | IATA code of the destination airport. | [optional] [default to null]
**DestinationLatitude** | **float32** | Latitude of the destination airport. | [optional] [default to null]
**DestinationLongitude** | **float32** | Longitude of the destination airport. | [optional] [default to null]
**DestinationTerminal** | **string** | Terminal at the destination airport. | [optional] [default to null]
**DepartureDateTime** | **string** | Scheduled departure date and time. | [optional] [default to null]
**ArrivalDateTime** | **string** | Scheduled arrival date and time. | [optional] [default to null]
**OperatingAirlineName** | **string** | Name of the operating airline. | [optional] [default to null]
**OperatingAirlineCode** | **string** | Code of the operating airline. | [optional] [default to null]
**OperatingAirlineLogo** | **string** | Logo of the operating airline. | [optional] [default to null]
**MarketingAirlineName** | **string** | Name of the marketing airline. | [optional] [default to null]
**MarketingAirlineCode** | **string** | Code of the marketing airline. | [optional] [default to null]
**MarketingAirlineLogo** | **string** | Logo of the marketing airline. | [optional] [default to null]
**AircraftName** | **string** | Name of the aircraft. | [optional] [default to null]
**AircraftCode** | **string** | Code of the aircraft. | [optional] [default to null]
**FareBrandName** | **string** | Name of the fare brand. | [optional] [default to null]
**Passengers** | [**[]FlightOfferSegmentPassengerSchema**](FlightOfferSegmentPassengerSchema.md) | Array of FlightOfferSegmentPassengerSchema detailing passenger information. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

