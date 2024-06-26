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
 * @interface CompaniesIdBody
 */
export interface CompaniesIdBody {

    /**
     * @type {string}
     * @memberof CompaniesIdBody
     */
    name?: string;

    /**
     * @type {string}
     * @memberof CompaniesIdBody
     */
    status?: CompaniesIdBodyStatusEnum;

    /**
     * @type {string}
     * @memberof CompaniesIdBody
     */
    address?: string;

    /**
     * @type {string}
     * @memberof CompaniesIdBody
     */
    address2?: string;

    /**
     * @type {string}
     * @memberof CompaniesIdBody
     */
    city?: string;

    /**
     * @type {string}
     * @memberof CompaniesIdBody
     */
    state?: string;

    /**
     * @type {string}
     * @memberof CompaniesIdBody
     */
    zip?: string;

    /**
     * @type {string}
     * @memberof CompaniesIdBody
     */
    country?: string;

    /**
     * @type {string}
     * @memberof CompaniesIdBody
     */
    phone?: string;

    /**
     * @type {string}
     * @memberof CompaniesIdBody
     */
    mobile?: string;

    /**
     * @type {string}
     * @memberof CompaniesIdBody
     */
    fax?: string;

    /**
     * @type {string}
     * @memberof CompaniesIdBody
     */
    email?: string;

    /**
     * @type {string}
     * @memberof CompaniesIdBody
     */
    website?: string;

    /**
     * @type {string}
     * @memberof CompaniesIdBody
     */
    logo?: string;

    /**
     * @type {string}
     * @memberof CompaniesIdBody
     */
    icon?: string;

    /**
     * @type {string}
     * @memberof CompaniesIdBody
     */
    color1?: string;

    /**
     * @type {string}
     * @memberof CompaniesIdBody
     */
    color2?: string;

    /**
     * @type {string}
     * @memberof CompaniesIdBody
     */
    description?: string;
}

/**
 * @export
 * @enum {string}
 */
export enum CompaniesIdBodyStatusEnum {
    Active = 'Active',
    Inactive = 'Inactive'
}

