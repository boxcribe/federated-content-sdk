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
import io.swagger.client.model.FlightOfferSeatmapSchema;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * FlightOfferSeatmapsResponseSchema
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class FlightOfferSeatmapsResponseSchema {
  @SerializedName("seatmaps")
  private List<FlightOfferSeatmapSchema> seatmaps = null;

  public FlightOfferSeatmapsResponseSchema seatmaps(List<FlightOfferSeatmapSchema> seatmaps) {
    this.seatmaps = seatmaps;
    return this;
  }

  public FlightOfferSeatmapsResponseSchema addSeatmapsItem(FlightOfferSeatmapSchema seatmapsItem) {
    if (this.seatmaps == null) {
      this.seatmaps = new ArrayList<FlightOfferSeatmapSchema>();
    }
    this.seatmaps.add(seatmapsItem);
    return this;
  }

   /**
   * Array of FlightOfferSeatmapSchema detailing available seatmaps.
   * @return seatmaps
  **/
  @Schema(description = "Array of FlightOfferSeatmapSchema detailing available seatmaps.")
  public List<FlightOfferSeatmapSchema> getSeatmaps() {
    return seatmaps;
  }

  public void setSeatmaps(List<FlightOfferSeatmapSchema> seatmaps) {
    this.seatmaps = seatmaps;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FlightOfferSeatmapsResponseSchema flightOfferSeatmapsResponseSchema = (FlightOfferSeatmapsResponseSchema) o;
    return Objects.equals(this.seatmaps, flightOfferSeatmapsResponseSchema.seatmaps);
  }

  @Override
  public int hashCode() {
    return Objects.hash(seatmaps);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FlightOfferSeatmapsResponseSchema {\n");
    
    sb.append("    seatmaps: ").append(toIndentedString(seatmaps)).append("\n");
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
