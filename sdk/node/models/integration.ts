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
 * @interface Integration
 */
export interface Integration {

    /**
     * @type {string}
     * @memberof Integration
     */
    id?: string;

    /**
     * @type {string}
     * @memberof Integration
     */
    tenantId?: string | null;

    /**
     * @type {string}
     * @memberof Integration
     */
    categoryId?: string;

    /**
     * @type {string}
     * @memberof Integration
     */
    name?: string;

    /**
     * @type {string}
     * @memberof Integration
     */
    slug?: string;

    /**
     * @type {string}
     * @memberof Integration
     */
    logo?: string | null;

    /**
     * @type {string}
     * @memberof Integration
     */
    status?: IntegrationStatusEnum;

    /**
     * Production Credentials
     *
     * @type {any}
     * @memberof Integration
     */
    credentialsProduction?: any;

    /**
     * Sandbox Credentials
     *
     * @type {any}
     * @memberof Integration
     */
    credentialsSandbox?: any;

    /**
     * @type {string}
     * @memberof Integration
     */
    envProduction?: IntegrationEnvProductionEnum;

    /**
     * @type {string}
     * @memberof Integration
     */
    envSandbox?: IntegrationEnvSandboxEnum;

    /**
     * Production Settings
     *
     * @type {any}
     * @memberof Integration
     */
    settingsProduction?: any;

    /**
     * Sandbox Settings
     *
     * @type {any}
     * @memberof Integration
     */
    settingsSandbox?: any;
}

/**
 * @export
 * @enum {string}
 */
export enum IntegrationStatusEnum {
    Active = 'Active',
    Inactive = 'Inactive'
}
/**
 * @export
 * @enum {string}
 */
export enum IntegrationEnvProductionEnum {
    Production = 'Production',
    Sandbox = 'Sandbox'
}
/**
 * @export
 * @enum {string}
 */
export enum IntegrationEnvSandboxEnum {
    Production = 'Production',
    Sandbox = 'Sandbox'
}

