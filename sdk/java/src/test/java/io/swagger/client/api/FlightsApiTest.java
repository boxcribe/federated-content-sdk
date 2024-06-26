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

import io.swagger.client.model.Error;
import io.swagger.client.model.FlightBookingDetailsRequestSchema;
import io.swagger.client.model.FlightBookingResponseSchema;
import io.swagger.client.model.FlightCancelBookingRequestSchema;
import io.swagger.client.model.FlightCancelBookingResponseSchema;
import io.swagger.client.model.FlightCreateBookingRequestSchema;
import io.swagger.client.model.FlightGetBookingDetailsResponseSchema;
import io.swagger.client.model.FlightOfferDetailsRequestSchema;
import io.swagger.client.model.FlightOfferDetailsResponseSchema;
import io.swagger.client.model.FlightOfferRequestSchema;
import io.swagger.client.model.FlightOfferResponseSchema;
import io.swagger.client.model.FlightOfferSeatmapsRequestSchema;
import io.swagger.client.model.FlightOfferSeatmapsResponseSchema;
import org.junit.Test;
import org.junit.Ignore;


import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;


/**
 * API tests for FlightsApi
 */
@Ignore
public class FlightsApiTest {

    private final FlightsApi api = new FlightsApi();

    /**
     * Cancel Booking
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void flightsBookingsBookingIdCancelPostTest() throws Exception {
        FlightCancelBookingRequestSchema body = null;
        FlightCancelBookingResponseSchema response = api.flightsBookingsBookingIdCancelPost(body);

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
    public void flightsBookingsBookingIdGetTest() throws Exception {
        FlightBookingDetailsRequestSchema body = null;
        FlightGetBookingDetailsResponseSchema response = api.flightsBookingsBookingIdGet(body);

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
    public void flightsBookingsPostTest() throws Exception {
        FlightCreateBookingRequestSchema body = null;
        FlightBookingResponseSchema response = api.flightsBookingsPost(body);

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
    public void flightsOffersOfferIdGetTest() throws Exception {
        FlightOfferDetailsRequestSchema body = null;
        FlightOfferDetailsResponseSchema response = api.flightsOffersOfferIdGet(body);

        // TODO: test validations
    }
    /**
     * Get Offer Seatmaps
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void flightsOffersOfferIdSeatmapsGetTest() throws Exception {
        FlightOfferSeatmapsRequestSchema body = null;
        FlightOfferSeatmapsResponseSchema response = api.flightsOffersOfferIdSeatmapsGet(body);

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
    public void flightsOffersSearchPostTest() throws Exception {
        FlightOfferRequestSchema body = null;
        FlightOfferResponseSchema response = api.flightsOffersSearchPost(body);

        // TODO: test validations
    }
}
