/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type FlightOfferRequestSchema struct {
	// Class options: first, business, premium economy, economy.
	Cabin *Array `json:"cabin,omitempty"`
	// Array of flight legs, each described in FlightLegOfferRequestSchema.
	Legs *Array `json:"legs,omitempty"`
	// Array of passengers, each described in FlightPassengerOfferRequestSchema.
	Passengers *Array `json:"passengers,omitempty"`
	// Array of codes for accessing special negotiated fares.
	PrivateFareCodes *Array `json:"private_fare_codes,omitempty"`
	// Keyword to filter offers.
	FilterByKeyword string `json:"filter_by_keyword,omitempty"`
	// Minimum price filter.
	FilterByPriceMin float32 `json:"filter_by_price_min,omitempty"`
	// Maximum price filter.
	FilterByPriceMax float32 `json:"filter_by_price_max,omitempty"`
	// Minimum flight duration filter.
	FilterByDurationMin int32 `json:"filter_by_duration_min,omitempty"`
	// Maximum flight duration filter.
	FilterByDurationMax int32 `json:"filter_by_duration_max,omitempty"`
	// Earliest departure time filter.
	FilterByDepartureTimeMin string `json:"filter_by_departure_time_min,omitempty"`
	// Latest departure time filter.
	FilterByDepartureTimeMax string `json:"filter_by_departure_time_max,omitempty"`
	// Earliest arrival time filter.
	FilterByArrivalTimeMin string `json:"filter_by_arrival_time_min,omitempty"`
	// Latest arrival time filter.
	FilterByArrivalTimeMax string `json:"filter_by_arrival_time_max,omitempty"`
	// Minimum number of stops filter.
	FilterByStopsMin int32 `json:"filter_by_stops_min,omitempty"`
	// Maximum number of stops filter.
	FilterByStopsMax int32 `json:"filter_by_stops_max,omitempty"`
	// List of airline filters.
	FilterByAirlines *Array `json:"filter_by_airlines,omitempty"`
	// List of airport filters.
	FilterByAirports *Array `json:"filter_by_airports,omitempty"`
	// Sorting criteria.
	SortBy string `json:"sort_by,omitempty"`
	// Sorting order, asc or desc.
	SortOrder string `json:"sort_order,omitempty"`
	// Pagination: page number.
	Page int32 `json:"page,omitempty"`
	// Pagination: maximum items per page.
	Limit int32 `json:"limit,omitempty"`
	// Language selection for offer details.
	Language string `json:"language,omitempty"`
	// Currency in which prices should be provided.
	Currency string `json:"currency,omitempty"`
}
