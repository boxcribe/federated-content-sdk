/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type HotelCreateBookingRequestSchema struct {
	// Unique identifier for the hotel offer.
	OfferId string `json:"offer_id,omitempty"`
	// Identifier for the specific room being booked.
	RoomId string `json:"room_id,omitempty"`
	// Number of rooms of this type being booked.
	RoomQty int32 `json:"room_qty,omitempty"`
	Customer *HotelCreateBookingCustomerSchema `json:"customer,omitempty"`
	Payment *HotelCreateBookingPaymentSchema `json:"payment,omitempty"`
	// Currency used for the booking.
	Currency string `json:"currency,omitempty"`
	// Customer reference identifier.
	CustomerReference string `json:"customer_reference,omitempty"`
	// Booking reference identifier.
	BookingReference string `json:"booking_reference,omitempty"`
	// Payment transaction reference.
	PaymentReference string `json:"payment_reference,omitempty"`
}
