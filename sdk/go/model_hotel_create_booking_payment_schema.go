/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type HotelCreateBookingPaymentSchema struct {
	// Credit card number.
	CardNumber string `json:"card_number,omitempty"`
	// Month of card expiration.
	CardExpirationMonth int32 `json:"card_expiration_month,omitempty"`
	// Year of card expiration.
	CardExpirationYear int32 `json:"card_expiration_year,omitempty"`
	// Card security code.
	CardCvv string `json:"card_cvv,omitempty"`
	// Name on credit card.
	CardName string `json:"card_name,omitempty"`
	// Billing address for the card.
	BillingAddress string `json:"billing_address,omitempty"`
	// City of the billing address.
	BillingCity string `json:"billing_city,omitempty"`
	// State of the billing address.
	BillingState string `json:"billing_state,omitempty"`
	// Postal code of the billing address.
	BillingZip string `json:"billing_zip,omitempty"`
	// Country of the billing address.
	BillingCountry string `json:"billing_country,omitempty"`
}
