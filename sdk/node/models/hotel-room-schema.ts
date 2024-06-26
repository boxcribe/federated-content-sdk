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
 * @interface HotelRoomSchema
 */
export interface HotelRoomSchema {

    /**
     * Unique identifier for each room.
     *
     * @type {string}
     * @memberof HotelRoomSchema
     */
    roomId?: string;

    /**
     * Supplier specific identifier for the room.
     *
     * @type {string}
     * @memberof HotelRoomSchema
     */
    supplierRoomId?: string;

    /**
     * Position of the room in the list.
     *
     * @type {number}
     * @memberof HotelRoomSchema
     */
    roomIndex?: number;

    /**
     * Start date of the hotel reservation.
     *
     * @type {string}
     * @memberof HotelRoomSchema
     */
    checkinDate?: string;

    /**
     * End date of the hotel reservation.
     *
     * @type {string}
     * @memberof HotelRoomSchema
     */
    checkoutDate?: string;

    /**
     * Number of adults that can be accommodated in the room.
     *
     * @type {number}
     * @memberof HotelRoomSchema
     */
    adults?: number;

    /**
     * Number of children that can be accommodated in the room.
     *
     * @type {number}
     * @memberof HotelRoomSchema
     */
    children?: number;

    /**
     * Tax rate applicable to the room price.
     *
     * @type {number}
     * @memberof HotelRoomSchema
     */
    roomTax?: number;

    /**
     * Nightly rate for the room.
     *
     * @type {number}
     * @memberof HotelRoomSchema
     */
    roomPrice?: number;

    /**
     * Currency used for the room pricing.
     *
     * @type {string}
     * @memberof HotelRoomSchema
     */
    roomCurrency?: string;

    /**
     * Details about the cancellation policy for the room.
     *
     * @type {any}
     * @memberof HotelRoomSchema
     */
    roomCancellationPolicies?: any;

    /**
     * Type or name of the room.
     *
     * @type {string}
     * @memberof HotelRoomSchema
     */
    roomName?: string;

    /**
     * Description of the room including amenities and features.
     *
     * @type {string}
     * @memberof HotelRoomSchema
     */
    roomDescription?: string;

    /**
     * Images showcasing the room.
     *
     * @type {Array<string>}
     * @memberof HotelRoomSchema
     */
    roomImages?: Array<string>;

    /**
     * Maximum quantity of this room type available.
     *
     * @type {number}
     * @memberof HotelRoomSchema
     */
    roomQuantityMax?: number;
}
