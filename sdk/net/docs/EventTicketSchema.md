# IO.Swagger.Model.EventTicketSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TicketId** | **Guid?** | Unique identifier for the ticket. | [optional] 
**SupplierTicketId** | **Guid?** | Identifier for the ticket provided by the supplier. | [optional] 
**TicketIndex** | [**decimal?**](BigDecimal.md) | Index number of the ticket for ordering. | [optional] 
**TicketTax** | [**decimal?**](BigDecimal.md) | Applicable tax on the ticket price. | [optional] 
**TicketPrice** | [**decimal?**](BigDecimal.md) | Price of the ticket. | [optional] 
**TicketCurrency** | **string** | Currency in which the ticket is priced. | [optional] 
**TicketCancellationPolicies** | **string** | Policies regarding ticket cancellation. | [optional] 
**TicketSection** | **string** | Section of the venue where the seat is located. | [optional] 
**TicketRow** | **string** | Row of the section where the seat is located. | [optional] 
**TicketSeat** | **string** | Specific seat number. | [optional] 
**TicketDescription** | **string** | Description of the ticket. | [optional] 
**TicketDeliveryOptions** | **List&lt;string&gt;** | Available options for ticket delivery. | [optional] 
**TicketQuantities** | **List&lt;int?&gt;** | Quantities of tickets available for purchase. | [optional] 
**BookingQuestions** | **List&lt;string&gt;** | Questions related to booking the event. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

