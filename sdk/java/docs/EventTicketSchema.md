# EventTicketSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ticketId** | [**UUID**](UUID.md) | Unique identifier for the ticket. |  [optional]
**supplierTicketId** | [**UUID**](UUID.md) | Identifier for the ticket provided by the supplier. |  [optional]
**ticketIndex** | [**BigDecimal**](BigDecimal.md) | Index number of the ticket for ordering. |  [optional]
**ticketTax** | [**BigDecimal**](BigDecimal.md) | Applicable tax on the ticket price. |  [optional]
**ticketPrice** | [**BigDecimal**](BigDecimal.md) | Price of the ticket. |  [optional]
**ticketCurrency** | **String** | Currency in which the ticket is priced. |  [optional]
**ticketCancellationPolicies** | **String** | Policies regarding ticket cancellation. |  [optional]
**ticketSection** | **String** | Section of the venue where the seat is located. |  [optional]
**ticketRow** | **String** | Row of the section where the seat is located. |  [optional]
**ticketSeat** | **String** | Specific seat number. |  [optional]
**ticketDescription** | **String** | Description of the ticket. |  [optional]
**ticketDeliveryOptions** | **List&lt;String&gt;** | Available options for ticket delivery. |  [optional]
**ticketQuantities** | **List&lt;Integer&gt;** | Quantities of tickets available for purchase. |  [optional]
**bookingQuestions** | **List&lt;String&gt;** | Questions related to booking the event. |  [optional]
