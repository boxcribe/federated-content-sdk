# IO.Swagger.Model.TransportGetOfferAvailabilityResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfferId** | **Guid?** | Unique identifier of the offer. | [optional] 
**SupplierOfferId** | **Guid?** | Unique identifier for the supplier’s offer. | [optional] 
**OfferIndex** | **int?** | Index number of the offer. | [optional] 
**OfferTax** | **double?** | Applicable taxes on the offer. | [optional] 
**OfferPrice** | **double?** | Total price of the offer. | [optional] 
**OfferCurrency** | **string** | Currency of the offer. | [optional] 
**OfferCancelationPolicies** | **string** | Cancellation policies of the offer. | [optional] 
**PickupDate** | **DateTime?** | Date when the transport is scheduled to be picked up. | [optional] 
**PickupTime** | **string** | Time when the transport is scheduled to be picked up. | [optional] 
**Adults** | **int?** | Number of adults included in the transport offer. | [optional] 
**Children** | **int?** | Number of children included in the transport offer. | [optional] 
**ReturnDate** | **DateTime?** | Date when the transport is scheduled to be returned. | [optional] 
**ReturnTime** | **string** | Time when the transport is scheduled to be returned. | [optional] 
**TransportName** | **string** | Name of the transport provider or vehicle. | [optional] 
**TransportDescription** | **string** | Description of the transport. | [optional] 
**TransportAddress** | **string** | Address where the transport is located or where it operates. | [optional] 
**TransportLatitude** | **float?** | Latitude coordinate of the transport location. | [optional] 
**TransportLongitude** | **float?** | Longitude coordinate of the transport location. | [optional] 
**TransportDistance** | **double?** | Distance covered by the transport offer. | [optional] 
**TransportDistanceMetric** | **string** | Metric unit for transport distance (e.g., kilometers, miles). | [optional] 
**TransportImages** | **List&lt;string&gt;** | Collection of images of the transport. | [optional] 
**TransportRating** | **double?** | Rating of the transport. | [optional] 
**TransportReviews** | **List&lt;Object&gt;** | Reviews for the transport. | [optional] 
**TransportType** | **string** | Type of transport (e.g., car, van, scooter). | [optional] 
**TransportClass** | **string** | Class of the transport (e.g., economy, luxury). | [optional] 
**TransportCompany** | **string** | Company providing the transport. | [optional] 
**TransportCompanyLogo** | **string** | Logo of the company providing the transport. | [optional] 
**TransportPassengersNumber** | **int?** | Number of passengers the transport can accommodate. | [optional] 
**TransportBagsNumber** | **int?** | Number of bags the transport can accommodate. | [optional] 
**TransportAmenities** | **List&lt;string&gt;** | List of amenities provided with the transport. | [optional] 
**BookingQuestions** | **List&lt;Object&gt;** | Questions related to booking the transport. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

