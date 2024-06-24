# FlightOfferSegmentSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**segment_id** | **str** | Unique identifier for the flight segment. | [optional] 
**duration** | **int** | Total duration of the flight segment in minutes. | [optional] 
**origin_name** | **str** | Name of the origin airport. | [optional] 
**origin_code** | **str** | IATA code of the origin airport. | [optional] 
**origin_latitude** | **float** | Latitude of the origin airport. | [optional] 
**origin_longitude** | **float** | Longitude of the origin airport. | [optional] 
**origin_terminal** | **str** | Terminal at the origin airport. | [optional] 
**destination_name** | **str** | Name of the destination airport. | [optional] 
**destination_code** | **str** | IATA code of the destination airport. | [optional] 
**destination_latitude** | **float** | Latitude of the destination airport. | [optional] 
**destination_longitude** | **float** | Longitude of the destination airport. | [optional] 
**destination_terminal** | **str** | Terminal at the destination airport. | [optional] 
**departure_date_time** | **str** | Scheduled departure date and time. | [optional] 
**arrival_date_time** | **str** | Scheduled arrival date and time. | [optional] 
**operating_airline_name** | **str** | Name of the operating airline. | [optional] 
**operating_airline_code** | **str** | Code of the operating airline. | [optional] 
**operating_airline_logo** | **str** | Logo of the operating airline. | [optional] 
**marketing_airline_name** | **str** | Name of the marketing airline. | [optional] 
**marketing_airline_code** | **str** | Code of the marketing airline. | [optional] 
**marketing_airline_logo** | **str** | Logo of the marketing airline. | [optional] 
**aircraft_name** | **str** | Name of the aircraft. | [optional] 
**aircraft_code** | **str** | Code of the aircraft. | [optional] 
**fare_brand_name** | **str** | Name of the fare brand. | [optional] 
**passengers** | [**list[FlightOfferSegmentPassengerSchema]**](FlightOfferSegmentPassengerSchema.md) | Array of FlightOfferSegmentPassengerSchema detailing passenger information. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

