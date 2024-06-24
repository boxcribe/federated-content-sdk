# IO.Swagger.Model.FlightOfferSegmentSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SegmentId** | **Guid?** | Unique identifier for the flight segment. | [optional] 
**Duration** | **int?** | Total duration of the flight segment in minutes. | [optional] 
**OriginName** | **string** | Name of the origin airport. | [optional] 
**OriginCode** | **string** | IATA code of the origin airport. | [optional] 
**OriginLatitude** | **float?** | Latitude of the origin airport. | [optional] 
**OriginLongitude** | **float?** | Longitude of the origin airport. | [optional] 
**OriginTerminal** | **string** | Terminal at the origin airport. | [optional] 
**DestinationName** | **string** | Name of the destination airport. | [optional] 
**DestinationCode** | **string** | IATA code of the destination airport. | [optional] 
**DestinationLatitude** | **float?** | Latitude of the destination airport. | [optional] 
**DestinationLongitude** | **float?** | Longitude of the destination airport. | [optional] 
**DestinationTerminal** | **string** | Terminal at the destination airport. | [optional] 
**DepartureDateTime** | **string** | Scheduled departure date and time. | [optional] 
**ArrivalDateTime** | **string** | Scheduled arrival date and time. | [optional] 
**OperatingAirlineName** | **string** | Name of the operating airline. | [optional] 
**OperatingAirlineCode** | **string** | Code of the operating airline. | [optional] 
**OperatingAirlineLogo** | **string** | Logo of the operating airline. | [optional] 
**MarketingAirlineName** | **string** | Name of the marketing airline. | [optional] 
**MarketingAirlineCode** | **string** | Code of the marketing airline. | [optional] 
**MarketingAirlineLogo** | **string** | Logo of the marketing airline. | [optional] 
**AircraftName** | **string** | Name of the aircraft. | [optional] 
**AircraftCode** | **string** | Code of the aircraft. | [optional] 
**FareBrandName** | **string** | Name of the fare brand. | [optional] 
**Passengers** | [**List&lt;FlightOfferSegmentPassengerSchema&gt;**](FlightOfferSegmentPassengerSchema.md) | Array of FlightOfferSegmentPassengerSchema detailing passenger information. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

