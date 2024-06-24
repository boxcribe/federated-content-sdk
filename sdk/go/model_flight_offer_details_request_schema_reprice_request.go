/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type FlightOfferDetailsRequestSchemaRepriceRequest struct {
	// Unique identifier of the flight offer to be repriced.
	OfferId string `json:"offer_id,omitempty"`
	// Array of passenger seats, each defined in OfferPassengerSelectedSeatSchema.
	Seats []OfferPassengerSelectedSeatSchema `json:"seats,omitempty"`
	// Array of extra baggage, each defined in OfferPassengerExtraBagSchema.
	Bags []OfferPassengerExtraBagSchema `json:"bags,omitempty"`
}