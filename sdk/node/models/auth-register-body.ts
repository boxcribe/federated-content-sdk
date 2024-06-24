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
 * @interface AuthRegisterBody
 */
export interface AuthRegisterBody {

    /**
     * @type {string}
     * @memberof AuthRegisterBody
     */
    company: string;

    /**
     * @type {string}
     * @memberof AuthRegisterBody
     */
    firstName: string;

    /**
     * @type {string}
     * @memberof AuthRegisterBody
     */
    lastName: string;

    /**
     * must be unique
     *
     * @type {string}
     * @memberof AuthRegisterBody
     */
    email: string;

    /**
     * At least one number and one letter
     *
     * @type {string}
     * @memberof AuthRegisterBody
     */
    password: string;

    /**
     * @type {string}
     * @memberof AuthRegisterBody
     */
    phoneNumber?: string;

    /**
     * @type {string}
     * @memberof AuthRegisterBody
     */
    phonePrefix?: string;

    /**
     * @type {string}
     * @memberof AuthRegisterBody
     */
    country?: string;
}
