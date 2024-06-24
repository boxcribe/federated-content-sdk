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
import io.swagger.client.model.FlightOfferSegmentPassengerSchema;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.UUID;
/**
 * FlightOfferSegmentSchema
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class FlightOfferSegmentSchema {
  @SerializedName("segment_id")
  private UUID segmentId = null;

  @SerializedName("duration")
  private Integer duration = null;

  @SerializedName("origin_name")
  private String originName = null;

  @SerializedName("origin_code")
  private String originCode = null;

  @SerializedName("origin_latitude")
  private Float originLatitude = null;

  @SerializedName("origin_longitude")
  private Float originLongitude = null;

  @SerializedName("origin_terminal")
  private String originTerminal = null;

  @SerializedName("destination_name")
  private String destinationName = null;

  @SerializedName("destination_code")
  private String destinationCode = null;

  @SerializedName("destination_latitude")
  private Float destinationLatitude = null;

  @SerializedName("destination_longitude")
  private Float destinationLongitude = null;

  @SerializedName("destination_terminal")
  private String destinationTerminal = null;

  @SerializedName("departure_date_time")
  private String departureDateTime = null;

  @SerializedName("arrival_date_time")
  private String arrivalDateTime = null;

  @SerializedName("operating_airline_name")
  private String operatingAirlineName = null;

  @SerializedName("operating_airline_code")
  private String operatingAirlineCode = null;

  @SerializedName("operating_airline_logo")
  private String operatingAirlineLogo = null;

  @SerializedName("marketing_airline_name")
  private String marketingAirlineName = null;

  @SerializedName("marketing_airline_code")
  private String marketingAirlineCode = null;

  @SerializedName("marketing_airline_logo")
  private String marketingAirlineLogo = null;

  @SerializedName("aircraft_name")
  private String aircraftName = null;

  @SerializedName("aircraft_code")
  private String aircraftCode = null;

  @SerializedName("fare_brand_name")
  private String fareBrandName = null;

  @SerializedName("passengers")
  private List<FlightOfferSegmentPassengerSchema> passengers = null;

  public FlightOfferSegmentSchema segmentId(UUID segmentId) {
    this.segmentId = segmentId;
    return this;
  }

   /**
   * Unique identifier for the flight segment.
   * @return segmentId
  **/
  @Schema(description = "Unique identifier for the flight segment.")
  public UUID getSegmentId() {
    return segmentId;
  }

  public void setSegmentId(UUID segmentId) {
    this.segmentId = segmentId;
  }

  public FlightOfferSegmentSchema duration(Integer duration) {
    this.duration = duration;
    return this;
  }

   /**
   * Total duration of the flight segment in minutes.
   * @return duration
  **/
  @Schema(description = "Total duration of the flight segment in minutes.")
  public Integer getDuration() {
    return duration;
  }

  public void setDuration(Integer duration) {
    this.duration = duration;
  }

  public FlightOfferSegmentSchema originName(String originName) {
    this.originName = originName;
    return this;
  }

   /**
   * Name of the origin airport.
   * @return originName
  **/
  @Schema(description = "Name of the origin airport.")
  public String getOriginName() {
    return originName;
  }

  public void setOriginName(String originName) {
    this.originName = originName;
  }

  public FlightOfferSegmentSchema originCode(String originCode) {
    this.originCode = originCode;
    return this;
  }

   /**
   * IATA code of the origin airport.
   * @return originCode
  **/
  @Schema(description = "IATA code of the origin airport.")
  public String getOriginCode() {
    return originCode;
  }

  public void setOriginCode(String originCode) {
    this.originCode = originCode;
  }

  public FlightOfferSegmentSchema originLatitude(Float originLatitude) {
    this.originLatitude = originLatitude;
    return this;
  }

   /**
   * Latitude of the origin airport.
   * @return originLatitude
  **/
  @Schema(description = "Latitude of the origin airport.")
  public Float getOriginLatitude() {
    return originLatitude;
  }

  public void setOriginLatitude(Float originLatitude) {
    this.originLatitude = originLatitude;
  }

  public FlightOfferSegmentSchema originLongitude(Float originLongitude) {
    this.originLongitude = originLongitude;
    return this;
  }

   /**
   * Longitude of the origin airport.
   * @return originLongitude
  **/
  @Schema(description = "Longitude of the origin airport.")
  public Float getOriginLongitude() {
    return originLongitude;
  }

  public void setOriginLongitude(Float originLongitude) {
    this.originLongitude = originLongitude;
  }

  public FlightOfferSegmentSchema originTerminal(String originTerminal) {
    this.originTerminal = originTerminal;
    return this;
  }

   /**
   * Terminal at the origin airport.
   * @return originTerminal
  **/
  @Schema(description = "Terminal at the origin airport.")
  public String getOriginTerminal() {
    return originTerminal;
  }

  public void setOriginTerminal(String originTerminal) {
    this.originTerminal = originTerminal;
  }

  public FlightOfferSegmentSchema destinationName(String destinationName) {
    this.destinationName = destinationName;
    return this;
  }

   /**
   * Name of the destination airport.
   * @return destinationName
  **/
  @Schema(description = "Name of the destination airport.")
  public String getDestinationName() {
    return destinationName;
  }

  public void setDestinationName(String destinationName) {
    this.destinationName = destinationName;
  }

  public FlightOfferSegmentSchema destinationCode(String destinationCode) {
    this.destinationCode = destinationCode;
    return this;
  }

   /**
   * IATA code of the destination airport.
   * @return destinationCode
  **/
  @Schema(description = "IATA code of the destination airport.")
  public String getDestinationCode() {
    return destinationCode;
  }

  public void setDestinationCode(String destinationCode) {
    this.destinationCode = destinationCode;
  }

  public FlightOfferSegmentSchema destinationLatitude(Float destinationLatitude) {
    this.destinationLatitude = destinationLatitude;
    return this;
  }

   /**
   * Latitude of the destination airport.
   * @return destinationLatitude
  **/
  @Schema(description = "Latitude of the destination airport.")
  public Float getDestinationLatitude() {
    return destinationLatitude;
  }

  public void setDestinationLatitude(Float destinationLatitude) {
    this.destinationLatitude = destinationLatitude;
  }

  public FlightOfferSegmentSchema destinationLongitude(Float destinationLongitude) {
    this.destinationLongitude = destinationLongitude;
    return this;
  }

   /**
   * Longitude of the destination airport.
   * @return destinationLongitude
  **/
  @Schema(description = "Longitude of the destination airport.")
  public Float getDestinationLongitude() {
    return destinationLongitude;
  }

  public void setDestinationLongitude(Float destinationLongitude) {
    this.destinationLongitude = destinationLongitude;
  }

  public FlightOfferSegmentSchema destinationTerminal(String destinationTerminal) {
    this.destinationTerminal = destinationTerminal;
    return this;
  }

   /**
   * Terminal at the destination airport.
   * @return destinationTerminal
  **/
  @Schema(description = "Terminal at the destination airport.")
  public String getDestinationTerminal() {
    return destinationTerminal;
  }

  public void setDestinationTerminal(String destinationTerminal) {
    this.destinationTerminal = destinationTerminal;
  }

  public FlightOfferSegmentSchema departureDateTime(String departureDateTime) {
    this.departureDateTime = departureDateTime;
    return this;
  }

   /**
   * Scheduled departure date and time.
   * @return departureDateTime
  **/
  @Schema(description = "Scheduled departure date and time.")
  public String getDepartureDateTime() {
    return departureDateTime;
  }

  public void setDepartureDateTime(String departureDateTime) {
    this.departureDateTime = departureDateTime;
  }

  public FlightOfferSegmentSchema arrivalDateTime(String arrivalDateTime) {
    this.arrivalDateTime = arrivalDateTime;
    return this;
  }

   /**
   * Scheduled arrival date and time.
   * @return arrivalDateTime
  **/
  @Schema(description = "Scheduled arrival date and time.")
  public String getArrivalDateTime() {
    return arrivalDateTime;
  }

  public void setArrivalDateTime(String arrivalDateTime) {
    this.arrivalDateTime = arrivalDateTime;
  }

  public FlightOfferSegmentSchema operatingAirlineName(String operatingAirlineName) {
    this.operatingAirlineName = operatingAirlineName;
    return this;
  }

   /**
   * Name of the operating airline.
   * @return operatingAirlineName
  **/
  @Schema(description = "Name of the operating airline.")
  public String getOperatingAirlineName() {
    return operatingAirlineName;
  }

  public void setOperatingAirlineName(String operatingAirlineName) {
    this.operatingAirlineName = operatingAirlineName;
  }

  public FlightOfferSegmentSchema operatingAirlineCode(String operatingAirlineCode) {
    this.operatingAirlineCode = operatingAirlineCode;
    return this;
  }

   /**
   * Code of the operating airline.
   * @return operatingAirlineCode
  **/
  @Schema(description = "Code of the operating airline.")
  public String getOperatingAirlineCode() {
    return operatingAirlineCode;
  }

  public void setOperatingAirlineCode(String operatingAirlineCode) {
    this.operatingAirlineCode = operatingAirlineCode;
  }

  public FlightOfferSegmentSchema operatingAirlineLogo(String operatingAirlineLogo) {
    this.operatingAirlineLogo = operatingAirlineLogo;
    return this;
  }

   /**
   * Logo of the operating airline.
   * @return operatingAirlineLogo
  **/
  @Schema(description = "Logo of the operating airline.")
  public String getOperatingAirlineLogo() {
    return operatingAirlineLogo;
  }

  public void setOperatingAirlineLogo(String operatingAirlineLogo) {
    this.operatingAirlineLogo = operatingAirlineLogo;
  }

  public FlightOfferSegmentSchema marketingAirlineName(String marketingAirlineName) {
    this.marketingAirlineName = marketingAirlineName;
    return this;
  }

   /**
   * Name of the marketing airline.
   * @return marketingAirlineName
  **/
  @Schema(description = "Name of the marketing airline.")
  public String getMarketingAirlineName() {
    return marketingAirlineName;
  }

  public void setMarketingAirlineName(String marketingAirlineName) {
    this.marketingAirlineName = marketingAirlineName;
  }

  public FlightOfferSegmentSchema marketingAirlineCode(String marketingAirlineCode) {
    this.marketingAirlineCode = marketingAirlineCode;
    return this;
  }

   /**
   * Code of the marketing airline.
   * @return marketingAirlineCode
  **/
  @Schema(description = "Code of the marketing airline.")
  public String getMarketingAirlineCode() {
    return marketingAirlineCode;
  }

  public void setMarketingAirlineCode(String marketingAirlineCode) {
    this.marketingAirlineCode = marketingAirlineCode;
  }

  public FlightOfferSegmentSchema marketingAirlineLogo(String marketingAirlineLogo) {
    this.marketingAirlineLogo = marketingAirlineLogo;
    return this;
  }

   /**
   * Logo of the marketing airline.
   * @return marketingAirlineLogo
  **/
  @Schema(description = "Logo of the marketing airline.")
  public String getMarketingAirlineLogo() {
    return marketingAirlineLogo;
  }

  public void setMarketingAirlineLogo(String marketingAirlineLogo) {
    this.marketingAirlineLogo = marketingAirlineLogo;
  }

  public FlightOfferSegmentSchema aircraftName(String aircraftName) {
    this.aircraftName = aircraftName;
    return this;
  }

   /**
   * Name of the aircraft.
   * @return aircraftName
  **/
  @Schema(description = "Name of the aircraft.")
  public String getAircraftName() {
    return aircraftName;
  }

  public void setAircraftName(String aircraftName) {
    this.aircraftName = aircraftName;
  }

  public FlightOfferSegmentSchema aircraftCode(String aircraftCode) {
    this.aircraftCode = aircraftCode;
    return this;
  }

   /**
   * Code of the aircraft.
   * @return aircraftCode
  **/
  @Schema(description = "Code of the aircraft.")
  public String getAircraftCode() {
    return aircraftCode;
  }

  public void setAircraftCode(String aircraftCode) {
    this.aircraftCode = aircraftCode;
  }

  public FlightOfferSegmentSchema fareBrandName(String fareBrandName) {
    this.fareBrandName = fareBrandName;
    return this;
  }

   /**
   * Name of the fare brand.
   * @return fareBrandName
  **/
  @Schema(description = "Name of the fare brand.")
  public String getFareBrandName() {
    return fareBrandName;
  }

  public void setFareBrandName(String fareBrandName) {
    this.fareBrandName = fareBrandName;
  }

  public FlightOfferSegmentSchema passengers(List<FlightOfferSegmentPassengerSchema> passengers) {
    this.passengers = passengers;
    return this;
  }

  public FlightOfferSegmentSchema addPassengersItem(FlightOfferSegmentPassengerSchema passengersItem) {
    if (this.passengers == null) {
      this.passengers = new ArrayList<FlightOfferSegmentPassengerSchema>();
    }
    this.passengers.add(passengersItem);
    return this;
  }

   /**
   * Array of FlightOfferSegmentPassengerSchema detailing passenger information.
   * @return passengers
  **/
  @Schema(description = "Array of FlightOfferSegmentPassengerSchema detailing passenger information.")
  public List<FlightOfferSegmentPassengerSchema> getPassengers() {
    return passengers;
  }

  public void setPassengers(List<FlightOfferSegmentPassengerSchema> passengers) {
    this.passengers = passengers;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FlightOfferSegmentSchema flightOfferSegmentSchema = (FlightOfferSegmentSchema) o;
    return Objects.equals(this.segmentId, flightOfferSegmentSchema.segmentId) &&
        Objects.equals(this.duration, flightOfferSegmentSchema.duration) &&
        Objects.equals(this.originName, flightOfferSegmentSchema.originName) &&
        Objects.equals(this.originCode, flightOfferSegmentSchema.originCode) &&
        Objects.equals(this.originLatitude, flightOfferSegmentSchema.originLatitude) &&
        Objects.equals(this.originLongitude, flightOfferSegmentSchema.originLongitude) &&
        Objects.equals(this.originTerminal, flightOfferSegmentSchema.originTerminal) &&
        Objects.equals(this.destinationName, flightOfferSegmentSchema.destinationName) &&
        Objects.equals(this.destinationCode, flightOfferSegmentSchema.destinationCode) &&
        Objects.equals(this.destinationLatitude, flightOfferSegmentSchema.destinationLatitude) &&
        Objects.equals(this.destinationLongitude, flightOfferSegmentSchema.destinationLongitude) &&
        Objects.equals(this.destinationTerminal, flightOfferSegmentSchema.destinationTerminal) &&
        Objects.equals(this.departureDateTime, flightOfferSegmentSchema.departureDateTime) &&
        Objects.equals(this.arrivalDateTime, flightOfferSegmentSchema.arrivalDateTime) &&
        Objects.equals(this.operatingAirlineName, flightOfferSegmentSchema.operatingAirlineName) &&
        Objects.equals(this.operatingAirlineCode, flightOfferSegmentSchema.operatingAirlineCode) &&
        Objects.equals(this.operatingAirlineLogo, flightOfferSegmentSchema.operatingAirlineLogo) &&
        Objects.equals(this.marketingAirlineName, flightOfferSegmentSchema.marketingAirlineName) &&
        Objects.equals(this.marketingAirlineCode, flightOfferSegmentSchema.marketingAirlineCode) &&
        Objects.equals(this.marketingAirlineLogo, flightOfferSegmentSchema.marketingAirlineLogo) &&
        Objects.equals(this.aircraftName, flightOfferSegmentSchema.aircraftName) &&
        Objects.equals(this.aircraftCode, flightOfferSegmentSchema.aircraftCode) &&
        Objects.equals(this.fareBrandName, flightOfferSegmentSchema.fareBrandName) &&
        Objects.equals(this.passengers, flightOfferSegmentSchema.passengers);
  }

  @Override
  public int hashCode() {
    return Objects.hash(segmentId, duration, originName, originCode, originLatitude, originLongitude, originTerminal, destinationName, destinationCode, destinationLatitude, destinationLongitude, destinationTerminal, departureDateTime, arrivalDateTime, operatingAirlineName, operatingAirlineCode, operatingAirlineLogo, marketingAirlineName, marketingAirlineCode, marketingAirlineLogo, aircraftName, aircraftCode, fareBrandName, passengers);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FlightOfferSegmentSchema {\n");
    
    sb.append("    segmentId: ").append(toIndentedString(segmentId)).append("\n");
    sb.append("    duration: ").append(toIndentedString(duration)).append("\n");
    sb.append("    originName: ").append(toIndentedString(originName)).append("\n");
    sb.append("    originCode: ").append(toIndentedString(originCode)).append("\n");
    sb.append("    originLatitude: ").append(toIndentedString(originLatitude)).append("\n");
    sb.append("    originLongitude: ").append(toIndentedString(originLongitude)).append("\n");
    sb.append("    originTerminal: ").append(toIndentedString(originTerminal)).append("\n");
    sb.append("    destinationName: ").append(toIndentedString(destinationName)).append("\n");
    sb.append("    destinationCode: ").append(toIndentedString(destinationCode)).append("\n");
    sb.append("    destinationLatitude: ").append(toIndentedString(destinationLatitude)).append("\n");
    sb.append("    destinationLongitude: ").append(toIndentedString(destinationLongitude)).append("\n");
    sb.append("    destinationTerminal: ").append(toIndentedString(destinationTerminal)).append("\n");
    sb.append("    departureDateTime: ").append(toIndentedString(departureDateTime)).append("\n");
    sb.append("    arrivalDateTime: ").append(toIndentedString(arrivalDateTime)).append("\n");
    sb.append("    operatingAirlineName: ").append(toIndentedString(operatingAirlineName)).append("\n");
    sb.append("    operatingAirlineCode: ").append(toIndentedString(operatingAirlineCode)).append("\n");
    sb.append("    operatingAirlineLogo: ").append(toIndentedString(operatingAirlineLogo)).append("\n");
    sb.append("    marketingAirlineName: ").append(toIndentedString(marketingAirlineName)).append("\n");
    sb.append("    marketingAirlineCode: ").append(toIndentedString(marketingAirlineCode)).append("\n");
    sb.append("    marketingAirlineLogo: ").append(toIndentedString(marketingAirlineLogo)).append("\n");
    sb.append("    aircraftName: ").append(toIndentedString(aircraftName)).append("\n");
    sb.append("    aircraftCode: ").append(toIndentedString(aircraftCode)).append("\n");
    sb.append("    fareBrandName: ").append(toIndentedString(fareBrandName)).append("\n");
    sb.append("    passengers: ").append(toIndentedString(passengers)).append("\n");
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