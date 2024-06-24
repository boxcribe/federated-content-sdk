# FlightOfferSegmentSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**segment_id** | **string** | Unique identifier for the flight segment. | [optional] 
**duration** | **int** | Total duration of the flight segment in minutes. | [optional] 
**origin_name** | **string** | Name of the origin airport. | [optional] 
**origin_code** | **string** | IATA code of the origin airport. | [optional] 
**origin_latitude** | **float** | Latitude of the origin airport. | [optional] 
**origin_longitude** | **float** | Longitude of the origin airport. | [optional] 
**origin_terminal** | **string** | Terminal at the origin airport. | [optional] 
**destination_name** | **string** | Name of the destination airport. | [optional] 
**destination_code** | **string** | IATA code of the destination airport. | [optional] 
**destination_latitude** | **float** | Latitude of the destination airport. | [optional] 
**destination_longitude** | **float** | Longitude of the destination airport. | [optional] 
**destination_terminal** | **string** | Terminal at the destination airport. | [optional] 
**departure_date_time** | **string** | Scheduled departure date and time. | [optional] 
**arrival_date_time** | **string** | Scheduled arrival date and time. | [optional] 
**operating_airline_name** | **string** | Name of the operating airline. | [optional] 
**operating_airline_code** | **string** | Code of the operating airline. | [optional] 
**operating_airline_logo** | **string** | Logo of the operating airline. | [optional] 
**marketing_airline_name** | **string** | Name of the marketing airline. | [optional] 
**marketing_airline_code** | **string** | Code of the marketing airline. | [optional] 
**marketing_airline_logo** | **string** | Logo of the marketing airline. | [optional] 
**aircraft_name** | **string** | Name of the aircraft. | [optional] 
**aircraft_code** | **string** | Code of the aircraft. | [optional] 
**fare_brand_name** | **string** | Name of the fare brand. | [optional] 
**passengers** | [**\Swagger\Client\Model\FlightOfferSegmentPassengerSchema[]**](FlightOfferSegmentPassengerSchema.md) | Array of FlightOfferSegmentPassengerSchema detailing passenger information. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

