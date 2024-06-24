/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type ToursAndActivitiesGetOfferAvailabilityResponse struct {
	// Identifier of the individual offer.
	OfferId string `json:"offer_id,omitempty"`
	// Identifier provided by the supplier for the offer.
	SupplierOfferId string `json:"supplier_offer_id,omitempty"`
	// Index of the offer for ordering.
	OfferIndex int32 `json:"offer_index,omitempty"`
	// Tax applied on the offer.
	OfferTax float64 `json:"offer_tax,omitempty"`
	// Price of the offer.
	OfferPrice float64 `json:"offer_price,omitempty"`
	// Currency of the offer price.
	OfferCurrency string `json:"offer_currency,omitempty"`
	// Cancellation policies applicable to the offer.
	OfferCancelationPolicies string `json:"offer_cancelation_policies,omitempty"`
	// Date of the tour.
	Date string `json:"date,omitempty"`
	// Number of adults attending.
	Adults int32 `json:"adults,omitempty"`
	// Number of children attending.
	Children int32 `json:"children,omitempty"`
	// Name of the tour.
	TourName string `json:"tour_name,omitempty"`
	// Description of the tour.
	TourDescription string `json:"tour_description,omitempty"`
	// Address where the tour will take place.
	TourAddress string `json:"tour_address,omitempty"`
	// Latitude for the tour location.
	TourLatitude float32 `json:"tour_latitude,omitempty"`
	// Longitude for the tour location.
	TourLongitude float32 `json:"tour_longitude,omitempty"`
	// Distance covered by the tour.
	TourDistance float32 `json:"tour_distance,omitempty"`
	// Metric for measuring distance (miles or kilometers).
	TourDistanceMetric string `json:"tour_distance_metric,omitempty"`
	// Array of images related to the tour.
	TourImages []string `json:"tour_images,omitempty"`
	// Rating of the tour.
	TourRating float32 `json:"tour_rating,omitempty"`
	// Array of reviews for the tour.
	TourReviews []string `json:"tour_reviews,omitempty"`
	// Subcategories of the tour.
	TourSubcategories []string `json:"tour_subcategories,omitempty"`
	// Questions related to booking the tour.
	BookingQuestions []string `json:"booking_questions,omitempty"`
	// Array of ToursAndActivitiesVariantSchema.
	Variants []ToursAndActivitiesVariantSchema `json:"variants,omitempty"`
}
