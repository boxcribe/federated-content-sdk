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

import { HotelBookingCustomerSchema } from './hotel-booking-customer-schema';
import { HotelOfferRequestSchema } from './hotel-offer-request-schema';
import { HotelOfferResponseItemSchema } from './hotel-offer-response-item-schema';
import { HotelRoomSchema } from './hotel-room-schema';
 /**
 * 
 *
 * @export
 * @interface HotelCancelBookingResponseSchema
 */
export interface HotelCancelBookingResponseSchema {

    /**
     * Identifier for the company associated with the booking.
     *
     * @type {string}
     * @memberof HotelCancelBookingResponseSchema
     */
    companyId?: string;

    /**
     * Identifier for the tenant associated with the booking.
     *
     * @type {string}
     * @memberof HotelCancelBookingResponseSchema
     */
    tenantId?: string;

    /**
     * Identifier for the category of the booking.
     *
     * @type {string}
     * @memberof HotelCancelBookingResponseSchema
     */
    categoryId?: string;

    /**
     * Identifier for the supplier of the booking.
     *
     * @type {string}
     * @memberof HotelCancelBookingResponseSchema
     */
    supplierId?: string;

    /**
     * Unique identifier for the booking.
     *
     * @type {string}
     * @memberof HotelCancelBookingResponseSchema
     */
    bookingId?: string;

    /**
     * Supplier’s identifier for the booking.
     *
     * @type {string}
     * @memberof HotelCancelBookingResponseSchema
     */
    supplierBookingId?: string;

    /**
     * Reference number provided by the supplier for the booking.
     *
     * @type {string}
     * @memberof HotelCancelBookingResponseSchema
     */
    supplierBookingReference?: string;

    /**
     * Customer reference number associated with the booking.
     *
     * @type {string}
     * @memberof HotelCancelBookingResponseSchema
     */
    customerReference?: string;

    /**
     * Internal reference number for the booking.
     *
     * @type {string}
     * @memberof HotelCancelBookingResponseSchema
     */
    bookingReference?: string;

    /**
     * Reference number for the payment associated with the booking.
     *
     * @type {string}
     * @memberof HotelCancelBookingResponseSchema
     */
    paymentReference?: string;

    /**
     * Current status of the booking.
     *
     * @type {string}
     * @memberof HotelCancelBookingResponseSchema
     */
    bookingStatus?: string;

    /**
     * Tax applied to the booking.
     *
     * @type {number}
     * @memberof HotelCancelBookingResponseSchema
     */
    bookingTax?: number;

    /**
     * Total price of the booking.
     *
     * @type {number}
     * @memberof HotelCancelBookingResponseSchema
     */
    bookingPrice?: number;

    /**
     * Currency used for the booking pricing.
     *
     * @type {string}
     * @memberof HotelCancelBookingResponseSchema
     */
    bookingCurrency?: string;

    /**
     * Cancellation policies applicable to the booking.
     *
     * @type {string}
     * @memberof HotelCancelBookingResponseSchema
     */
    bookingCancelationPolicies?: string;

    /**
     * @type {any}
     * @memberof HotelCancelBookingResponseSchema
     */
    customer?: any;

    /**
     * @type {any}
     * @memberof HotelCancelBookingResponseSchema
     */
    offerRequest?: any;

    /**
     * @type {any}
     * @memberof HotelCancelBookingResponseSchema
     */
    offer?: any;

    /**
     * @type {any}
     * @memberof HotelCancelBookingResponseSchema
     */
    room?: any;

    /**
     * Number of rooms of this type being booked.
     *
     * @type {number}
     * @memberof HotelCancelBookingResponseSchema
     */
    roomQty?: number;

    /**
     * Indicates if the booking was successful.
     *
     * @type {boolean}
     * @memberof HotelCancelBookingResponseSchema
     */
    success?: boolean;

    /**
     * Provides details on any error that occurred during the booking process.
     *
     * @type {string}
     * @memberof HotelCancelBookingResponseSchema
     */
    errorMessage?: string;
}
