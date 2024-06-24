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
import io.swagger.client.model.FlightLegOfferRequestSchema;
import io.swagger.client.model.FlightPassengerOfferRequestSchema;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.UUID;
/**
 * FlightOfferResponseItemSchema
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class FlightOfferResponseItemSchema {
  @SerializedName("offer_id")
  private UUID offerId = null;

  @SerializedName("supplier_offer_id")
  private UUID supplierOfferId = null;

  @SerializedName("offer_index")
  private Integer offerIndex = null;

  @SerializedName("offer_price")
  private Double offerPrice = null;

  @SerializedName("offer_currency")
  private String offerCurrency = null;

  @SerializedName("offer_cancelation_policies")
  private Map<String, Object> offerCancelationPolicies = null;

  @SerializedName("offer_airline_name")
  private String offerAirlineName = null;

  @SerializedName("offer_airline_code")
  private String offerAirlineCode = null;

  @SerializedName("offer_airline_logo")
  private String offerAirlineLogo = null;

  @SerializedName("legs")
  private List<FlightLegOfferRequestSchema> legs = null;

  @SerializedName("passengers")
  private List<FlightPassengerOfferRequestSchema> passengers = null;

  @SerializedName("private_fare_codes")
  private List<String> privateFareCodes = null;

  public FlightOfferResponseItemSchema offerId(UUID offerId) {
    this.offerId = offerId;
    return this;
  }

   /**
   * Unique identifier for the offer.
   * @return offerId
  **/
  @Schema(description = "Unique identifier for the offer.")
  public UUID getOfferId() {
    return offerId;
  }

  public void setOfferId(UUID offerId) {
    this.offerId = offerId;
  }

  public FlightOfferResponseItemSchema supplierOfferId(UUID supplierOfferId) {
    this.supplierOfferId = supplierOfferId;
    return this;
  }

   /**
   * Unique identifier for the supplier’s offer.
   * @return supplierOfferId
  **/
  @Schema(description = "Unique identifier for the supplier’s offer.")
  public UUID getSupplierOfferId() {
    return supplierOfferId;
  }

  public void setSupplierOfferId(UUID supplierOfferId) {
    this.supplierOfferId = supplierOfferId;
  }

  public FlightOfferResponseItemSchema offerIndex(Integer offerIndex) {
    this.offerIndex = offerIndex;
    return this;
  }

   /**
   * Index of the offer for sorting purposes.
   * @return offerIndex
  **/
  @Schema(description = "Index of the offer for sorting purposes.")
  public Integer getOfferIndex() {
    return offerIndex;
  }

  public void setOfferIndex(Integer offerIndex) {
    this.offerIndex = offerIndex;
  }

  public FlightOfferResponseItemSchema offerPrice(Double offerPrice) {
    this.offerPrice = offerPrice;
    return this;
  }

   /**
   * Price of the offer.
   * @return offerPrice
  **/
  @Schema(description = "Price of the offer.")
  public Double getOfferPrice() {
    return offerPrice;
  }

  public void setOfferPrice(Double offerPrice) {
    this.offerPrice = offerPrice;
  }

  public FlightOfferResponseItemSchema offerCurrency(String offerCurrency) {
    this.offerCurrency = offerCurrency;
    return this;
  }

   /**
   * Currency of the offer price.
   * @return offerCurrency
  **/
  @Schema(description = "Currency of the offer price.")
  public String getOfferCurrency() {
    return offerCurrency;
  }

  public void setOfferCurrency(String offerCurrency) {
    this.offerCurrency = offerCurrency;
  }

  public FlightOfferResponseItemSchema offerCancelationPolicies(Map<String, Object> offerCancelationPolicies) {
    this.offerCancelationPolicies = offerCancelationPolicies;
    return this;
  }

  public FlightOfferResponseItemSchema putOfferCancelationPoliciesItem(String key, Object offerCancelationPoliciesItem) {
    if (this.offerCancelationPolicies == null) {
      this.offerCancelationPolicies = new HashMap<String, Object>();
    }
    this.offerCancelationPolicies.put(key, offerCancelationPoliciesItem);
    return this;
  }

   /**
   * Cancellation policies applicable to the offer.
   * @return offerCancelationPolicies
  **/
  @Schema(description = "Cancellation policies applicable to the offer.")
  public Map<String, Object> getOfferCancelationPolicies() {
    return offerCancelationPolicies;
  }

  public void setOfferCancelationPolicies(Map<String, Object> offerCancelationPolicies) {
    this.offerCancelationPolicies = offerCancelationPolicies;
  }

  public FlightOfferResponseItemSchema offerAirlineName(String offerAirlineName) {
    this.offerAirlineName = offerAirlineName;
    return this;
  }

   /**
   * Name of the airline providing the offer.
   * @return offerAirlineName
  **/
  @Schema(description = "Name of the airline providing the offer.")
  public String getOfferAirlineName() {
    return offerAirlineName;
  }

  public void setOfferAirlineName(String offerAirlineName) {
    this.offerAirlineName = offerAirlineName;
  }

  public FlightOfferResponseItemSchema offerAirlineCode(String offerAirlineCode) {
    this.offerAirlineCode = offerAirlineCode;
    return this;
  }

   /**
   * Code of the airline providing the offer.
   * @return offerAirlineCode
  **/
  @Schema(description = "Code of the airline providing the offer.")
  public String getOfferAirlineCode() {
    return offerAirlineCode;
  }

  public void setOfferAirlineCode(String offerAirlineCode) {
    this.offerAirlineCode = offerAirlineCode;
  }

  public FlightOfferResponseItemSchema offerAirlineLogo(String offerAirlineLogo) {
    this.offerAirlineLogo = offerAirlineLogo;
    return this;
  }

   /**
   * Logo URL of the airline.
   * @return offerAirlineLogo
  **/
  @Schema(description = "Logo URL of the airline.")
  public String getOfferAirlineLogo() {
    return offerAirlineLogo;
  }

  public void setOfferAirlineLogo(String offerAirlineLogo) {
    this.offerAirlineLogo = offerAirlineLogo;
  }

  public FlightOfferResponseItemSchema legs(List<FlightLegOfferRequestSchema> legs) {
    this.legs = legs;
    return this;
  }

  public FlightOfferResponseItemSchema addLegsItem(FlightLegOfferRequestSchema legsItem) {
    if (this.legs == null) {
      this.legs = new ArrayList<FlightLegOfferRequestSchema>();
    }
    this.legs.add(legsItem);
    return this;
  }

   /**
   * Array of flight legs, each described in FlightLegOfferRequestSchema.
   * @return legs
  **/
  @Schema(description = "Array of flight legs, each described in FlightLegOfferRequestSchema.")
  public List<FlightLegOfferRequestSchema> getLegs() {
    return legs;
  }

  public void setLegs(List<FlightLegOfferRequestSchema> legs) {
    this.legs = legs;
  }

  public FlightOfferResponseItemSchema passengers(List<FlightPassengerOfferRequestSchema> passengers) {
    this.passengers = passengers;
    return this;
  }

  public FlightOfferResponseItemSchema addPassengersItem(FlightPassengerOfferRequestSchema passengersItem) {
    if (this.passengers == null) {
      this.passengers = new ArrayList<FlightPassengerOfferRequestSchema>();
    }
    this.passengers.add(passengersItem);
    return this;
  }

   /**
   * Array of passengers, each described in FlightPassengerOfferRequestSchema.
   * @return passengers
  **/
  @Schema(description = "Array of passengers, each described in FlightPassengerOfferRequestSchema.")
  public List<FlightPassengerOfferRequestSchema> getPassengers() {
    return passengers;
  }

  public void setPassengers(List<FlightPassengerOfferRequestSchema> passengers) {
    this.passengers = passengers;
  }

  public FlightOfferResponseItemSchema privateFareCodes(List<String> privateFareCodes) {
    this.privateFareCodes = privateFareCodes;
    return this;
  }

  public FlightOfferResponseItemSchema addPrivateFareCodesItem(String privateFareCodesItem) {
    if (this.privateFareCodes == null) {
      this.privateFareCodes = new ArrayList<String>();
    }
    this.privateFareCodes.add(privateFareCodesItem);
    return this;
  }

   /**
   * Array of codes for accessing special negotiated fares.
   * @return privateFareCodes
  **/
  @Schema(description = "Array of codes for accessing special negotiated fares.")
  public List<String> getPrivateFareCodes() {
    return privateFareCodes;
  }

  public void setPrivateFareCodes(List<String> privateFareCodes) {
    this.privateFareCodes = privateFareCodes;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FlightOfferResponseItemSchema flightOfferResponseItemSchema = (FlightOfferResponseItemSchema) o;
    return Objects.equals(this.offerId, flightOfferResponseItemSchema.offerId) &&
        Objects.equals(this.supplierOfferId, flightOfferResponseItemSchema.supplierOfferId) &&
        Objects.equals(this.offerIndex, flightOfferResponseItemSchema.offerIndex) &&
        Objects.equals(this.offerPrice, flightOfferResponseItemSchema.offerPrice) &&
        Objects.equals(this.offerCurrency, flightOfferResponseItemSchema.offerCurrency) &&
        Objects.equals(this.offerCancelationPolicies, flightOfferResponseItemSchema.offerCancelationPolicies) &&
        Objects.equals(this.offerAirlineName, flightOfferResponseItemSchema.offerAirlineName) &&
        Objects.equals(this.offerAirlineCode, flightOfferResponseItemSchema.offerAirlineCode) &&
        Objects.equals(this.offerAirlineLogo, flightOfferResponseItemSchema.offerAirlineLogo) &&
        Objects.equals(this.legs, flightOfferResponseItemSchema.legs) &&
        Objects.equals(this.passengers, flightOfferResponseItemSchema.passengers) &&
        Objects.equals(this.privateFareCodes, flightOfferResponseItemSchema.privateFareCodes);
  }

  @Override
  public int hashCode() {
    return Objects.hash(offerId, supplierOfferId, offerIndex, offerPrice, offerCurrency, offerCancelationPolicies, offerAirlineName, offerAirlineCode, offerAirlineLogo, legs, passengers, privateFareCodes);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FlightOfferResponseItemSchema {\n");
    
    sb.append("    offerId: ").append(toIndentedString(offerId)).append("\n");
    sb.append("    supplierOfferId: ").append(toIndentedString(supplierOfferId)).append("\n");
    sb.append("    offerIndex: ").append(toIndentedString(offerIndex)).append("\n");
    sb.append("    offerPrice: ").append(toIndentedString(offerPrice)).append("\n");
    sb.append("    offerCurrency: ").append(toIndentedString(offerCurrency)).append("\n");
    sb.append("    offerCancelationPolicies: ").append(toIndentedString(offerCancelationPolicies)).append("\n");
    sb.append("    offerAirlineName: ").append(toIndentedString(offerAirlineName)).append("\n");
    sb.append("    offerAirlineCode: ").append(toIndentedString(offerAirlineCode)).append("\n");
    sb.append("    offerAirlineLogo: ").append(toIndentedString(offerAirlineLogo)).append("\n");
    sb.append("    legs: ").append(toIndentedString(legs)).append("\n");
    sb.append("    passengers: ").append(toIndentedString(passengers)).append("\n");
    sb.append("    privateFareCodes: ").append(toIndentedString(privateFareCodes)).append("\n");
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
