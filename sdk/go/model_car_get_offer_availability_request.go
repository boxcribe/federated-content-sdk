/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type CarGetOfferAvailabilityRequest struct {
	// Unique identifier of the car offer.
	OfferId string `json:"offer_id,omitempty"`
	// Scheduled date for car pickup.
	PickupDate string `json:"pickup_date,omitempty"`
	// Scheduled time for car pickup.
	PickupTime string `json:"pickup_time,omitempty"`
	// Scheduled date for car dropoff.
	DropoffDate string `json:"dropoff_date,omitempty"`
	// Scheduled time for car dropoff.
	DropoffTime string `json:"dropoff_time,omitempty"`
}
