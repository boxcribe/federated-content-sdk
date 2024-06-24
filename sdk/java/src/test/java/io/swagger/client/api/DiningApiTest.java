/*
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

package io.swagger.client.api;

import io.swagger.client.model.DiningBookingDetailsResponseSchema;
import io.swagger.client.model.DiningBookingResponseSchema;
import io.swagger.client.model.DiningCancelBookingRequestSchema;
import io.swagger.client.model.DiningCancelBookingResponseSchema;
import io.swagger.client.model.DiningCreateBookingRequestSchema;
import io.swagger.client.model.DiningGetOfferAvailabilityRequest;
import io.swagger.client.model.DiningGetOfferAvailabilityResponse;
import io.swagger.client.model.DiningOfferDetailsSchema;
import io.swagger.client.model.DiningOfferRequestSchema;
import io.swagger.client.model.DiningOfferResponseSchema;
import io.swagger.client.model.Error;
import org.junit.Test;
import org.junit.Ignore;


import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;


/**
 * API tests for DiningApi
 */
@Ignore
public class DiningApiTest {

    private final DiningApi api = new DiningApi();

    /**
     * Cancel Booking
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void diningBookingsBookingIdCancelPostTest() throws Exception {
        DiningCancelBookingRequestSchema body = null;
        String bookingId = null;
        DiningCancelBookingResponseSchema response = api.diningBookingsBookingIdCancelPost(body, bookingId);

        // TODO: test validations
    }
    /**
     * Get Booking Details
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void diningBookingsBookingIdGetTest() throws Exception {
        String bookingId = null;
        DiningBookingDetailsResponseSchema response = api.diningBookingsBookingIdGet(bookingId);

        // TODO: test validations
    }
    /**
     * Create Booking
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void diningBookingsPostTest() throws Exception {
        DiningCreateBookingRequestSchema body = null;
        DiningBookingResponseSchema response = api.diningBookingsPost(body);

        // TODO: test validations
    }
    /**
     * Get Offer Availability
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void diningOfferAvailabilityOfferIdGetTest() throws Exception {
        DiningGetOfferAvailabilityRequest body = null;
        String offerId = null;
        DiningGetOfferAvailabilityResponse response = api.diningOfferAvailabilityOfferIdGet(body, offerId);

        // TODO: test validations
    }
    /**
     * Get Offer Details
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void diningOffersOfferIdGetTest() throws Exception {
        String offerId = null;
        DiningOfferDetailsSchema response = api.diningOffersOfferIdGet(offerId);

        // TODO: test validations
    }
    /**
     * Search Offers
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void diningOffersSearchPostTest() throws Exception {
        DiningOfferRequestSchema body = null;
        DiningOfferResponseSchema response = api.diningOffersSearchPost(body);

        // TODO: test validations
    }
}
