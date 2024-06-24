# ToursAndActivitiesBookingResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**company_id** | **str** | Identifier for the company associated with the booking. | [optional] 
**tenant_id** | **str** | Identifier for the tenant associated with the booking. | [optional] 
**category_id** | **str** | Identifier for the category of the booking. | [optional] 
**supplier_id** | **str** | Identifier for the supplier of the booking. | [optional] 
**booking_id** | **str** | Unique identifier for the booking. | [optional] 
**supplier_booking_id** | **str** | Supplier’s identifier for the booking. | [optional] 
**supplier_booking_reference** | **str** | Reference number provided by the supplier for the booking. | [optional] 
**customer_reference** | **str** | Customer reference number associated with the booking. | [optional] 
**booking_reference** | **str** | Internal reference number for the booking. | [optional] 
**payment_reference** | **str** | Reference number for the payment associated with the booking. | [optional] 
**booking_status** | **str** | Current status of the booking. | [optional] 
**booking_tax** | **float** | Tax applied to the booking. | [optional] 
**booking_price** | **float** | Total price of the booking. | [optional] 
**booking_currency** | **str** | Currency used for the booking pricing. | [optional] 
**booking_cancelation_policies** | **str** | Cancellation policies applicable to the booking. | [optional] 
**customer** | [**ToursAndActivitiesBookingCustomerSchema**](ToursAndActivitiesBookingCustomerSchema.md) |  | [optional] 
**offer_request** | [**ToursAndActivitiesOfferRequestSchema**](ToursAndActivitiesOfferRequestSchema.md) |  | [optional] 
**offer** | [**ToursAndActivitiesOfferResponseItemSchema**](ToursAndActivitiesOfferResponseItemSchema.md) |  | [optional] 
**variant** | [**ToursAndActivitiesVariantSchema**](ToursAndActivitiesVariantSchema.md) |  | [optional] 
**success** | **bool** | Indicates if the booking was successful. | [optional] 
**error_message** | **str** | Provides details on any error that occurred during the booking process. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

