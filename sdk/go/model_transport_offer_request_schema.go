/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type TransportOfferRequestSchema struct {
	// Latitude for the pickup location.
	PickupLocationLatitude float32 `json:"pickup_location_latitude,omitempty"`
	// Longitude for the pickup location.
	PickupLocationLongitude float32 `json:"pickup_location_longitude,omitempty"`
	// Date of the pickup.
	PickupDate string `json:"pickup_date,omitempty"`
	// Time of the pickup.
	PickupTime string `json:"pickup_time,omitempty"`
	// Number of adults.
	Adults int32 `json:"adults,omitempty"`
	// Number of children.
	Children int32 `json:"children,omitempty"`
	// Latitude for the return location.
	ReturnLocationLatitude float32 `json:"return_location_latitude,omitempty"`
	// Longitude for the return location.
	ReturnLocationLongitude float32 `json:"return_location_longitude,omitempty"`
	// Date of the return.
	ReturnDate string `json:"return_date,omitempty"`
	// Time of the return.
	ReturnTime string `json:"return_time,omitempty"`
	// Keyword filter.
	FilterByKeyword string `json:"filter_by_keyword,omitempty"`
	// Minimum price filter.
	FilterByPriceMin float64 `json:"filter_by_price_min,omitempty"`
	// Maximum price filter.
	FilterByPriceMax float64 `json:"filter_by_price_max,omitempty"`
	// Minimum distance filter.
	FilterByDistanceMin int32 `json:"filter_by_distance_min,omitempty"`
	// Maximum distance filter.
	FilterByDistanceMax int32 `json:"filter_by_distance_max,omitempty"`
	// Minimum rating filter.
	FilterByRatingMin int32 `json:"filter_by_rating_min,omitempty"`
	// Maximum rating filter.
	FilterByRatingMax int32 `json:"filter_by_rating_max,omitempty"`
	// Filter by star rating.
	FilterByStars []string `json:"filter_by_stars,omitempty"`
	// Facilities filter.
	FilterByFacilities []string `json:"filter_by_facilities,omitempty"`
	// Amenities filter.
	FilterByAmenities []string `json:"filter_by_amenities,omitempty"`
	// Minimum passengers filter.
	FilterByPassengersMin int32 `json:"filter_by_passengers_min,omitempty"`
	// Maximum passengers filter.
	FilterByPassengersMax int32 `json:"filter_by_passengers_max,omitempty"`
	// Minimum bags filter.
	FilterByBagsMin int32 `json:"filter_by_bags_min,omitempty"`
	// Maximum bags filter.
	FilterByBagsMax int32 `json:"filter_by_bags_max,omitempty"`
	// Type filter.
	FilterByType []string `json:"filter_by_type,omitempty"`
	// Company filter.
	FilterByCompany []string `json:"filter_by_company,omitempty"`
	// Class filter.
	FilterByClass []string `json:"filter_by_class,omitempty"`
	// Sorting parameter.
	SortBy string `json:"sort_by,omitempty"`
	// Sort order (asc/desc).
	SortOrder string `json:"sort_order,omitempty"`
	// Page number for pagination.
	Page int32 `json:"page,omitempty"`
	// Limit of results per page.
	Limit int32 `json:"limit,omitempty"`
	// Language for the results.
	Language string `json:"language,omitempty"`
	// Currency for pricing.
	Currency string `json:"currency,omitempty"`
	// Unit of measurement for distances.
	Metric string `json:"metric,omitempty"`
}
