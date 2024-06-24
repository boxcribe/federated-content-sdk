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

import { ToursAndActivitiesBookingCustomerSchema } from './tours-and-activities-booking-customer-schema';
import { ToursAndActivitiesOfferRequestSchema } from './tours-and-activities-offer-request-schema';
import { ToursAndActivitiesOfferResponseItemSchema } from './tours-and-activities-offer-response-item-schema';
import { ToursAndActivitiesVariantSchema } from './tours-and-activities-variant-schema';
 /**
 * 
 *
 * @export
 * @interface ToursAndActivitiesBookingDetailsResponseSchema
 */
export interface ToursAndActivitiesBookingDetailsResponseSchema {

    /**
     * Identifier for the company associated with the booking.
     *
     * @type {string}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    companyId?: string;

    /**
     * Identifier for the tenant associated with the booking.
     *
     * @type {string}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    tenantId?: string;

    /**
     * Identifier for the category of the booking.
     *
     * @type {string}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    categoryId?: string;

    /**
     * Identifier for the supplier of the booking.
     *
     * @type {string}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    supplierId?: string;

    /**
     * Unique identifier for the booking.
     *
     * @type {string}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    bookingId?: string;

    /**
     * Supplier’s identifier for the booking.
     *
     * @type {string}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    supplierBookingId?: string;

    /**
     * Reference number provided by the supplier for the booking.
     *
     * @type {string}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    supplierBookingReference?: string;

    /**
     * Customer reference number associated with the booking.
     *
     * @type {string}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    customerReference?: string;

    /**
     * Internal reference number for the booking.
     *
     * @type {string}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    bookingReference?: string;

    /**
     * Reference number for the payment associated with the booking.
     *
     * @type {string}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    paymentReference?: string;

    /**
     * Current status of the booking.
     *
     * @type {string}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    bookingStatus?: string;

    /**
     * Tax applied to the booking.
     *
     * @type {number}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    bookingTax?: number;

    /**
     * Total price of the booking.
     *
     * @type {number}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    bookingPrice?: number;

    /**
     * Currency used for the booking pricing.
     *
     * @type {string}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    bookingCurrency?: string;

    /**
     * Cancellation policies applicable to the booking.
     *
     * @type {string}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    bookingCancelationPolicies?: string;

    /**
     * @type {any}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    customer?: any;

    /**
     * @type {any}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    offerRequest?: any;

    /**
     * @type {any}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    offer?: any;

    /**
     * @type {any}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    variant?: any;

    /**
     * Indicates if the booking was successful.
     *
     * @type {boolean}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    success?: boolean;

    /**
     * Provides details on any error that occurred during the booking process.
     *
     * @type {string}
     * @memberof ToursAndActivitiesBookingDetailsResponseSchema
     */
    errorMessage?: string;
}