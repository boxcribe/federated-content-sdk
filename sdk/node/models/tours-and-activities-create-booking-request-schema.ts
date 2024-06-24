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

import { ToursAndActivitiesCreateBookingCustomerSchema } from './tours-and-activities-create-booking-customer-schema';
import { ToursAndActivitiesCreateBookingPaymentSchema } from './tours-and-activities-create-booking-payment-schema';
 /**
 * 
 *
 * @export
 * @interface ToursAndActivitiesCreateBookingRequestSchema
 */
export interface ToursAndActivitiesCreateBookingRequestSchema {

    /**
     * Unique identifier for the offer.
     *
     * @type {string}
     * @memberof ToursAndActivitiesCreateBookingRequestSchema
     */
    offerId?: string;

    /**
     * Unique identifier for the variant.
     *
     * @type {string}
     * @memberof ToursAndActivitiesCreateBookingRequestSchema
     */
    variantId?: string;

    /**
     * @type {any}
     * @memberof ToursAndActivitiesCreateBookingRequestSchema
     */
    customer?: any;

    /**
     * @type {any}
     * @memberof ToursAndActivitiesCreateBookingRequestSchema
     */
    payment?: any;

    /**
     * Currency used for the booking.
     *
     * @type {string}
     * @memberof ToursAndActivitiesCreateBookingRequestSchema
     */
    currency?: string;

    /**
     * Customer reference identifier.
     *
     * @type {string}
     * @memberof ToursAndActivitiesCreateBookingRequestSchema
     */
    customerReference?: string;

    /**
     * Booking reference identifier.
     *
     * @type {string}
     * @memberof ToursAndActivitiesCreateBookingRequestSchema
     */
    bookingReference?: string;

    /**
     * Payment transaction reference.
     *
     * @type {string}
     * @memberof ToursAndActivitiesCreateBookingRequestSchema
     */
    paymentReference?: string;

    /**
     * Questions related to booking the tour variant.
     *
     * @type {Array<string>}
     * @memberof ToursAndActivitiesCreateBookingRequestSchema
     */
    bookingQuestions?: Array<string>;
}
