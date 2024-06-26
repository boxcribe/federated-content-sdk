/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type EventCreateBookingRequestSchema struct {
	// Unique identifier for the offer.
	OfferId string `json:"offer_id,omitempty"`
	// Unique identifier for the ticket.
	TicketId string `json:"ticket_id,omitempty"`
	// Ticket quantity for ordering.
	TicketQty float64 `json:"ticket_qty,omitempty"`
	Customer *EventCreateBookingCustomerSchema `json:"customer,omitempty"`
	Payment *EventCreateBookingPaymentSchema `json:"payment,omitempty"`
	// Currency used for the booking.
	Currency string `json:"currency,omitempty"`
	// Customer reference identifier.
	CustomerReference string `json:"customer_reference,omitempty"`
	// Booking reference identifier.
	BookingReference string `json:"booking_reference,omitempty"`
	// Payment transaction reference.
	PaymentReference string `json:"payment_reference,omitempty"`
	// Questions related to booking the tour variant.
	BookingQuestions []string `json:"booking_questions,omitempty"`
}
