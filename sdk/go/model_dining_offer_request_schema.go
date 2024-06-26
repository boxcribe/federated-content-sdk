/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type DiningOfferRequestSchema struct {
	// Latitude for the event location.
	LocationLatitude float32 `json:"location_latitude,omitempty"`
	// Longitude for the event location.
	LocationLongitude float32 `json:"location_longitude,omitempty"`
	// Radius to search for events around the location coordinates.
	LocationRadius float32 `json:"location_radius,omitempty"`
	// Date for the dining search.
	Date string `json:"date,omitempty"`
	// Keywords to filter the events.
	FilterByKeyword string `json:"filter_by_keyword,omitempty"`
	// Minimum price to filter the events.
	FilterByPriceMin float64 `json:"filter_by_price_min,omitempty"`
	// Maximum price to filter the events.
	FilterByPriceMax float64 `json:"filter_by_price_max,omitempty"`
	// Minimum distance to filter events.
	FilterByDistanceMin float64 `json:"filter_by_distance_min,omitempty"`
	// Maximum distance to filter events.
	FilterByDistanceMax float64 `json:"filter_by_distance_max,omitempty"`
	// Minimum rating to filter events.
	FilterByRatingMin float64 `json:"filter_by_rating_min,omitempty"`
	// Maximum rating to filter events.
	FilterByRatingMax float64 `json:"filter_by_rating_max,omitempty"`
	// Filter events by specific subcategories.
	FilterBySubcategories []string `json:"filter_by_subcategories,omitempty"`
	// Field to sort events by.
	SortBy string `json:"sort_by,omitempty"`
	// Order to sort events (asc, desc).
	SortOrder string `json:"sort_order,omitempty"`
	// Page number for pagination.
	Page float64 `json:"page,omitempty"`
	// Number of events per page.
	Limit float64 `json:"limit,omitempty"`
	// Language for the event offers.
	Language string `json:"language,omitempty"`
	// Currency for the event offers.
	Currency string `json:"currency,omitempty"`
	// Distance metric (mi/km) used in filters.
	Metric string `json:"metric,omitempty"`
}
