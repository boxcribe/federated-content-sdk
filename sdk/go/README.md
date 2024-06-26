# Go API client for swagger

Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

## Overview
This API client was generated by the [swagger-codegen](https://github.com/swagger-api/swagger-codegen) project.  By using the [swagger-spec](https://github.com/swagger-api/swagger-spec) from a remote server, you can easily generate an API client.

- API version: 1.0.0
- Package version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.go.GoClientCodegen

## Installation
Put the package under your project folder and add the following in import:
```golang
import "./swagger"
```

## Documentation for API Endpoints

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ApiKeysApi* | [**ApikeysGet**](docs/ApiKeysApi.md#apikeysget) | **Get** /apikeys | Get api keys
*ApiKeysApi* | [**ApikeysIdDelete**](docs/ApiKeysApi.md#apikeysiddelete) | **Delete** /apikeys/{id} | Delete api key
*ApiKeysApi* | [**ApikeysIdGet**](docs/ApiKeysApi.md#apikeysidget) | **Get** /apikeys/{id} | Get api key
*ApiKeysApi* | [**ApikeysIdPatch**](docs/ApiKeysApi.md#apikeysidpatch) | **Patch** /apikeys/{id} | Update api key
*ApiKeysApi* | [**ApikeysPost**](docs/ApiKeysApi.md#apikeyspost) | **Post** /apikeys | Create api key
*AuthenticationApi* | [**AuthForgotPasswordPost**](docs/AuthenticationApi.md#authforgotpasswordpost) | **Post** /auth/forgot-password | Forgot password
*AuthenticationApi* | [**AuthLoginPost**](docs/AuthenticationApi.md#authloginpost) | **Post** /auth/login | Login
*AuthenticationApi* | [**AuthLogoutPost**](docs/AuthenticationApi.md#authlogoutpost) | **Post** /auth/logout | Logout
*AuthenticationApi* | [**AuthRefreshTokensPost**](docs/AuthenticationApi.md#authrefreshtokenspost) | **Post** /auth/refresh-tokens | Refresh auth tokens
*AuthenticationApi* | [**AuthRegisterPost**](docs/AuthenticationApi.md#authregisterpost) | **Post** /auth/register | Register
*AuthenticationApi* | [**AuthResetPasswordPost**](docs/AuthenticationApi.md#authresetpasswordpost) | **Post** /auth/reset-password | Reset password
*AuthenticationApi* | [**AuthSendVerificationEmailPost**](docs/AuthenticationApi.md#authsendverificationemailpost) | **Post** /auth/send-verification-email | Send verification email
*AuthenticationApi* | [**AuthVerifyEmailPost**](docs/AuthenticationApi.md#authverifyemailpost) | **Post** /auth/verify-email | verify email
*CarsApi* | [**CarsBookingsBookingIdCancelPost**](docs/CarsApi.md#carsbookingsbookingidcancelpost) | **Post** /cars/bookings/{bookingId}/cancel | Cancel Booking
*CarsApi* | [**CarsBookingsBookingIdGet**](docs/CarsApi.md#carsbookingsbookingidget) | **Get** /cars/bookings/{bookingId} | Get Booking Details
*CarsApi* | [**CarsBookingsPost**](docs/CarsApi.md#carsbookingspost) | **Post** /cars/bookings | Create Booking
*CarsApi* | [**CarsOfferAvailabilityOfferIdGet**](docs/CarsApi.md#carsofferavailabilityofferidget) | **Get** /cars/offer_availability/{offerId} | Get Offer Availability
*CarsApi* | [**CarsOffersOfferIdGet**](docs/CarsApi.md#carsoffersofferidget) | **Get** /cars/offers/{offerId} | Get Offer Details
*CarsApi* | [**CarsOffersSearchPost**](docs/CarsApi.md#carsofferssearchpost) | **Post** /cars/offers/search | Search Offers
*CategoriesApi* | [**CategoriesGet**](docs/CategoriesApi.md#categoriesget) | **Get** /categories | Get categories
*CategoriesApi* | [**CategoriesIdDelete**](docs/CategoriesApi.md#categoriesiddelete) | **Delete** /categories/{id} | Delete category
*CategoriesApi* | [**CategoriesIdGet**](docs/CategoriesApi.md#categoriesidget) | **Get** /categories/{id} | Get category
*CategoriesApi* | [**CategoriesIdPatch**](docs/CategoriesApi.md#categoriesidpatch) | **Patch** /categories/{id} | Update category
*CategoriesApi* | [**CategoriesPost**](docs/CategoriesApi.md#categoriespost) | **Post** /categories | Create category
*CompaniesApi* | [**CompaniesGet**](docs/CompaniesApi.md#companiesget) | **Get** /companies | Get companies
*CompaniesApi* | [**CompaniesIdDelete**](docs/CompaniesApi.md#companiesiddelete) | **Delete** /companies/{id} | Delete company
*CompaniesApi* | [**CompaniesIdGet**](docs/CompaniesApi.md#companiesidget) | **Get** /companies/{id} | Get company
*CompaniesApi* | [**CompaniesIdPatch**](docs/CompaniesApi.md#companiesidpatch) | **Patch** /companies/{id} | Update company
*CompaniesApi* | [**CompaniesPost**](docs/CompaniesApi.md#companiespost) | **Post** /companies | Create company
*DiningApi* | [**DiningBookingsBookingIdCancelPost**](docs/DiningApi.md#diningbookingsbookingidcancelpost) | **Post** /dining/bookings/{bookingId}/cancel | Cancel Booking
*DiningApi* | [**DiningBookingsBookingIdGet**](docs/DiningApi.md#diningbookingsbookingidget) | **Get** /dining/bookings/{bookingId} | Get Booking Details
*DiningApi* | [**DiningBookingsPost**](docs/DiningApi.md#diningbookingspost) | **Post** /dining/bookings | Create Booking
*DiningApi* | [**DiningOfferAvailabilityOfferIdGet**](docs/DiningApi.md#diningofferavailabilityofferidget) | **Get** /dining/offer_availability/{offerId} | Get Offer Availability
*DiningApi* | [**DiningOffersOfferIdGet**](docs/DiningApi.md#diningoffersofferidget) | **Get** /dining/offers/{offerId} | Get Offer Details
*DiningApi* | [**DiningOffersSearchPost**](docs/DiningApi.md#diningofferssearchpost) | **Post** /dining/offers/search | Search Offers
*EventsApi* | [**EventsBookingsBookingIdCancelPost**](docs/EventsApi.md#eventsbookingsbookingidcancelpost) | **Post** /events/bookings/{bookingId}/cancel | Cancel Booking
*EventsApi* | [**EventsBookingsBookingIdGet**](docs/EventsApi.md#eventsbookingsbookingidget) | **Get** /events/bookings/{bookingId} | Get Booking Details
*EventsApi* | [**EventsBookingsPost**](docs/EventsApi.md#eventsbookingspost) | **Post** /events/bookings | Create Booking
*EventsApi* | [**EventsOfferAvailabilityOfferIdGet**](docs/EventsApi.md#eventsofferavailabilityofferidget) | **Get** /events/offer_availability/{offerId} | Get Offer Availability
*EventsApi* | [**EventsOffersOfferIdGet**](docs/EventsApi.md#eventsoffersofferidget) | **Get** /events/offers/{offerId} | Get Offer Details
*EventsApi* | [**EventsOffersSearchPost**](docs/EventsApi.md#eventsofferssearchpost) | **Post** /events/offers/search | Search Offers
*FieldsApi* | [**FieldsGet**](docs/FieldsApi.md#fieldsget) | **Get** /fields | Get fields
*FieldsApi* | [**FieldsIdDelete**](docs/FieldsApi.md#fieldsiddelete) | **Delete** /fields/{id} | Delete field
*FieldsApi* | [**FieldsIdGet**](docs/FieldsApi.md#fieldsidget) | **Get** /fields/{id} | Get field
*FieldsApi* | [**FieldsIdPatch**](docs/FieldsApi.md#fieldsidpatch) | **Patch** /fields/{id} | Update field
*FieldsApi* | [**FieldsPost**](docs/FieldsApi.md#fieldspost) | **Post** /fields | Create field
*FlightsApi* | [**FlightsBookingsBookingIdCancelPost**](docs/FlightsApi.md#flightsbookingsbookingidcancelpost) | **Post** /flights/bookings/{bookingId}/cancel | Cancel Booking
*FlightsApi* | [**FlightsBookingsBookingIdGet**](docs/FlightsApi.md#flightsbookingsbookingidget) | **Get** /flights/bookings/{bookingId} | Get Booking Details
*FlightsApi* | [**FlightsBookingsPost**](docs/FlightsApi.md#flightsbookingspost) | **Post** /flights/bookings | Create Booking
*FlightsApi* | [**FlightsOffersOfferIdGet**](docs/FlightsApi.md#flightsoffersofferidget) | **Get** /flights/offers/{offerId} | Get Offer Details
*FlightsApi* | [**FlightsOffersOfferIdSeatmapsGet**](docs/FlightsApi.md#flightsoffersofferidseatmapsget) | **Get** /flights/offers/{offerId}/seatmaps | Get Offer Seatmaps
*FlightsApi* | [**FlightsOffersSearchPost**](docs/FlightsApi.md#flightsofferssearchpost) | **Post** /flights/offers/search | Search Offers
*HealthCheckApi* | [**HelpGet**](docs/HealthCheckApi.md#helpget) | **Get** /help | Help
*HotelsApi* | [**HotelsBookingsBookingIdCancelPost**](docs/HotelsApi.md#hotelsbookingsbookingidcancelpost) | **Post** /hotels/bookings/{bookingId}/cancel | Cancel Booking
*HotelsApi* | [**HotelsBookingsBookingIdGet**](docs/HotelsApi.md#hotelsbookingsbookingidget) | **Get** /hotels/bookings/{bookingId} | Get Booking Details
*HotelsApi* | [**HotelsBookingsPost**](docs/HotelsApi.md#hotelsbookingspost) | **Post** /hotels/bookings | Create Booking
*HotelsApi* | [**HotelsOfferAvailabilityOfferIdGet**](docs/HotelsApi.md#hotelsofferavailabilityofferidget) | **Get** /hotels/offer_availability/{offerId} | Get Offer Availability
*HotelsApi* | [**HotelsOffersOfferIdGet**](docs/HotelsApi.md#hotelsoffersofferidget) | **Get** /hotels/offers/{offerId} | Get Offer Details
*HotelsApi* | [**HotelsOffersSearchPost**](docs/HotelsApi.md#hotelsofferssearchpost) | **Post** /hotels/offers/search | Search Offers
*IntegrationsApi* | [**IntegrationsGet**](docs/IntegrationsApi.md#integrationsget) | **Get** /integrations | Get integrations
*IntegrationsApi* | [**IntegrationsIdDelete**](docs/IntegrationsApi.md#integrationsiddelete) | **Delete** /integrations/{id} | Delete integration
*IntegrationsApi* | [**IntegrationsIdGet**](docs/IntegrationsApi.md#integrationsidget) | **Get** /integrations/{id} | Get integration
*IntegrationsApi* | [**IntegrationsIdPatch**](docs/IntegrationsApi.md#integrationsidpatch) | **Patch** /integrations/{id} | Update integration
*IntegrationsApi* | [**IntegrationsPost**](docs/IntegrationsApi.md#integrationspost) | **Post** /integrations | Create integration
*LogsApi* | [**LogsGet**](docs/LogsApi.md#logsget) | **Get** /logs | Get logs
*LogsApi* | [**LogsIdDelete**](docs/LogsApi.md#logsiddelete) | **Delete** /logs/{id} | Delete log
*LogsApi* | [**LogsIdGet**](docs/LogsApi.md#logsidget) | **Get** /logs/{id} | Get log
*LogsApi* | [**LogsIdPatch**](docs/LogsApi.md#logsidpatch) | **Patch** /logs/{id} | Update log
*LogsApi* | [**LogsPost**](docs/LogsApi.md#logspost) | **Post** /logs | Create log
*MappingsApi* | [**MappingsGet**](docs/MappingsApi.md#mappingsget) | **Get** /mappings | Get mappings
*MappingsApi* | [**MappingsIdDelete**](docs/MappingsApi.md#mappingsiddelete) | **Delete** /mappings/{id} | Delete mapping
*MappingsApi* | [**MappingsIdGet**](docs/MappingsApi.md#mappingsidget) | **Get** /mappings/{id} | Get mapping
*MappingsApi* | [**MappingsIdPatch**](docs/MappingsApi.md#mappingsidpatch) | **Patch** /mappings/{id} | Update mapping
*MappingsApi* | [**MappingsPost**](docs/MappingsApi.md#mappingspost) | **Post** /mappings | Create mapping
*SchemasApi* | [**SchemasGet**](docs/SchemasApi.md#schemasget) | **Get** /schemas | Get schemas
*SchemasApi* | [**SchemasGroupedByEndpointGet**](docs/SchemasApi.md#schemasgroupedbyendpointget) | **Get** /schemas/groupedByEndpoint | Get schemas grouped by endpoint
*SchemasApi* | [**SchemasIdDelete**](docs/SchemasApi.md#schemasiddelete) | **Delete** /schemas/{id} | Delete schema
*SchemasApi* | [**SchemasIdGet**](docs/SchemasApi.md#schemasidget) | **Get** /schemas/{id} | Get schema
*SchemasApi* | [**SchemasIdPatch**](docs/SchemasApi.md#schemasidpatch) | **Patch** /schemas/{id} | Update schema
*SchemasApi* | [**SchemasPost**](docs/SchemasApi.md#schemaspost) | **Post** /schemas | Create schema
*TenantsApi* | [**TenantsGet**](docs/TenantsApi.md#tenantsget) | **Get** /tenants | Get tenants
*TenantsApi* | [**TenantsIdDelete**](docs/TenantsApi.md#tenantsiddelete) | **Delete** /tenants/{id} | Delete tenant
*TenantsApi* | [**TenantsIdGet**](docs/TenantsApi.md#tenantsidget) | **Get** /tenants/{id} | Get tenant
*TenantsApi* | [**TenantsIdPatch**](docs/TenantsApi.md#tenantsidpatch) | **Patch** /tenants/{id} | Update tenant
*TenantsApi* | [**TenantsPost**](docs/TenantsApi.md#tenantspost) | **Post** /tenants | Create tenant
*ToursAndActivitiesApi* | [**ToursBookingsBookingIdCancelPost**](docs/ToursAndActivitiesApi.md#toursbookingsbookingidcancelpost) | **Post** /tours/bookings/{bookingId}/cancel | Cancel Booking
*ToursAndActivitiesApi* | [**ToursBookingsBookingIdGet**](docs/ToursAndActivitiesApi.md#toursbookingsbookingidget) | **Get** /tours/bookings/{bookingId} | Get Booking Details
*ToursAndActivitiesApi* | [**ToursBookingsPost**](docs/ToursAndActivitiesApi.md#toursbookingspost) | **Post** /tours/bookings | Create Booking
*ToursAndActivitiesApi* | [**ToursOfferAvailabilityOfferIdPost**](docs/ToursAndActivitiesApi.md#toursofferavailabilityofferidpost) | **Post** /tours/offer_availability/{offerId} | Get Offer Availability
*ToursAndActivitiesApi* | [**ToursOffersOfferIdGet**](docs/ToursAndActivitiesApi.md#toursoffersofferidget) | **Get** /tours/offers/{offerId} | Get Offer Details
*ToursAndActivitiesApi* | [**ToursOffersSearchPost**](docs/ToursAndActivitiesApi.md#toursofferssearchpost) | **Post** /tours/offers/search | Search Offers
*TransportsApi* | [**TransportsBookingsBookingIdCancelPost**](docs/TransportsApi.md#transportsbookingsbookingidcancelpost) | **Post** /transports/bookings/{bookingId}/cancel | Cancel Booking
*TransportsApi* | [**TransportsBookingsBookingIdGet**](docs/TransportsApi.md#transportsbookingsbookingidget) | **Get** /transports/bookings/{bookingId} | Get Booking Details
*TransportsApi* | [**TransportsBookingsPost**](docs/TransportsApi.md#transportsbookingspost) | **Post** /transports/bookings | Create Booking
*TransportsApi* | [**TransportsOfferAvailabilityOfferIdGet**](docs/TransportsApi.md#transportsofferavailabilityofferidget) | **Get** /transports/offer_availability/{offerId} | Get Offer Availability
*TransportsApi* | [**TransportsOffersOfferIdGet**](docs/TransportsApi.md#transportsoffersofferidget) | **Get** /transports/offers/{offerId} | Get Offer Details
*TransportsApi* | [**TransportsOffersSearchPost**](docs/TransportsApi.md#transportsofferssearchpost) | **Post** /transports/offers/search | Search Offers
*UploadsApi* | [**UploadPost**](docs/UploadsApi.md#uploadpost) | **Post** /upload | Upload a file to AWS S3
*UsersApi* | [**UsersGet**](docs/UsersApi.md#usersget) | **Get** /users | Get users
*UsersApi* | [**UsersPost**](docs/UsersApi.md#userspost) | **Post** /users | Create User
*UsersApi* | [**UsersuserIdDelete**](docs/UsersApi.md#usersuseriddelete) | **Delete** /users/:userId | Delete User
*UsersApi* | [**UsersuserIdGet**](docs/UsersApi.md#usersuseridget) | **Get** /users/:userId | Get Users
*UsersApi* | [**UsersuserIdPatch**](docs/UsersApi.md#usersuseridpatch) | **Patch** /users/:userId | Update User

## Documentation For Models

 - [ApiKey](docs/ApiKey.md)
 - [ApikeysBody](docs/ApikeysBody.md)
 - [ApikeysIdBody](docs/ApikeysIdBody.md)
 - [AuthForgotpasswordBody](docs/AuthForgotpasswordBody.md)
 - [AuthLoginBody](docs/AuthLoginBody.md)
 - [AuthLogoutBody](docs/AuthLogoutBody.md)
 - [AuthRefreshtokensBody](docs/AuthRefreshtokensBody.md)
 - [AuthRegisterBody](docs/AuthRegisterBody.md)
 - [AuthResetpasswordBody](docs/AuthResetpasswordBody.md)
 - [AuthSendverificationemailBody](docs/AuthSendverificationemailBody.md)
 - [AuthTokens](docs/AuthTokens.md)
 - [BookingPassengerExtraBagSchema](docs/BookingPassengerExtraBagSchema.md)
 - [BookingPassengerSelectedSeatSchema](docs/BookingPassengerSelectedSeatSchema.md)
 - [CarBookingCustomerSchema](docs/CarBookingCustomerSchema.md)
 - [CarBookingDetailsRequestSchema](docs/CarBookingDetailsRequestSchema.md)
 - [CarBookingDetailsResponseSchema](docs/CarBookingDetailsResponseSchema.md)
 - [CarBookingResponseSchema](docs/CarBookingResponseSchema.md)
 - [CarCancelBookingRequestSchema](docs/CarCancelBookingRequestSchema.md)
 - [CarCancelBookingResponseSchema](docs/CarCancelBookingResponseSchema.md)
 - [CarCreateBookingCustomerSchema](docs/CarCreateBookingCustomerSchema.md)
 - [CarCreateBookingPaymentSchema](docs/CarCreateBookingPaymentSchema.md)
 - [CarCreateBookingRequestSchema](docs/CarCreateBookingRequestSchema.md)
 - [CarGetOfferAvailabilityRequest](docs/CarGetOfferAvailabilityRequest.md)
 - [CarGetOfferAvailabilityResponse](docs/CarGetOfferAvailabilityResponse.md)
 - [CarOfferDetailsRequestSchema](docs/CarOfferDetailsRequestSchema.md)
 - [CarOfferDetailsSchema](docs/CarOfferDetailsSchema.md)
 - [CarOfferRequestSchema](docs/CarOfferRequestSchema.md)
 - [CarOfferResponseItemSchema](docs/CarOfferResponseItemSchema.md)
 - [CarOfferResponseSchema](docs/CarOfferResponseSchema.md)
 - [CategoriesBody](docs/CategoriesBody.md)
 - [CategoriesIdBody](docs/CategoriesIdBody.md)
 - [Category](docs/Category.md)
 - [CompaniesBody](docs/CompaniesBody.md)
 - [CompaniesIdBody](docs/CompaniesIdBody.md)
 - [Company](docs/Company.md)
 - [DiningAvailabilitySchema](docs/DiningAvailabilitySchema.md)
 - [DiningBookingCustomerSchema](docs/DiningBookingCustomerSchema.md)
 - [DiningBookingDetailsRequestSchema](docs/DiningBookingDetailsRequestSchema.md)
 - [DiningBookingDetailsResponseSchema](docs/DiningBookingDetailsResponseSchema.md)
 - [DiningBookingResponseSchema](docs/DiningBookingResponseSchema.md)
 - [DiningCancelBookingRequestSchema](docs/DiningCancelBookingRequestSchema.md)
 - [DiningCancelBookingResponseSchema](docs/DiningCancelBookingResponseSchema.md)
 - [DiningCreateBookingCustomerSchema](docs/DiningCreateBookingCustomerSchema.md)
 - [DiningCreateBookingPaymentSchema](docs/DiningCreateBookingPaymentSchema.md)
 - [DiningCreateBookingRequestSchema](docs/DiningCreateBookingRequestSchema.md)
 - [DiningGetOfferAvailabilityRequest](docs/DiningGetOfferAvailabilityRequest.md)
 - [DiningGetOfferAvailabilityResponse](docs/DiningGetOfferAvailabilityResponse.md)
 - [DiningOfferDetailsRequestSchema](docs/DiningOfferDetailsRequestSchema.md)
 - [DiningOfferDetailsSchema](docs/DiningOfferDetailsSchema.md)
 - [DiningOfferRequestSchema](docs/DiningOfferRequestSchema.md)
 - [DiningOfferResponseItemSchema](docs/DiningOfferResponseItemSchema.md)
 - [DiningOfferResponseSchema](docs/DiningOfferResponseSchema.md)
 - [EventBookingCustomerSchema](docs/EventBookingCustomerSchema.md)
 - [EventBookingDetailsRequestSchema](docs/EventBookingDetailsRequestSchema.md)
 - [EventBookingDetailsResponseSchema](docs/EventBookingDetailsResponseSchema.md)
 - [EventBookingResponseSchema](docs/EventBookingResponseSchema.md)
 - [EventCancelBookingRequestSchema](docs/EventCancelBookingRequestSchema.md)
 - [EventCancelBookingResponseSchema](docs/EventCancelBookingResponseSchema.md)
 - [EventCreateBookingCustomerSchema](docs/EventCreateBookingCustomerSchema.md)
 - [EventCreateBookingPaymentSchema](docs/EventCreateBookingPaymentSchema.md)
 - [EventCreateBookingRequestSchema](docs/EventCreateBookingRequestSchema.md)
 - [EventGetOfferAvailabilityRequest](docs/EventGetOfferAvailabilityRequest.md)
 - [EventGetOfferAvailabilityResponse](docs/EventGetOfferAvailabilityResponse.md)
 - [EventOfferDetailsRequestSchema](docs/EventOfferDetailsRequestSchema.md)
 - [EventOfferDetailsSchema](docs/EventOfferDetailsSchema.md)
 - [EventOfferRequestSchema](docs/EventOfferRequestSchema.md)
 - [EventOfferResponseItemSchema](docs/EventOfferResponseItemSchema.md)
 - [EventOfferResponseSchema](docs/EventOfferResponseSchema.md)
 - [EventTicketSchema](docs/EventTicketSchema.md)
 - [Field](docs/Field.md)
 - [FieldsBody](docs/FieldsBody.md)
 - [FieldsIdBody](docs/FieldsIdBody.md)
 - [FlightBookingCustomerSchema](docs/FlightBookingCustomerSchema.md)
 - [FlightBookingDetailsRequestSchema](docs/FlightBookingDetailsRequestSchema.md)
 - [FlightBookingPassengerSchema](docs/FlightBookingPassengerSchema.md)
 - [FlightBookingResponseSchema](docs/FlightBookingResponseSchema.md)
 - [FlightCancelBookingRequestSchema](docs/FlightCancelBookingRequestSchema.md)
 - [FlightCancelBookingResponseSchema](docs/FlightCancelBookingResponseSchema.md)
 - [FlightCreateBookingCustomerSchema](docs/FlightCreateBookingCustomerSchema.md)
 - [FlightCreateBookingPaymentSchema](docs/FlightCreateBookingPaymentSchema.md)
 - [FlightCreateBookingRequestSchema](docs/FlightCreateBookingRequestSchema.md)
 - [FlightGetBookingDetailsResponseSchema](docs/FlightGetBookingDetailsResponseSchema.md)
 - [FlightLegOfferRequestSchema](docs/FlightLegOfferRequestSchema.md)
 - [FlightOfferDetailsRequestSchema](docs/FlightOfferDetailsRequestSchema.md)
 - [FlightOfferDetailsRequestSchemaRepriceRequest](docs/FlightOfferDetailsRequestSchemaRepriceRequest.md)
 - [FlightOfferDetailsResponseSchema](docs/FlightOfferDetailsResponseSchema.md)
 - [FlightOfferLegSchema](docs/FlightOfferLegSchema.md)
 - [FlightOfferPassengerSchema](docs/FlightOfferPassengerSchema.md)
 - [FlightOfferRequestSchema](docs/FlightOfferRequestSchema.md)
 - [FlightOfferResponseItemSchema](docs/FlightOfferResponseItemSchema.md)
 - [FlightOfferResponseSchema](docs/FlightOfferResponseSchema.md)
 - [FlightOfferSeatmapSchema](docs/FlightOfferSeatmapSchema.md)
 - [FlightOfferSeatmapsRequestSchema](docs/FlightOfferSeatmapsRequestSchema.md)
 - [FlightOfferSeatmapsResponseSchema](docs/FlightOfferSeatmapsResponseSchema.md)
 - [FlightOfferSegmentPassengerSchema](docs/FlightOfferSegmentPassengerSchema.md)
 - [FlightOfferSegmentPassengerSchemaBags](docs/FlightOfferSegmentPassengerSchemaBags.md)
 - [FlightOfferSegmentSchema](docs/FlightOfferSegmentSchema.md)
 - [FlightPassengerOfferRequestSchema](docs/FlightPassengerOfferRequestSchema.md)
 - [HotelBookingCustomerSchema](docs/HotelBookingCustomerSchema.md)
 - [HotelBookingDetailsRequestSchema](docs/HotelBookingDetailsRequestSchema.md)
 - [HotelBookingDetailsResponseSchema](docs/HotelBookingDetailsResponseSchema.md)
 - [HotelBookingResponseSchema](docs/HotelBookingResponseSchema.md)
 - [HotelCancelBookingRequestSchema](docs/HotelCancelBookingRequestSchema.md)
 - [HotelCancelBookingResponseSchema](docs/HotelCancelBookingResponseSchema.md)
 - [HotelCreateBookingCustomerSchema](docs/HotelCreateBookingCustomerSchema.md)
 - [HotelCreateBookingPaymentSchema](docs/HotelCreateBookingPaymentSchema.md)
 - [HotelCreateBookingRequestSchema](docs/HotelCreateBookingRequestSchema.md)
 - [HotelGetOfferAvailabilityRequest](docs/HotelGetOfferAvailabilityRequest.md)
 - [HotelGetOfferAvailabilityResponse](docs/HotelGetOfferAvailabilityResponse.md)
 - [HotelOfferDetailsRequestSchema](docs/HotelOfferDetailsRequestSchema.md)
 - [HotelOfferDetailsSchema](docs/HotelOfferDetailsSchema.md)
 - [HotelOfferRequestSchema](docs/HotelOfferRequestSchema.md)
 - [HotelOfferRequestSchemaRooms](docs/HotelOfferRequestSchemaRooms.md)
 - [HotelOfferResponseItemSchema](docs/HotelOfferResponseItemSchema.md)
 - [HotelOfferResponseSchema](docs/HotelOfferResponseSchema.md)
 - [HotelRoomSchema](docs/HotelRoomSchema.md)
 - [InlineResponse200](docs/InlineResponse200.md)
 - [InlineResponse2001](docs/InlineResponse2001.md)
 - [InlineResponse20010](docs/InlineResponse20010.md)
 - [InlineResponse20011](docs/InlineResponse20011.md)
 - [InlineResponse20011Results](docs/InlineResponse20011Results.md)
 - [InlineResponse20012](docs/InlineResponse20012.md)
 - [InlineResponse20013](docs/InlineResponse20013.md)
 - [InlineResponse2002](docs/InlineResponse2002.md)
 - [InlineResponse2003](docs/InlineResponse2003.md)
 - [InlineResponse2004](docs/InlineResponse2004.md)
 - [InlineResponse2005](docs/InlineResponse2005.md)
 - [InlineResponse2006](docs/InlineResponse2006.md)
 - [InlineResponse2007](docs/InlineResponse2007.md)
 - [InlineResponse2008](docs/InlineResponse2008.md)
 - [InlineResponse2009](docs/InlineResponse2009.md)
 - [InlineResponse201](docs/InlineResponse201.md)
 - [InlineResponse500](docs/InlineResponse500.md)
 - [Integration](docs/Integration.md)
 - [IntegrationsBody](docs/IntegrationsBody.md)
 - [IntegrationsCredentialsProduction](docs/IntegrationsCredentialsProduction.md)
 - [IntegrationsIdBody](docs/IntegrationsIdBody.md)
 - [IntegrationsSettingsProduction](docs/IntegrationsSettingsProduction.md)
 - [Log](docs/Log.md)
 - [LogsBody](docs/LogsBody.md)
 - [LogsIdBody](docs/LogsIdBody.md)
 - [Mapping](docs/Mapping.md)
 - [MappingsBody](docs/MappingsBody.md)
 - [MappingsIdBody](docs/MappingsIdBody.md)
 - [MappingsMapping](docs/MappingsMapping.md)
 - [ModelError](docs/ModelError.md)
 - [OfferPassengerExtraBagSchema](docs/OfferPassengerExtraBagSchema.md)
 - [OfferPassengerSelectedSeatSchema](docs/OfferPassengerSelectedSeatSchema.md)
 - [OfferRequest](docs/OfferRequest.md)
 - [OfferResult](docs/OfferResult.md)
 - [OfferResultNormalizedResponse](docs/OfferResultNormalizedResponse.md)
 - [PassengerExtraBagSchema](docs/PassengerExtraBagSchema.md)
 - [PassengerSelectedSeatSchema](docs/PassengerSelectedSeatSchema.md)
 - [Schema](docs/Schema.md)
 - [SchemasBody](docs/SchemasBody.md)
 - [SchemasIdBody](docs/SchemasIdBody.md)
 - [Tenant](docs/Tenant.md)
 - [TenantsBody](docs/TenantsBody.md)
 - [TenantsIdBody](docs/TenantsIdBody.md)
 - [Token](docs/Token.md)
 - [ToursAndActivitiesBookingCustomerSchema](docs/ToursAndActivitiesBookingCustomerSchema.md)
 - [ToursAndActivitiesBookingDetailsRequestSchema](docs/ToursAndActivitiesBookingDetailsRequestSchema.md)
 - [ToursAndActivitiesBookingDetailsResponseSchema](docs/ToursAndActivitiesBookingDetailsResponseSchema.md)
 - [ToursAndActivitiesBookingResponseSchema](docs/ToursAndActivitiesBookingResponseSchema.md)
 - [ToursAndActivitiesCancelBookingRequestSchema](docs/ToursAndActivitiesCancelBookingRequestSchema.md)
 - [ToursAndActivitiesCancelBookingResponseSchema](docs/ToursAndActivitiesCancelBookingResponseSchema.md)
 - [ToursAndActivitiesCreateBookingCustomerSchema](docs/ToursAndActivitiesCreateBookingCustomerSchema.md)
 - [ToursAndActivitiesCreateBookingPaymentSchema](docs/ToursAndActivitiesCreateBookingPaymentSchema.md)
 - [ToursAndActivitiesCreateBookingRequestSchema](docs/ToursAndActivitiesCreateBookingRequestSchema.md)
 - [ToursAndActivitiesGetOfferAvailabilityRequest](docs/ToursAndActivitiesGetOfferAvailabilityRequest.md)
 - [ToursAndActivitiesGetOfferAvailabilityResponse](docs/ToursAndActivitiesGetOfferAvailabilityResponse.md)
 - [ToursAndActivitiesOfferDetailsRequestSchema](docs/ToursAndActivitiesOfferDetailsRequestSchema.md)
 - [ToursAndActivitiesOfferDetailsSchema](docs/ToursAndActivitiesOfferDetailsSchema.md)
 - [ToursAndActivitiesOfferRequestSchema](docs/ToursAndActivitiesOfferRequestSchema.md)
 - [ToursAndActivitiesOfferResponseItemSchema](docs/ToursAndActivitiesOfferResponseItemSchema.md)
 - [ToursAndActivitiesOfferResponseSchema](docs/ToursAndActivitiesOfferResponseSchema.md)
 - [ToursAndActivitiesVariantSchema](docs/ToursAndActivitiesVariantSchema.md)
 - [TransportBookingCustomerSchema](docs/TransportBookingCustomerSchema.md)
 - [TransportBookingDetailsRequestSchema](docs/TransportBookingDetailsRequestSchema.md)
 - [TransportBookingDetailsResponseSchema](docs/TransportBookingDetailsResponseSchema.md)
 - [TransportBookingResponseSchema](docs/TransportBookingResponseSchema.md)
 - [TransportCancelBookingRequestSchema](docs/TransportCancelBookingRequestSchema.md)
 - [TransportCancelBookingResponseSchema](docs/TransportCancelBookingResponseSchema.md)
 - [TransportCreateBookingCustomerSchema](docs/TransportCreateBookingCustomerSchema.md)
 - [TransportCreateBookingPaymentSchema](docs/TransportCreateBookingPaymentSchema.md)
 - [TransportCreateBookingRequestSchema](docs/TransportCreateBookingRequestSchema.md)
 - [TransportGetOfferAvailabilityRequest](docs/TransportGetOfferAvailabilityRequest.md)
 - [TransportGetOfferAvailabilityResponse](docs/TransportGetOfferAvailabilityResponse.md)
 - [TransportOfferDetailsRequestSchema](docs/TransportOfferDetailsRequestSchema.md)
 - [TransportOfferDetailsSchema](docs/TransportOfferDetailsSchema.md)
 - [TransportOfferRequestSchema](docs/TransportOfferRequestSchema.md)
 - [TransportOfferResponseItemSchema](docs/TransportOfferResponseItemSchema.md)
 - [TransportOfferResponseSchema](docs/TransportOfferResponseSchema.md)
 - [UploadBody](docs/UploadBody.md)
 - [User](docs/User.md)
 - [UsersBody](docs/UsersBody.md)
 - [UsersUserIdBody](docs/UsersUserIdBody.md)

## Documentation For Authorization

## apiKeyAuth
- **Type**: API key 

Example
```golang
auth := context.WithValue(context.Background(), sw.ContextAPIKey, sw.APIKey{
	Key: "APIKEY",
	Prefix: "Bearer", // Omit if not necessary.
})
r, err := client.Service.Operation(auth, args)
```
## bearerAuth

## Author


