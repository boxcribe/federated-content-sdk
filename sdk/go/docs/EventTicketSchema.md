# EventTicketSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TicketId** | **string** | Unique identifier for the ticket. | [optional] [default to null]
**SupplierTicketId** | **string** | Identifier for the ticket provided by the supplier. | [optional] [default to null]
**TicketIndex** | **float64** | Index number of the ticket for ordering. | [optional] [default to null]
**TicketTax** | **float64** | Applicable tax on the ticket price. | [optional] [default to null]
**TicketPrice** | **float64** | Price of the ticket. | [optional] [default to null]
**TicketCurrency** | **string** | Currency in which the ticket is priced. | [optional] [default to null]
**TicketCancellationPolicies** | **string** | Policies regarding ticket cancellation. | [optional] [default to null]
**TicketSection** | **string** | Section of the venue where the seat is located. | [optional] [default to null]
**TicketRow** | **string** | Row of the section where the seat is located. | [optional] [default to null]
**TicketSeat** | **string** | Specific seat number. | [optional] [default to null]
**TicketDescription** | **string** | Description of the ticket. | [optional] [default to null]
**TicketDeliveryOptions** | **[]string** | Available options for ticket delivery. | [optional] [default to null]
**TicketQuantities** | **[]int32** | Quantities of tickets available for purchase. | [optional] [default to null]
**BookingQuestions** | **[]string** | Questions related to booking the event. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

