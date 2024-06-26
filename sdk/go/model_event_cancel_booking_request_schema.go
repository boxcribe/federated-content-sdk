/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type EventCancelBookingRequestSchema struct {
	// Identifier of the booking to be canceled.
	BookingId string `json:"booking_id,omitempty"`
	// Reason provided for the cancellation.
	CancelationReason string `json:"cancelation_reason,omitempty"`
}
