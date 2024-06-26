/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type EventGetOfferAvailabilityRequest struct {
	// Unique identifier of the event offer.
	OfferId string `json:"offer_id,omitempty"`
	// Date of the tour.
	Date string `json:"date,omitempty"`
}
