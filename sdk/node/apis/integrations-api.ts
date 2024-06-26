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

import globalAxios, { AxiosResponse, AxiosInstance, AxiosRequestConfig } from 'axios';
import { Configuration } from '../configuration';
// Some imports not used depending on template conditions
// @ts-ignore
import { BASE_PATH, COLLECTION_FORMATS, RequestArgs, BaseAPI, RequiredError } from '../base';
import { InlineResponse2007 } from '../models';
import { Integration } from '../models';
import { IntegrationsBody } from '../models';
import { IntegrationsIdBody } from '../models';
/**
 * IntegrationsApi - axios parameter creator
 * @export
 */
export const IntegrationsApiAxiosParamCreator = function (configuration?: Configuration) {
    return {
        /**
         * Retrieve a list of integrations with the ability to filter by tenant, category, sort, limit or page.
         * @summary Get integrations
         * @param {string} [tenant] Get all integrations for a Tenant ID
         * @param {string} [category] Get all integrations for a Category ID
         * @param {string} [sort] sort by query in the form of field:desc/asc (ex. name:asc)
         * @param {number} [limit] Maximum number of integrations
         * @param {number} [page] Page number
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        integrationsGet: async (tenant?: string, category?: string, sort?: string, limit?: number, page?: number, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            const localVarPath = `/integrations`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'GET', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication bearerAuth required
            // http bearer authentication required
            if (configuration && configuration.accessToken) {
                const accessToken = typeof configuration.accessToken === 'function'
                    ? await configuration.accessToken()
                    : await configuration.accessToken;
                localVarHeaderParameter["Authorization"] = "Bearer " + accessToken;
            }

            if (tenant !== undefined) {
                localVarQueryParameter['tenant'] = tenant;
            }

            if (category !== undefined) {
                localVarQueryParameter['category'] = category;
            }

            if (sort !== undefined) {
                localVarQueryParameter['sort'] = sort;
            }

            if (limit !== undefined) {
                localVarQueryParameter['limit'] = limit;
            }

            if (page !== undefined) {
                localVarQueryParameter['page'] = page;
            }

            const query = new URLSearchParams(localVarUrlObj.search);
            for (const key in localVarQueryParameter) {
                query.set(key, localVarQueryParameter[key]);
            }
            for (const key in options.params) {
                query.set(key, options.params[key]);
            }
            localVarUrlObj.search = (new URLSearchParams(query)).toString();
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};

            return {
                url: localVarUrlObj.pathname + localVarUrlObj.search + localVarUrlObj.hash,
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @summary Delete integration
         * @param {string} id Integration id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        integrationsIdDelete: async (id: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'id' is not null or undefined
            if (id === null || id === undefined) {
                throw new RequiredError('id','Required parameter id was null or undefined when calling integrationsIdDelete.');
            }
            const localVarPath = `/integrations/{id}`
                .replace(`{${"id"}}`, encodeURIComponent(String(id)));
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'DELETE', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication bearerAuth required
            // http bearer authentication required
            if (configuration && configuration.accessToken) {
                const accessToken = typeof configuration.accessToken === 'function'
                    ? await configuration.accessToken()
                    : await configuration.accessToken;
                localVarHeaderParameter["Authorization"] = "Bearer " + accessToken;
            }

            const query = new URLSearchParams(localVarUrlObj.search);
            for (const key in localVarQueryParameter) {
                query.set(key, localVarQueryParameter[key]);
            }
            for (const key in options.params) {
                query.set(key, options.params[key]);
            }
            localVarUrlObj.search = (new URLSearchParams(query)).toString();
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};

            return {
                url: localVarUrlObj.pathname + localVarUrlObj.search + localVarUrlObj.hash,
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @summary Get integration
         * @param {string} id Integration id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        integrationsIdGet: async (id: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'id' is not null or undefined
            if (id === null || id === undefined) {
                throw new RequiredError('id','Required parameter id was null or undefined when calling integrationsIdGet.');
            }
            const localVarPath = `/integrations/{id}`
                .replace(`{${"id"}}`, encodeURIComponent(String(id)));
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'GET', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication bearerAuth required
            // http bearer authentication required
            if (configuration && configuration.accessToken) {
                const accessToken = typeof configuration.accessToken === 'function'
                    ? await configuration.accessToken()
                    : await configuration.accessToken;
                localVarHeaderParameter["Authorization"] = "Bearer " + accessToken;
            }

            const query = new URLSearchParams(localVarUrlObj.search);
            for (const key in localVarQueryParameter) {
                query.set(key, localVarQueryParameter[key]);
            }
            for (const key in options.params) {
                query.set(key, options.params[key]);
            }
            localVarUrlObj.search = (new URLSearchParams(query)).toString();
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};

            return {
                url: localVarUrlObj.pathname + localVarUrlObj.search + localVarUrlObj.hash,
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @summary Update integration
         * @param {IntegrationsIdBody} body 
         * @param {string} id Integration id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        integrationsIdPatch: async (body: IntegrationsIdBody, id: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'body' is not null or undefined
            if (body === null || body === undefined) {
                throw new RequiredError('body','Required parameter body was null or undefined when calling integrationsIdPatch.');
            }
            // verify required parameter 'id' is not null or undefined
            if (id === null || id === undefined) {
                throw new RequiredError('id','Required parameter id was null or undefined when calling integrationsIdPatch.');
            }
            const localVarPath = `/integrations/{id}`
                .replace(`{${"id"}}`, encodeURIComponent(String(id)));
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'PATCH', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication bearerAuth required
            // http bearer authentication required
            if (configuration && configuration.accessToken) {
                const accessToken = typeof configuration.accessToken === 'function'
                    ? await configuration.accessToken()
                    : await configuration.accessToken;
                localVarHeaderParameter["Authorization"] = "Bearer " + accessToken;
            }

            localVarHeaderParameter['Content-Type'] = 'application/json';

            const query = new URLSearchParams(localVarUrlObj.search);
            for (const key in localVarQueryParameter) {
                query.set(key, localVarQueryParameter[key]);
            }
            for (const key in options.params) {
                query.set(key, options.params[key]);
            }
            localVarUrlObj.search = (new URLSearchParams(query)).toString();
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            const needsSerialization = (typeof body !== "string") || localVarRequestOptions.headers['Content-Type'] === 'application/json';
            localVarRequestOptions.data =  needsSerialization ? JSON.stringify(body !== undefined ? body : {}) : (body || "");

            return {
                url: localVarUrlObj.pathname + localVarUrlObj.search + localVarUrlObj.hash,
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @summary Create integration
         * @param {IntegrationsBody} body 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        integrationsPost: async (body: IntegrationsBody, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'body' is not null or undefined
            if (body === null || body === undefined) {
                throw new RequiredError('body','Required parameter body was null or undefined when calling integrationsPost.');
            }
            const localVarPath = `/integrations`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'POST', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication bearerAuth required
            // http bearer authentication required
            if (configuration && configuration.accessToken) {
                const accessToken = typeof configuration.accessToken === 'function'
                    ? await configuration.accessToken()
                    : await configuration.accessToken;
                localVarHeaderParameter["Authorization"] = "Bearer " + accessToken;
            }

            localVarHeaderParameter['Content-Type'] = 'application/json';

            const query = new URLSearchParams(localVarUrlObj.search);
            for (const key in localVarQueryParameter) {
                query.set(key, localVarQueryParameter[key]);
            }
            for (const key in options.params) {
                query.set(key, options.params[key]);
            }
            localVarUrlObj.search = (new URLSearchParams(query)).toString();
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            const needsSerialization = (typeof body !== "string") || localVarRequestOptions.headers['Content-Type'] === 'application/json';
            localVarRequestOptions.data =  needsSerialization ? JSON.stringify(body !== undefined ? body : {}) : (body || "");

            return {
                url: localVarUrlObj.pathname + localVarUrlObj.search + localVarUrlObj.hash,
                options: localVarRequestOptions,
            };
        },
    }
};

/**
 * IntegrationsApi - functional programming interface
 * @export
 */
export const IntegrationsApiFp = function(configuration?: Configuration) {
    return {
        /**
         * Retrieve a list of integrations with the ability to filter by tenant, category, sort, limit or page.
         * @summary Get integrations
         * @param {string} [tenant] Get all integrations for a Tenant ID
         * @param {string} [category] Get all integrations for a Category ID
         * @param {string} [sort] sort by query in the form of field:desc/asc (ex. name:asc)
         * @param {number} [limit] Maximum number of integrations
         * @param {number} [page] Page number
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async integrationsGet(tenant?: string, category?: string, sort?: string, limit?: number, page?: number, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<InlineResponse2007>>> {
            const localVarAxiosArgs = await IntegrationsApiAxiosParamCreator(configuration).integrationsGet(tenant, category, sort, limit, page, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @summary Delete integration
         * @param {string} id Integration id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async integrationsIdDelete(id: string, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<void>>> {
            const localVarAxiosArgs = await IntegrationsApiAxiosParamCreator(configuration).integrationsIdDelete(id, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @summary Get integration
         * @param {string} id Integration id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async integrationsIdGet(id: string, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<Integration>>> {
            const localVarAxiosArgs = await IntegrationsApiAxiosParamCreator(configuration).integrationsIdGet(id, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @summary Update integration
         * @param {IntegrationsIdBody} body 
         * @param {string} id Integration id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async integrationsIdPatch(body: IntegrationsIdBody, id: string, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<Integration>>> {
            const localVarAxiosArgs = await IntegrationsApiAxiosParamCreator(configuration).integrationsIdPatch(body, id, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @summary Create integration
         * @param {IntegrationsBody} body 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async integrationsPost(body: IntegrationsBody, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<Integration>>> {
            const localVarAxiosArgs = await IntegrationsApiAxiosParamCreator(configuration).integrationsPost(body, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
    }
};

/**
 * IntegrationsApi - factory interface
 * @export
 */
export const IntegrationsApiFactory = function (configuration?: Configuration, basePath?: string, axios?: AxiosInstance) {
    return {
        /**
         * Retrieve a list of integrations with the ability to filter by tenant, category, sort, limit or page.
         * @summary Get integrations
         * @param {string} [tenant] Get all integrations for a Tenant ID
         * @param {string} [category] Get all integrations for a Category ID
         * @param {string} [sort] sort by query in the form of field:desc/asc (ex. name:asc)
         * @param {number} [limit] Maximum number of integrations
         * @param {number} [page] Page number
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async integrationsGet(tenant?: string, category?: string, sort?: string, limit?: number, page?: number, options?: AxiosRequestConfig): Promise<AxiosResponse<InlineResponse2007>> {
            return IntegrationsApiFp(configuration).integrationsGet(tenant, category, sort, limit, page, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Delete integration
         * @param {string} id Integration id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async integrationsIdDelete(id: string, options?: AxiosRequestConfig): Promise<AxiosResponse<void>> {
            return IntegrationsApiFp(configuration).integrationsIdDelete(id, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Get integration
         * @param {string} id Integration id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async integrationsIdGet(id: string, options?: AxiosRequestConfig): Promise<AxiosResponse<Integration>> {
            return IntegrationsApiFp(configuration).integrationsIdGet(id, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Update integration
         * @param {IntegrationsIdBody} body 
         * @param {string} id Integration id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async integrationsIdPatch(body: IntegrationsIdBody, id: string, options?: AxiosRequestConfig): Promise<AxiosResponse<Integration>> {
            return IntegrationsApiFp(configuration).integrationsIdPatch(body, id, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Create integration
         * @param {IntegrationsBody} body 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async integrationsPost(body: IntegrationsBody, options?: AxiosRequestConfig): Promise<AxiosResponse<Integration>> {
            return IntegrationsApiFp(configuration).integrationsPost(body, options).then((request) => request(axios, basePath));
        },
    };
};

/**
 * IntegrationsApi - object-oriented interface
 * @export
 * @class IntegrationsApi
 * @extends {BaseAPI}
 */
export class IntegrationsApi extends BaseAPI {
    /**
     * Retrieve a list of integrations with the ability to filter by tenant, category, sort, limit or page.
     * @summary Get integrations
     * @param {string} [tenant] Get all integrations for a Tenant ID
     * @param {string} [category] Get all integrations for a Category ID
     * @param {string} [sort] sort by query in the form of field:desc/asc (ex. name:asc)
     * @param {number} [limit] Maximum number of integrations
     * @param {number} [page] Page number
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof IntegrationsApi
     */
    public async integrationsGet(tenant?: string, category?: string, sort?: string, limit?: number, page?: number, options?: AxiosRequestConfig) : Promise<AxiosResponse<InlineResponse2007>> {
        return IntegrationsApiFp(this.configuration).integrationsGet(tenant, category, sort, limit, page, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @summary Delete integration
     * @param {string} id Integration id
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof IntegrationsApi
     */
    public async integrationsIdDelete(id: string, options?: AxiosRequestConfig) : Promise<AxiosResponse<void>> {
        return IntegrationsApiFp(this.configuration).integrationsIdDelete(id, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @summary Get integration
     * @param {string} id Integration id
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof IntegrationsApi
     */
    public async integrationsIdGet(id: string, options?: AxiosRequestConfig) : Promise<AxiosResponse<Integration>> {
        return IntegrationsApiFp(this.configuration).integrationsIdGet(id, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @summary Update integration
     * @param {IntegrationsIdBody} body 
     * @param {string} id Integration id
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof IntegrationsApi
     */
    public async integrationsIdPatch(body: IntegrationsIdBody, id: string, options?: AxiosRequestConfig) : Promise<AxiosResponse<Integration>> {
        return IntegrationsApiFp(this.configuration).integrationsIdPatch(body, id, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @summary Create integration
     * @param {IntegrationsBody} body 
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof IntegrationsApi
     */
    public async integrationsPost(body: IntegrationsBody, options?: AxiosRequestConfig) : Promise<AxiosResponse<Integration>> {
        return IntegrationsApiFp(this.configuration).integrationsPost(body, options).then((request) => request(this.axios, this.basePath));
    }
}
