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
import { ToursAndActivitiesBookingDetailsResponseSchema } from '../models';
import { ToursAndActivitiesBookingResponseSchema } from '../models';
import { ToursAndActivitiesCancelBookingRequestSchema } from '../models';
import { ToursAndActivitiesCancelBookingResponseSchema } from '../models';
import { ToursAndActivitiesCreateBookingRequestSchema } from '../models';
import { ToursAndActivitiesGetOfferAvailabilityRequest } from '../models';
import { ToursAndActivitiesGetOfferAvailabilityResponse } from '../models';
import { ToursAndActivitiesOfferDetailsSchema } from '../models';
import { ToursAndActivitiesOfferRequestSchema } from '../models';
import { ToursAndActivitiesOfferResponseSchema } from '../models';
/**
 * ToursAndActivitiesApi - axios parameter creator
 * @export
 */
export const ToursAndActivitiesApiAxiosParamCreator = function (configuration?: Configuration) {
    return {
        /**
         * 
         * @summary Cancel Booking
         * @param {ToursAndActivitiesCancelBookingRequestSchema} body 
         * @param {string} bookingId 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        toursBookingsBookingIdCancelPost: async (body: ToursAndActivitiesCancelBookingRequestSchema, bookingId: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'body' is not null or undefined
            if (body === null || body === undefined) {
                throw new RequiredError('body','Required parameter body was null or undefined when calling toursBookingsBookingIdCancelPost.');
            }
            // verify required parameter 'bookingId' is not null or undefined
            if (bookingId === null || bookingId === undefined) {
                throw new RequiredError('bookingId','Required parameter bookingId was null or undefined when calling toursBookingsBookingIdCancelPost.');
            }
            const localVarPath = `/tours/bookings/{bookingId}/cancel`
                .replace(`{${"bookingId"}}`, encodeURIComponent(String(bookingId)));
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'POST', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication apiKeyAuth required
            if (configuration && configuration.apiKey) {
                const localVarApiKeyValue = typeof configuration.apiKey === 'function'
                    ? await configuration.apiKey("x-api-key")
                    : await configuration.apiKey;
                localVarHeaderParameter["x-api-key"] = localVarApiKeyValue;
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
         * @summary Get Booking Details
         * @param {string} bookingId 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        toursBookingsBookingIdGet: async (bookingId: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'bookingId' is not null or undefined
            if (bookingId === null || bookingId === undefined) {
                throw new RequiredError('bookingId','Required parameter bookingId was null or undefined when calling toursBookingsBookingIdGet.');
            }
            const localVarPath = `/tours/bookings/{bookingId}`
                .replace(`{${"bookingId"}}`, encodeURIComponent(String(bookingId)));
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'GET', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication apiKeyAuth required
            if (configuration && configuration.apiKey) {
                const localVarApiKeyValue = typeof configuration.apiKey === 'function'
                    ? await configuration.apiKey("x-api-key")
                    : await configuration.apiKey;
                localVarHeaderParameter["x-api-key"] = localVarApiKeyValue;
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
         * @summary Create Booking
         * @param {ToursAndActivitiesCreateBookingRequestSchema} body 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        toursBookingsPost: async (body: ToursAndActivitiesCreateBookingRequestSchema, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'body' is not null or undefined
            if (body === null || body === undefined) {
                throw new RequiredError('body','Required parameter body was null or undefined when calling toursBookingsPost.');
            }
            const localVarPath = `/tours/bookings`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'POST', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication apiKeyAuth required
            if (configuration && configuration.apiKey) {
                const localVarApiKeyValue = typeof configuration.apiKey === 'function'
                    ? await configuration.apiKey("x-api-key")
                    : await configuration.apiKey;
                localVarHeaderParameter["x-api-key"] = localVarApiKeyValue;
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
         * @summary Get Offer Availability
         * @param {ToursAndActivitiesGetOfferAvailabilityRequest} body 
         * @param {string} offerId 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        toursOfferAvailabilityOfferIdPost: async (body: ToursAndActivitiesGetOfferAvailabilityRequest, offerId: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'body' is not null or undefined
            if (body === null || body === undefined) {
                throw new RequiredError('body','Required parameter body was null or undefined when calling toursOfferAvailabilityOfferIdPost.');
            }
            // verify required parameter 'offerId' is not null or undefined
            if (offerId === null || offerId === undefined) {
                throw new RequiredError('offerId','Required parameter offerId was null or undefined when calling toursOfferAvailabilityOfferIdPost.');
            }
            const localVarPath = `/tours/offer_availability/{offerId}`
                .replace(`{${"offerId"}}`, encodeURIComponent(String(offerId)));
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'POST', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication apiKeyAuth required
            if (configuration && configuration.apiKey) {
                const localVarApiKeyValue = typeof configuration.apiKey === 'function'
                    ? await configuration.apiKey("x-api-key")
                    : await configuration.apiKey;
                localVarHeaderParameter["x-api-key"] = localVarApiKeyValue;
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
         * @summary Get Offer Details
         * @param {string} offerId 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        toursOffersOfferIdGet: async (offerId: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'offerId' is not null or undefined
            if (offerId === null || offerId === undefined) {
                throw new RequiredError('offerId','Required parameter offerId was null or undefined when calling toursOffersOfferIdGet.');
            }
            const localVarPath = `/tours/offers/{offerId}`
                .replace(`{${"offerId"}}`, encodeURIComponent(String(offerId)));
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'GET', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication apiKeyAuth required
            if (configuration && configuration.apiKey) {
                const localVarApiKeyValue = typeof configuration.apiKey === 'function'
                    ? await configuration.apiKey("x-api-key")
                    : await configuration.apiKey;
                localVarHeaderParameter["x-api-key"] = localVarApiKeyValue;
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
         * @summary Search Offers
         * @param {ToursAndActivitiesOfferRequestSchema} body 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        toursOffersSearchPost: async (body: ToursAndActivitiesOfferRequestSchema, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'body' is not null or undefined
            if (body === null || body === undefined) {
                throw new RequiredError('body','Required parameter body was null or undefined when calling toursOffersSearchPost.');
            }
            const localVarPath = `/tours/offers/search`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'POST', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication apiKeyAuth required
            if (configuration && configuration.apiKey) {
                const localVarApiKeyValue = typeof configuration.apiKey === 'function'
                    ? await configuration.apiKey("x-api-key")
                    : await configuration.apiKey;
                localVarHeaderParameter["x-api-key"] = localVarApiKeyValue;
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
 * ToursAndActivitiesApi - functional programming interface
 * @export
 */
export const ToursAndActivitiesApiFp = function(configuration?: Configuration) {
    return {
        /**
         * 
         * @summary Cancel Booking
         * @param {ToursAndActivitiesCancelBookingRequestSchema} body 
         * @param {string} bookingId 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async toursBookingsBookingIdCancelPost(body: ToursAndActivitiesCancelBookingRequestSchema, bookingId: string, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<ToursAndActivitiesCancelBookingResponseSchema>>> {
            const localVarAxiosArgs = await ToursAndActivitiesApiAxiosParamCreator(configuration).toursBookingsBookingIdCancelPost(body, bookingId, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @summary Get Booking Details
         * @param {string} bookingId 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async toursBookingsBookingIdGet(bookingId: string, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<ToursAndActivitiesBookingDetailsResponseSchema>>> {
            const localVarAxiosArgs = await ToursAndActivitiesApiAxiosParamCreator(configuration).toursBookingsBookingIdGet(bookingId, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @summary Create Booking
         * @param {ToursAndActivitiesCreateBookingRequestSchema} body 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async toursBookingsPost(body: ToursAndActivitiesCreateBookingRequestSchema, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<ToursAndActivitiesBookingResponseSchema>>> {
            const localVarAxiosArgs = await ToursAndActivitiesApiAxiosParamCreator(configuration).toursBookingsPost(body, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @summary Get Offer Availability
         * @param {ToursAndActivitiesGetOfferAvailabilityRequest} body 
         * @param {string} offerId 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async toursOfferAvailabilityOfferIdPost(body: ToursAndActivitiesGetOfferAvailabilityRequest, offerId: string, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<ToursAndActivitiesGetOfferAvailabilityResponse>>> {
            const localVarAxiosArgs = await ToursAndActivitiesApiAxiosParamCreator(configuration).toursOfferAvailabilityOfferIdPost(body, offerId, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @summary Get Offer Details
         * @param {string} offerId 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async toursOffersOfferIdGet(offerId: string, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<ToursAndActivitiesOfferDetailsSchema>>> {
            const localVarAxiosArgs = await ToursAndActivitiesApiAxiosParamCreator(configuration).toursOffersOfferIdGet(offerId, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @summary Search Offers
         * @param {ToursAndActivitiesOfferRequestSchema} body 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async toursOffersSearchPost(body: ToursAndActivitiesOfferRequestSchema, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<ToursAndActivitiesOfferResponseSchema>>> {
            const localVarAxiosArgs = await ToursAndActivitiesApiAxiosParamCreator(configuration).toursOffersSearchPost(body, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
    }
};

/**
 * ToursAndActivitiesApi - factory interface
 * @export
 */
export const ToursAndActivitiesApiFactory = function (configuration?: Configuration, basePath?: string, axios?: AxiosInstance) {
    return {
        /**
         * 
         * @summary Cancel Booking
         * @param {ToursAndActivitiesCancelBookingRequestSchema} body 
         * @param {string} bookingId 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async toursBookingsBookingIdCancelPost(body: ToursAndActivitiesCancelBookingRequestSchema, bookingId: string, options?: AxiosRequestConfig): Promise<AxiosResponse<ToursAndActivitiesCancelBookingResponseSchema>> {
            return ToursAndActivitiesApiFp(configuration).toursBookingsBookingIdCancelPost(body, bookingId, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Get Booking Details
         * @param {string} bookingId 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async toursBookingsBookingIdGet(bookingId: string, options?: AxiosRequestConfig): Promise<AxiosResponse<ToursAndActivitiesBookingDetailsResponseSchema>> {
            return ToursAndActivitiesApiFp(configuration).toursBookingsBookingIdGet(bookingId, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Create Booking
         * @param {ToursAndActivitiesCreateBookingRequestSchema} body 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async toursBookingsPost(body: ToursAndActivitiesCreateBookingRequestSchema, options?: AxiosRequestConfig): Promise<AxiosResponse<ToursAndActivitiesBookingResponseSchema>> {
            return ToursAndActivitiesApiFp(configuration).toursBookingsPost(body, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Get Offer Availability
         * @param {ToursAndActivitiesGetOfferAvailabilityRequest} body 
         * @param {string} offerId 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async toursOfferAvailabilityOfferIdPost(body: ToursAndActivitiesGetOfferAvailabilityRequest, offerId: string, options?: AxiosRequestConfig): Promise<AxiosResponse<ToursAndActivitiesGetOfferAvailabilityResponse>> {
            return ToursAndActivitiesApiFp(configuration).toursOfferAvailabilityOfferIdPost(body, offerId, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Get Offer Details
         * @param {string} offerId 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async toursOffersOfferIdGet(offerId: string, options?: AxiosRequestConfig): Promise<AxiosResponse<ToursAndActivitiesOfferDetailsSchema>> {
            return ToursAndActivitiesApiFp(configuration).toursOffersOfferIdGet(offerId, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Search Offers
         * @param {ToursAndActivitiesOfferRequestSchema} body 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async toursOffersSearchPost(body: ToursAndActivitiesOfferRequestSchema, options?: AxiosRequestConfig): Promise<AxiosResponse<ToursAndActivitiesOfferResponseSchema>> {
            return ToursAndActivitiesApiFp(configuration).toursOffersSearchPost(body, options).then((request) => request(axios, basePath));
        },
    };
};

/**
 * ToursAndActivitiesApi - object-oriented interface
 * @export
 * @class ToursAndActivitiesApi
 * @extends {BaseAPI}
 */
export class ToursAndActivitiesApi extends BaseAPI {
    /**
     * 
     * @summary Cancel Booking
     * @param {ToursAndActivitiesCancelBookingRequestSchema} body 
     * @param {string} bookingId 
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof ToursAndActivitiesApi
     */
    public async toursBookingsBookingIdCancelPost(body: ToursAndActivitiesCancelBookingRequestSchema, bookingId: string, options?: AxiosRequestConfig) : Promise<AxiosResponse<ToursAndActivitiesCancelBookingResponseSchema>> {
        return ToursAndActivitiesApiFp(this.configuration).toursBookingsBookingIdCancelPost(body, bookingId, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @summary Get Booking Details
     * @param {string} bookingId 
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof ToursAndActivitiesApi
     */
    public async toursBookingsBookingIdGet(bookingId: string, options?: AxiosRequestConfig) : Promise<AxiosResponse<ToursAndActivitiesBookingDetailsResponseSchema>> {
        return ToursAndActivitiesApiFp(this.configuration).toursBookingsBookingIdGet(bookingId, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @summary Create Booking
     * @param {ToursAndActivitiesCreateBookingRequestSchema} body 
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof ToursAndActivitiesApi
     */
    public async toursBookingsPost(body: ToursAndActivitiesCreateBookingRequestSchema, options?: AxiosRequestConfig) : Promise<AxiosResponse<ToursAndActivitiesBookingResponseSchema>> {
        return ToursAndActivitiesApiFp(this.configuration).toursBookingsPost(body, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @summary Get Offer Availability
     * @param {ToursAndActivitiesGetOfferAvailabilityRequest} body 
     * @param {string} offerId 
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof ToursAndActivitiesApi
     */
    public async toursOfferAvailabilityOfferIdPost(body: ToursAndActivitiesGetOfferAvailabilityRequest, offerId: string, options?: AxiosRequestConfig) : Promise<AxiosResponse<ToursAndActivitiesGetOfferAvailabilityResponse>> {
        return ToursAndActivitiesApiFp(this.configuration).toursOfferAvailabilityOfferIdPost(body, offerId, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @summary Get Offer Details
     * @param {string} offerId 
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof ToursAndActivitiesApi
     */
    public async toursOffersOfferIdGet(offerId: string, options?: AxiosRequestConfig) : Promise<AxiosResponse<ToursAndActivitiesOfferDetailsSchema>> {
        return ToursAndActivitiesApiFp(this.configuration).toursOffersOfferIdGet(offerId, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @summary Search Offers
     * @param {ToursAndActivitiesOfferRequestSchema} body 
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof ToursAndActivitiesApi
     */
    public async toursOffersSearchPost(body: ToursAndActivitiesOfferRequestSchema, options?: AxiosRequestConfig) : Promise<AxiosResponse<ToursAndActivitiesOfferResponseSchema>> {
        return ToursAndActivitiesApiFp(this.configuration).toursOffersSearchPost(body, options).then((request) => request(this.axios, this.basePath));
    }
}
