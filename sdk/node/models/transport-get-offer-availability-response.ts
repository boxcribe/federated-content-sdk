/* tslint:disable */
/* eslint-disable */
/**
 * Federated Content API
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

 /**
 * 
 *
 * @export
 * @interface TransportGetOfferAvailabilityResponse
 */
export interface TransportGetOfferAvailabilityResponse {

    /**
     * Unique identifier of the offer.
     *
     * @type {string}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    offerId?: string;

    /**
     * Unique identifier for the supplier’s offer.
     *
     * @type {string}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    supplierOfferId?: string;

    /**
     * Index number of the offer.
     *
     * @type {number}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    offerIndex?: number;

    /**
     * Applicable taxes on the offer.
     *
     * @type {number}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    offerTax?: number;

    /**
     * Total price of the offer.
     *
     * @type {number}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    offerPrice?: number;

    /**
     * Currency of the offer.
     *
     * @type {string}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    offerCurrency?: string;

    /**
     * Cancellation policies of the offer.
     *
     * @type {string}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    offerCancelationPolicies?: string;

    /**
     * Date when the transport is scheduled to be picked up.
     *
     * @type {string}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    pickupDate?: string;

    /**
     * Time when the transport is scheduled to be picked up.
     *
     * @type {string}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    pickupTime?: string;

    /**
     * Number of adults included in the transport offer.
     *
     * @type {number}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    adults?: number;

    /**
     * Number of children included in the transport offer.
     *
     * @type {number}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    children?: number;

    /**
     * Date when the transport is scheduled to be returned.
     *
     * @type {string}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    returnDate?: string;

    /**
     * Time when the transport is scheduled to be returned.
     *
     * @type {string}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    returnTime?: string;

    /**
     * Name of the transport provider or vehicle.
     *
     * @type {string}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    transportName?: string;

    /**
     * Description of the transport.
     *
     * @type {string}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    transportDescription?: string;

    /**
     * Address where the transport is located or where it operates.
     *
     * @type {string}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    transportAddress?: string;

    /**
     * Latitude coordinate of the transport location.
     *
     * @type {number}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    transportLatitude?: number;

    /**
     * Longitude coordinate of the transport location.
     *
     * @type {number}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    transportLongitude?: number;

    /**
     * Distance covered by the transport offer.
     *
     * @type {number}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    transportDistance?: number;

    /**
     * Metric unit for transport distance (e.g., kilometers, miles).
     *
     * @type {string}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    transportDistanceMetric?: string;

    /**
     * Collection of images of the transport.
     *
     * @type {Array<string>}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    transportImages?: Array<string>;

    /**
     * Rating of the transport.
     *
     * @type {number}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    transportRating?: number;

    /**
     * Reviews for the transport.
     *
     * @type {Array<any>}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    transportReviews?: Array<any>;

    /**
     * Type of transport (e.g., car, van, scooter).
     *
     * @type {string}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    transportType?: string;

    /**
     * Class of the transport (e.g., economy, luxury).
     *
     * @type {string}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    transportClass?: string;

    /**
     * Company providing the transport.
     *
     * @type {string}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    transportCompany?: string;

    /**
     * Logo of the company providing the transport.
     *
     * @type {string}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    transportCompanyLogo?: string;

    /**
     * Number of passengers the transport can accommodate.
     *
     * @type {number}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    transportPassengersNumber?: number;

    /**
     * Number of bags the transport can accommodate.
     *
     * @type {number}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    transportBagsNumber?: number;

    /**
     * List of amenities provided with the transport.
     *
     * @type {Array<string>}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    transportAmenities?: Array<string>;

    /**
     * Questions related to booking the transport.
     *
     * @type {Array<any>}
     * @memberof TransportGetOfferAvailabilityResponse
     */
    bookingQuestions?: Array<any>;
}
