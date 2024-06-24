# EventTicketSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ticket_id** | **str** | Unique identifier for the ticket. | [optional] 
**supplier_ticket_id** | **str** | Identifier for the ticket provided by the supplier. | [optional] 
**ticket_index** | **float** | Index number of the ticket for ordering. | [optional] 
**ticket_tax** | **float** | Applicable tax on the ticket price. | [optional] 
**ticket_price** | **float** | Price of the ticket. | [optional] 
**ticket_currency** | **str** | Currency in which the ticket is priced. | [optional] 
**ticket_cancellation_policies** | **str** | Policies regarding ticket cancellation. | [optional] 
**ticket_section** | **str** | Section of the venue where the seat is located. | [optional] 
**ticket_row** | **str** | Row of the section where the seat is located. | [optional] 
**ticket_seat** | **str** | Specific seat number. | [optional] 
**ticket_description** | **str** | Description of the ticket. | [optional] 
**ticket_delivery_options** | **list[str]** | Available options for ticket delivery. | [optional] 
**ticket_quantities** | **list[int]** | Quantities of tickets available for purchase. | [optional] 
**booking_questions** | **list[str]** | Questions related to booking the event. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

