/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type FlightPassengerOfferRequestSchema struct {
	// Type of passenger (adult, child, infant, infant with seat).
	Type_ string `json:"type,omitempty"`
	// Age of the passenger.
	Age int32 `json:"age,omitempty"`
	// First name of the passenger.
	FirstName string `json:"first_name,omitempty"`
	// Last name of the passenger.
	LastName string `json:"last_name,omitempty"`
	// Airline of the loyalty program.
	LoyaltyAirline string `json:"loyalty_airline,omitempty"`
	// Loyalty program membership number.
	LoyaltyNumber string `json:"loyalty_number,omitempty"`
}
