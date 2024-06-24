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

import { TransportBookingCustomerSchema } from './transport-booking-customer-schema';
import { TransportOfferRequestSchema } from './transport-offer-request-schema';
import { TransportOfferResponseItemSchema } from './transport-offer-response-item-schema';
 /**
 * 
 *
 * @export
 * @interface TransportBookingDetailsResponseSchema
 */
export interface TransportBookingDetailsResponseSchema {

    /**
     * Identifier for the company associated with the booking.
     *
     * @type {string}
     * @memberof TransportBookingDetailsResponseSchema
     */
    companyId?: string;

    /**
     * Identifier for the tenant associated with the booking.
     *
     * @type {string}
     * @memberof TransportBookingDetailsResponseSchema
     */
    tenantId?: string;

    /**
     * Identifier for the category of the booking.
     *
     * @type {string}
     * @memberof TransportBookingDetailsResponseSchema
     */
    categoryId?: string;

    /**
     * Identifier for the supplier of the booking.
     *
     * @type {string}
     * @memberof TransportBookingDetailsResponseSchema
     */
    supplierId?: string;

    /**
     * Unique identifier for the booking.
     *
     * @type {string}
     * @memberof TransportBookingDetailsResponseSchema
     */
    bookingId?: string;

    /**
     * Supplier’s identifier for the booking.
     *
     * @type {string}
     * @memberof TransportBookingDetailsResponseSchema
     */
    supplierBookingId?: string;

    /**
     * Reference number provided by the supplier for the booking.
     *
     * @type {string}
     * @memberof TransportBookingDetailsResponseSchema
     */
    supplierBookingReference?: string;

    /**
     * Customer reference number associated with the booking.
     *
     * @type {string}
     * @memberof TransportBookingDetailsResponseSchema
     */
    customerReference?: string;

    /**
     * Internal reference number for the booking.
     *
     * @type {string}
     * @memberof TransportBookingDetailsResponseSchema
     */
    bookingReference?: string;

    /**
     * Reference number for the payment associated with the booking.
     *
     * @type {string}
     * @memberof TransportBookingDetailsResponseSchema
     */
    paymentReference?: string;

    /**
     * Current status of the booking.
     *
     * @type {string}
     * @memberof TransportBookingDetailsResponseSchema
     */
    bookingStatus?: string;

    /**
     * Tax applied to the booking.
     *
     * @type {number}
     * @memberof TransportBookingDetailsResponseSchema
     */
    bookingTax?: number;

    /**
     * Total price of the booking.
     *
     * @type {number}
     * @memberof TransportBookingDetailsResponseSchema
     */
    bookingPrice?: number;

    /**
     * Currency used for the booking pricing.
     *
     * @type {string}
     * @memberof TransportBookingDetailsResponseSchema
     */
    bookingCurrency?: string;

    /**
     * Cancellation policies applicable to the booking.
     *
     * @type {string}
     * @memberof TransportBookingDetailsResponseSchema
     */
    bookingCancelationPolicies?: string;

    /**
     * @type {any}
     * @memberof TransportBookingDetailsResponseSchema
     */
    customer?: any;

    /**
     * @type {any}
     * @memberof TransportBookingDetailsResponseSchema
     */
    offerRequest?: any;

    /**
     * @type {any}
     * @memberof TransportBookingDetailsResponseSchema
     */
    offer?: any;

    /**
     * Indicates if the booking was successful.
     *
     * @type {boolean}
     * @memberof TransportBookingDetailsResponseSchema
     */
    success?: boolean;

    /**
     * Provides details on any error that occurred during the booking process.
     *
     * @type {string}
     * @memberof TransportBookingDetailsResponseSchema
     */
    errorMessage?: string;
}