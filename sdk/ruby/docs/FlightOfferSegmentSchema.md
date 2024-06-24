# SwaggerClient::FlightOfferSegmentSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**segment_id** | **String** | Unique identifier for the flight segment. | [optional] 
**duration** | **Integer** | Total duration of the flight segment in minutes. | [optional] 
**origin_name** | **String** | Name of the origin airport. | [optional] 
**origin_code** | **String** | IATA code of the origin airport. | [optional] 
**origin_latitude** | **Float** | Latitude of the origin airport. | [optional] 
**origin_longitude** | **Float** | Longitude of the origin airport. | [optional] 
**origin_terminal** | **String** | Terminal at the origin airport. | [optional] 
**destination_name** | **String** | Name of the destination airport. | [optional] 
**destination_code** | **String** | IATA code of the destination airport. | [optional] 
**destination_latitude** | **Float** | Latitude of the destination airport. | [optional] 
**destination_longitude** | **Float** | Longitude of the destination airport. | [optional] 
**destination_terminal** | **String** | Terminal at the destination airport. | [optional] 
**departure_date_time** | **String** | Scheduled departure date and time. | [optional] 
**arrival_date_time** | **String** | Scheduled arrival date and time. | [optional] 
**operating_airline_name** | **String** | Name of the operating airline. | [optional] 
**operating_airline_code** | **String** | Code of the operating airline. | [optional] 
**operating_airline_logo** | **String** | Logo of the operating airline. | [optional] 
**marketing_airline_name** | **String** | Name of the marketing airline. | [optional] 
**marketing_airline_code** | **String** | Code of the marketing airline. | [optional] 
**marketing_airline_logo** | **String** | Logo of the marketing airline. | [optional] 
**aircraft_name** | **String** | Name of the aircraft. | [optional] 
**aircraft_code** | **String** | Code of the aircraft. | [optional] 
**fare_brand_name** | **String** | Name of the fare brand. | [optional] 
**passengers** | [**Array&lt;FlightOfferSegmentPassengerSchema&gt;**](FlightOfferSegmentPassengerSchema.md) | Array of FlightOfferSegmentPassengerSchema detailing passenger information. | [optional] 

