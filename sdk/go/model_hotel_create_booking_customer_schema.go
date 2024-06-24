/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type HotelCreateBookingCustomerSchema struct {
	// First name of the customer.
	FirstName string `json:"first_name,omitempty"`
	// Last name of the customer.
	LastName string `json:"last_name,omitempty"`
	// Email address of the customer.
	Email string `json:"email,omitempty"`
	// Phone number prefix for international calls.
	PhonePrefix string `json:"phone_prefix,omitempty"`
	// Phone number of the customer.
	PhoneNumber string `json:"phone_number,omitempty"`
	// Country of the customer.
	Country string `json:"country,omitempty"`
}
