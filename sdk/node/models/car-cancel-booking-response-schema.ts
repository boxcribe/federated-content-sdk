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

import { CarBookingCustomerSchema } from './car-booking-customer-schema';
import { CarOfferRequestSchema } from './car-offer-request-schema';
import { CarOfferResponseItemSchema } from './car-offer-response-item-schema';
 /**
 * 
 *
 * @export
 * @interface CarCancelBookingResponseSchema
 */
export interface CarCancelBookingResponseSchema {

    /**
     * Identifier for the company associated with the booking.
     *
     * @type {string}
     * @memberof CarCancelBookingResponseSchema
     */
    companyId?: string;

    /**
     * Identifier for the tenant associated with the booking.
     *
     * @type {string}
     * @memberof CarCancelBookingResponseSchema
     */
    tenantId?: string;

    /**
     * Identifier for the category of the booking.
     *
     * @type {string}
     * @memberof CarCancelBookingResponseSchema
     */
    categoryId?: string;

    /**
     * Identifier for the supplier of the booking.
     *
     * @type {string}
     * @memberof CarCancelBookingResponseSchema
     */
    supplierId?: string;

    /**
     * Unique identifier for the booking.
     *
     * @type {string}
     * @memberof CarCancelBookingResponseSchema
     */
    bookingId?: string;

    /**
     * Supplier’s identifier for the booking.
     *
     * @type {string}
     * @memberof CarCancelBookingResponseSchema
     */
    supplierBookingId?: string;

    /**
     * Reference number provided by the supplier for the booking.
     *
     * @type {string}
     * @memberof CarCancelBookingResponseSchema
     */
    supplierBookingReference?: string;

    /**
     * Customer reference number associated with the booking.
     *
     * @type {string}
     * @memberof CarCancelBookingResponseSchema
     */
    customerReference?: string;

    /**
     * Internal reference number for the booking.
     *
     * @type {string}
     * @memberof CarCancelBookingResponseSchema
     */
    bookingReference?: string;

    /**
     * Reference number for the payment associated with the booking.
     *
     * @type {string}
     * @memberof CarCancelBookingResponseSchema
     */
    paymentReference?: string;

    /**
     * Current status of the booking.
     *
     * @type {string}
     * @memberof CarCancelBookingResponseSchema
     */
    bookingStatus?: string;

    /**
     * Tax applied to the booking.
     *
     * @type {number}
     * @memberof CarCancelBookingResponseSchema
     */
    bookingTax?: number;

    /**
     * Total price of the booking.
     *
     * @type {number}
     * @memberof CarCancelBookingResponseSchema
     */
    bookingPrice?: number;

    /**
     * Currency used for the booking pricing.
     *
     * @type {string}
     * @memberof CarCancelBookingResponseSchema
     */
    bookingCurrency?: string;

    /**
     * Cancellation policies applicable to the booking.
     *
     * @type {string}
     * @memberof CarCancelBookingResponseSchema
     */
    bookingCancelationPolicies?: string;

    /**
     * @type {any}
     * @memberof CarCancelBookingResponseSchema
     */
    customer?: any;

    /**
     * @type {any}
     * @memberof CarCancelBookingResponseSchema
     */
    offerRequest?: any;

    /**
     * @type {any}
     * @memberof CarCancelBookingResponseSchema
     */
    offer?: any;

    /**
     * Indicates if the booking was successful.
     *
     * @type {boolean}
     * @memberof CarCancelBookingResponseSchema
     */
    success?: boolean;

    /**
     * Provides details on any error that occurred during the booking process.
     *
     * @type {string}
     * @memberof CarCancelBookingResponseSchema
     */
    errorMessage?: string;
}