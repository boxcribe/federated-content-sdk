/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

// Offer Request Normalized Boxcribe API Response
type OfferResultNormalizedResponse struct {
	Ids string `json:"ids,omitempty"`
	Category string `json:"category,omitempty"`
	Index int32 `json:"index,omitempty"`
	Name string `json:"name,omitempty"`
	Description string `json:"description,omitempty"`
	Address string `json:"address,omitempty"`
	Latitude float64 `json:"latitude,omitempty"`
	Longitude float64 `json:"longitude,omitempty"`
	Distance float64 `json:"distance,omitempty"`
	DistanceUnitOfMeasure string `json:"distanceUnitOfMeasure,omitempty"`
	Pictures []string `json:"pictures,omitempty"`
	Tax float64 `json:"tax,omitempty"`
	Price float64 `json:"price,omitempty"`
	Currency string `json:"currency,omitempty"`
	PriceDescription string `json:"priceDescription,omitempty"`
	FreeCancellation bool `json:"freeCancellation,omitempty"`
	Rating float64 `json:"rating,omitempty"`
	Status string `json:"status,omitempty"`
	OhterAttributes *interface{} `json:"ohter_attributes,omitempty"`
	OfferRooms *Array `json:"offer_rooms,omitempty"`
	OfferVariants *Array `json:"offer_variants,omitempty"`
}
