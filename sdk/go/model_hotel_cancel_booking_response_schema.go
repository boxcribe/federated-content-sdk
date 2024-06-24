/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type HotelCancelBookingResponseSchema struct {
	// Identifier for the company associated with the booking.
	CompanyId string `json:"company_id,omitempty"`
	// Identifier for the tenant associated with the booking.
	TenantId string `json:"tenant_id,omitempty"`
	// Identifier for the category of the booking.
	CategoryId string `json:"category_id,omitempty"`
	// Identifier for the supplier of the booking.
	SupplierId string `json:"supplier_id,omitempty"`
	// Unique identifier for the booking.
	BookingId string `json:"booking_id,omitempty"`
	// Supplier’s identifier for the booking.
	SupplierBookingId string `json:"supplier_booking_id,omitempty"`
	// Reference number provided by the supplier for the booking.
	SupplierBookingReference string `json:"supplier_booking_reference,omitempty"`
	// Customer reference number associated with the booking.
	CustomerReference string `json:"customer_reference,omitempty"`
	// Internal reference number for the booking.
	BookingReference string `json:"booking_reference,omitempty"`
	// Reference number for the payment associated with the booking.
	PaymentReference string `json:"payment_reference,omitempty"`
	// Current status of the booking.
	BookingStatus string `json:"booking_status,omitempty"`
	// Tax applied to the booking.
	BookingTax float64 `json:"booking_tax,omitempty"`
	// Total price of the booking.
	BookingPrice float64 `json:"booking_price,omitempty"`
	// Currency used for the booking pricing.
	BookingCurrency string `json:"booking_currency,omitempty"`
	// Cancellation policies applicable to the booking.
	BookingCancelationPolicies string `json:"booking_cancelation_policies,omitempty"`
	Customer *HotelBookingCustomerSchema `json:"customer,omitempty"`
	OfferRequest *HotelOfferRequestSchema `json:"offer_request,omitempty"`
	Offer *HotelOfferResponseItemSchema `json:"offer,omitempty"`
	Room *HotelRoomSchema `json:"room,omitempty"`
	// Number of rooms of this type being booked.
	RoomQty int32 `json:"room_qty,omitempty"`
	// Indicates if the booking was successful.
	Success bool `json:"success,omitempty"`
	// Provides details on any error that occurred during the booking process.
	ErrorMessage string `json:"error_message,omitempty"`
}
