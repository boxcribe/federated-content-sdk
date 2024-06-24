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

package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.client.model.OfferPassengerExtraBagSchema;
import io.swagger.client.model.OfferPassengerSelectedSeatSchema;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.UUID;
/**
 * FlightOfferDetailsRequestSchemaRepriceRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class FlightOfferDetailsRequestSchemaRepriceRequest {
  @SerializedName("offer_id")
  private UUID offerId = null;

  @SerializedName("seats")
  private List<OfferPassengerSelectedSeatSchema> seats = null;

  @SerializedName("bags")
  private List<OfferPassengerExtraBagSchema> bags = null;

  public FlightOfferDetailsRequestSchemaRepriceRequest offerId(UUID offerId) {
    this.offerId = offerId;
    return this;
  }

   /**
   * Unique identifier of the flight offer to be repriced.
   * @return offerId
  **/
  @Schema(description = "Unique identifier of the flight offer to be repriced.")
  public UUID getOfferId() {
    return offerId;
  }

  public void setOfferId(UUID offerId) {
    this.offerId = offerId;
  }

  public FlightOfferDetailsRequestSchemaRepriceRequest seats(List<OfferPassengerSelectedSeatSchema> seats) {
    this.seats = seats;
    return this;
  }

  public FlightOfferDetailsRequestSchemaRepriceRequest addSeatsItem(OfferPassengerSelectedSeatSchema seatsItem) {
    if (this.seats == null) {
      this.seats = new ArrayList<OfferPassengerSelectedSeatSchema>();
    }
    this.seats.add(seatsItem);
    return this;
  }

   /**
   * Array of passenger seats, each defined in OfferPassengerSelectedSeatSchema.
   * @return seats
  **/
  @Schema(description = "Array of passenger seats, each defined in OfferPassengerSelectedSeatSchema.")
  public List<OfferPassengerSelectedSeatSchema> getSeats() {
    return seats;
  }

  public void setSeats(List<OfferPassengerSelectedSeatSchema> seats) {
    this.seats = seats;
  }

  public FlightOfferDetailsRequestSchemaRepriceRequest bags(List<OfferPassengerExtraBagSchema> bags) {
    this.bags = bags;
    return this;
  }

  public FlightOfferDetailsRequestSchemaRepriceRequest addBagsItem(OfferPassengerExtraBagSchema bagsItem) {
    if (this.bags == null) {
      this.bags = new ArrayList<OfferPassengerExtraBagSchema>();
    }
    this.bags.add(bagsItem);
    return this;
  }

   /**
   * Array of extra baggage, each defined in OfferPassengerExtraBagSchema.
   * @return bags
  **/
  @Schema(description = "Array of extra baggage, each defined in OfferPassengerExtraBagSchema.")
  public List<OfferPassengerExtraBagSchema> getBags() {
    return bags;
  }

  public void setBags(List<OfferPassengerExtraBagSchema> bags) {
    this.bags = bags;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FlightOfferDetailsRequestSchemaRepriceRequest flightOfferDetailsRequestSchemaRepriceRequest = (FlightOfferDetailsRequestSchemaRepriceRequest) o;
    return Objects.equals(this.offerId, flightOfferDetailsRequestSchemaRepriceRequest.offerId) &&
        Objects.equals(this.seats, flightOfferDetailsRequestSchemaRepriceRequest.seats) &&
        Objects.equals(this.bags, flightOfferDetailsRequestSchemaRepriceRequest.bags);
  }

  @Override
  public int hashCode() {
    return Objects.hash(offerId, seats, bags);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FlightOfferDetailsRequestSchemaRepriceRequest {\n");
    
    sb.append("    offerId: ").append(toIndentedString(offerId)).append("\n");
    sb.append("    seats: ").append(toIndentedString(seats)).append("\n");
    sb.append("    bags: ").append(toIndentedString(bags)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}