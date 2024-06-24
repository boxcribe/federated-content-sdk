# SwaggerClient::EventTicketSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ticket_id** | **String** | Unique identifier for the ticket. | [optional] 
**supplier_ticket_id** | **String** | Identifier for the ticket provided by the supplier. | [optional] 
**ticket_index** | [**BigDecimal**](BigDecimal.md) | Index number of the ticket for ordering. | [optional] 
**ticket_tax** | [**BigDecimal**](BigDecimal.md) | Applicable tax on the ticket price. | [optional] 
**ticket_price** | [**BigDecimal**](BigDecimal.md) | Price of the ticket. | [optional] 
**ticket_currency** | **String** | Currency in which the ticket is priced. | [optional] 
**ticket_cancellation_policies** | **String** | Policies regarding ticket cancellation. | [optional] 
**ticket_section** | **String** | Section of the venue where the seat is located. | [optional] 
**ticket_row** | **String** | Row of the section where the seat is located. | [optional] 
**ticket_seat** | **String** | Specific seat number. | [optional] 
**ticket_description** | **String** | Description of the ticket. | [optional] 
**ticket_delivery_options** | **Array&lt;String&gt;** | Available options for ticket delivery. | [optional] 
**ticket_quantities** | **Array&lt;Integer&gt;** | Quantities of tickets available for purchase. | [optional] 
**booking_questions** | **Array&lt;String&gt;** | Questions related to booking the event. | [optional] 

