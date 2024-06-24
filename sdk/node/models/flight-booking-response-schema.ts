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

import { FlightBookingCustomerSchema } from './flight-booking-customer-schema';
import { FlightOfferRequestSchema } from './flight-offer-request-schema';
import { FlightOfferResponseItemSchema } from './flight-offer-response-item-schema';
 /**
 * 
 *
 * @export
 * @interface FlightBookingResponseSchema
 */
export interface FlightBookingResponseSchema {

    /**
     * Identifier for the company associated with the booking.
     *
     * @type {string}
     * @memberof FlightBookingResponseSchema
     */
    companyId?: string;

    /**
     * Identifier for the tenant associated with the booking.
     *
     * @type {string}
     * @memberof FlightBookingResponseSchema
     */
    tenantId?: string;

    /**
     * Identifier for the category of the booking.
     *
     * @type {string}
     * @memberof FlightBookingResponseSchema
     */
    categoryId?: string;

    /**
     * Identifier for the supplier of the booking.
     *
     * @type {string}
     * @memberof FlightBookingResponseSchema
     */
    supplierId?: string;

    /**
     * Unique identifier for the booking.
     *
     * @type {string}
     * @memberof FlightBookingResponseSchema
     */
    bookingId?: string;

    /**
     * Supplier’s identifier for the booking.
     *
     * @type {string}
     * @memberof FlightBookingResponseSchema
     */
    supplierBookingId?: string;

    /**
     * Reference number provided by the supplier for the booking.
     *
     * @type {string}
     * @memberof FlightBookingResponseSchema
     */
    supplierBookingReference?: string;

    /**
     * Customer reference number associated with the booking.
     *
     * @type {string}
     * @memberof FlightBookingResponseSchema
     */
    customerReference?: string;

    /**
     * Internal reference number for the booking.
     *
     * @type {string}
     * @memberof FlightBookingResponseSchema
     */
    bookingReference?: string;

    /**
     * Reference number for the payment associated with the booking.
     *
     * @type {string}
     * @memberof FlightBookingResponseSchema
     */
    paymentReference?: string;

    /**
     * Current status of the booking.
     *
     * @type {string}
     * @memberof FlightBookingResponseSchema
     */
    bookingStatus?: string;

    /**
     * Tax applied to the booking.
     *
     * @type {number}
     * @memberof FlightBookingResponseSchema
     */
    bookingTax?: number;

    /**
     * Total price of the booking.
     *
     * @type {number}
     * @memberof FlightBookingResponseSchema
     */
    bookingPrice?: number;

    /**
     * Currency used for the booking pricing.
     *
     * @type {string}
     * @memberof FlightBookingResponseSchema
     */
    bookingCurrency?: string;

    /**
     * Cancellation policies applicable to the booking.
     *
     * @type {string}
     * @memberof FlightBookingResponseSchema
     */
    bookingCancellationPolicies?: string;

    /**
     * @type {FlightBookingCustomerSchema}
     * @memberof FlightBookingResponseSchema
     */
    customer?: FlightBookingCustomerSchema;

    /**
     * @type {FlightOfferRequestSchema}
     * @memberof FlightBookingResponseSchema
     */
    offerRequest?: FlightOfferRequestSchema;

    /**
     * @type {FlightOfferResponseItemSchema}
     * @memberof FlightBookingResponseSchema
     */
    offer?: FlightOfferResponseItemSchema;

    /**
     * List of passengers, each detailed in FlightBookingCustomerSchema.
     *
     * @type {Array<FlightBookingCustomerSchema>}
     * @memberof FlightBookingResponseSchema
     */
    passengers?: Array<FlightBookingCustomerSchema>;

    /**
     * Indicates if the booking was successful.
     *
     * @type {boolean}
     * @memberof FlightBookingResponseSchema
     */
    success?: boolean;

    /**
     * Provides details on any error that occurred during the booking process.
     *
     * @type {string}
     * @memberof FlightBookingResponseSchema
     */
    errorMessage?: string;
}