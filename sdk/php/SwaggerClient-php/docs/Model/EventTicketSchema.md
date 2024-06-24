# EventTicketSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ticket_id** | **string** | Unique identifier for the ticket. | [optional] 
**supplier_ticket_id** | **string** | Identifier for the ticket provided by the supplier. | [optional] 
**ticket_index** | **float** | Index number of the ticket for ordering. | [optional] 
**ticket_tax** | **float** | Applicable tax on the ticket price. | [optional] 
**ticket_price** | **float** | Price of the ticket. | [optional] 
**ticket_currency** | **string** | Currency in which the ticket is priced. | [optional] 
**ticket_cancellation_policies** | **string** | Policies regarding ticket cancellation. | [optional] 
**ticket_section** | **string** | Section of the venue where the seat is located. | [optional] 
**ticket_row** | **string** | Row of the section where the seat is located. | [optional] 
**ticket_seat** | **string** | Specific seat number. | [optional] 
**ticket_description** | **string** | Description of the ticket. | [optional] 
**ticket_delivery_options** | **string[]** | Available options for ticket delivery. | [optional] 
**ticket_quantities** | **int[]** | Quantities of tickets available for purchase. | [optional] 
**booking_questions** | **string[]** | Questions related to booking the event. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

