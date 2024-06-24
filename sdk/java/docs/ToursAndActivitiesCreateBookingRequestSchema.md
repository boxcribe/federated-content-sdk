# ToursAndActivitiesCreateBookingRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offerId** | [**UUID**](UUID.md) | Unique identifier for the offer. |  [optional]
**variantId** | [**UUID**](UUID.md) | Unique identifier for the variant. |  [optional]
**customer** | [**ToursAndActivitiesCreateBookingCustomerSchema**](ToursAndActivitiesCreateBookingCustomerSchema.md) |  |  [optional]
**payment** | [**ToursAndActivitiesCreateBookingPaymentSchema**](ToursAndActivitiesCreateBookingPaymentSchema.md) |  |  [optional]
**currency** | **String** | Currency used for the booking. |  [optional]
**customerReference** | **String** | Customer reference identifier. |  [optional]
**bookingReference** | **String** | Booking reference identifier. |  [optional]
**paymentReference** | **String** | Payment transaction reference. |  [optional]
**bookingQuestions** | **List&lt;String&gt;** | Questions related to booking the tour variant. |  [optional]
