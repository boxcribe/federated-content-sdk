/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type HotelOfferRequestSchema struct {
	// Latitude of the hotel location.
	LocationLatitude float32 `json:"location_latitude,omitempty"`
	// Longitude of the hotel location.
	LocationLongitude float32 `json:"location_longitude,omitempty"`
	// Search radius from the specified location.
	LocationRadius float32 `json:"location_radius,omitempty"`
	// Check-in date for the hotel booking.
	CheckinDate string `json:"checkin_date,omitempty"`
	// Check-out date for the hotel booking.
	CheckoutDate string `json:"checkout_date,omitempty"`
	// Details of rooms including number of adults and children per room.
	Rooms []HotelOfferRequestSchemaRooms `json:"rooms,omitempty"`
	// Keyword to filter hotel offers.
	FilterByKeyword string `json:"filter_by_keyword,omitempty"`
	// Minimum price filter for hotel offers.
	FilterByPriceMin float64 `json:"filter_by_price_min,omitempty"`
	// Maximum price filter for hotel offers.
	FilterByPriceMax float64 `json:"filter_by_price_max,omitempty"`
	// Minimum distance filter for hotel location.
	FilterByDistanceMin float32 `json:"filter_by_distance_min,omitempty"`
	// Maximum distance filter for hotel location.
	FilterByDistanceMax float32 `json:"filter_by_distance_max,omitempty"`
	// Minimum rating filter for hotels.
	FilterByRatingMin float32 `json:"filter_by_rating_min,omitempty"`
	// Maximum rating filter for hotels.
	FilterByRatingMax float32 `json:"filter_by_rating_max,omitempty"`
	// Filter hotels by star ratings.
	FilterByStars []int32 `json:"filter_by_stars,omitempty"`
	// Filter hotels by available facilities.
	FilterByFacilities []string `json:"filter_by_facilities,omitempty"`
	// Filter hotels by available amenities.
	FilterByAmenities []string `json:"filter_by_amenities,omitempty"`
	// Field to sort the results by.
	SortBy string `json:"sort_by,omitempty"`
	// Order to sort the results, either asc or desc.
	SortOrder string `json:"sort_order,omitempty"`
	// Page number for pagination.
	Page int32 `json:"page,omitempty"`
	// Number of items per page for pagination.
	Limit int32 `json:"limit,omitempty"`
	// Preferred language of the hotel information.
	Language string `json:"language,omitempty"`
	// Currency in which prices should be displayed.
	Currency string `json:"currency,omitempty"`
	// Unit of measure for distance, either miles (mi) or kilometers (km).
	Metric string `json:"metric,omitempty"`
}
