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
 * @interface SchemasIdBody
 */
export interface SchemasIdBody {

    /**
     * The unique identifier of the tenant
     *
     * @type {string}
     * @memberof SchemasIdBody
     */
    tenantId?: string;

    /**
     * The unique identifier of the category
     *
     * @type {string}
     * @memberof SchemasIdBody
     */
    categoryId?: string;

    /**
     * Name of the schema
     *
     * @type {string}
     * @memberof SchemasIdBody
     */
    name?: string;

    /**
     * Slug for the schema
     *
     * @type {string}
     * @memberof SchemasIdBody
     */
    slug?: string;

    /**
     * Status of the schema
     *
     * @type {string}
     * @memberof SchemasIdBody
     */
    status?: SchemasIdBodyStatusEnum;

    /**
     * Whether the schema is a system schema
     *
     * @type {boolean}
     * @memberof SchemasIdBody
     */
    system?: boolean;

    /**
     * Endpoint URL
     *
     * @type {string}
     * @memberof SchemasIdBody
     */
    endpoint?: string;

    /**
     * Endpoint name (Group name)
     *
     * @type {string}
     * @memberof SchemasIdBody
     */
    endpointName?: string;

    /**
     * Type of the schema (Request or Response)
     *
     * @type {string}
     * @memberof SchemasIdBody
     */
    type?: SchemasIdBodyTypeEnum;

    /**
     * HTTP method for Request types
     *
     * @type {string}
     * @memberof SchemasIdBody
     */
    method?: SchemasIdBodyMethodEnum;

    /**
     * Headers for Request type, stored in JSON format
     *
     * @type {{ [key: string]: string; }}
     * @memberof SchemasIdBody
     */
    headers?: { [key: string]: string; };

    /**
     * Query parameters for Request type, stored in JSON format
     *
     * @type {{ [key: string]: string; }}
     * @memberof SchemasIdBody
     */
    _query?: { [key: string]: string; };
}

/**
 * @export
 * @enum {string}
 */
export enum SchemasIdBodyStatusEnum {
    Active = 'Active',
    Inactive = 'Inactive'
}
/**
 * @export
 * @enum {string}
 */
export enum SchemasIdBodyTypeEnum {
    Request = 'Request',
    Response = 'Response'
}
/**
 * @export
 * @enum {string}
 */
export enum SchemasIdBodyMethodEnum {
    GET = 'GET',
    POST = 'POST',
    PATCH = 'PATCH',
    DELETE = 'DELETE'
}
