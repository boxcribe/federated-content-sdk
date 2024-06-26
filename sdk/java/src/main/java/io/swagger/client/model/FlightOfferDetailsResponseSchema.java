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
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.math.BigDecimal;
import java.util.UUID;
/**
 * FlightOfferDetailsResponseSchema
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class FlightOfferDetailsResponseSchema {
  @SerializedName("offer_id")
  private UUID offerId = null;

  @SerializedName("supplier_offer_id")
  private UUID supplierOfferId = null;

  @SerializedName("offer_index")
  private Integer offerIndex = null;

  @SerializedName("offer_price")
  private BigDecimal offerPrice = null;

  @SerializedName("offer_currency")
  private String offerCurrency = null;

  @SerializedName("offer_cancelation_policies")
  private String offerCancelationPolicies = null;

  @SerializedName("offer_airline_name")
  private String offerAirlineName = null;

  @SerializedName("offer_airline_code")
  private String offerAirlineCode = null;

  @SerializedName("offer_airline_logo")
  private String offerAirlineLogo = null;

  public FlightOfferDetailsResponseSchema offerId(UUID offerId) {
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

  public FlightOfferDetailsResponseSchema supplierOfferId(UUID supplierOfferId) {
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

  public FlightOfferDetailsResponseSchema offerIndex(Integer offerIndex) {
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

  public FlightOfferDetailsResponseSchema offerPrice(BigDecimal offerPrice) {
    this.offerPrice = offerPrice;
    return this;
  }

   /**
   * Price of the offer.
   * @return offerPrice
  **/
  @Schema(description = "Price of the offer.")
  public BigDecimal getOfferPrice() {
    return offerPrice;
  }

  public void setOfferPrice(BigDecimal offerPrice) {
    this.offerPrice = offerPrice;
  }

  public FlightOfferDetailsResponseSchema offerCurrency(String offerCurrency) {
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

  public FlightOfferDetailsResponseSchema offerCancelationPolicies(String offerCancelationPolicies) {
    this.offerCancelationPolicies = offerCancelationPolicies;
    return this;
  }

   /**
   * Cancellation policies applicable to the offer.
   * @return offerCancelationPolicies
  **/
  @Schema(description = "Cancellation policies applicable to the offer.")
  public String getOfferCancelationPolicies() {
    return offerCancelationPolicies;
  }

  public void setOfferCancelationPolicies(String offerCancelationPolicies) {
    this.offerCancelationPolicies = offerCancelationPolicies;
  }

  public FlightOfferDetailsResponseSchema offerAirlineName(String offerAirlineName) {
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

  public FlightOfferDetailsResponseSchema offerAirlineCode(String offerAirlineCode) {
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

  public FlightOfferDetailsResponseSchema offerAirlineLogo(String offerAirlineLogo) {
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


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FlightOfferDetailsResponseSchema flightOfferDetailsResponseSchema = (FlightOfferDetailsResponseSchema) o;
    return Objects.equals(this.offerId, flightOfferDetailsResponseSchema.offerId) &&
        Objects.equals(this.supplierOfferId, flightOfferDetailsResponseSchema.supplierOfferId) &&
        Objects.equals(this.offerIndex, flightOfferDetailsResponseSchema.offerIndex) &&
        Objects.equals(this.offerPrice, flightOfferDetailsResponseSchema.offerPrice) &&
        Objects.equals(this.offerCurrency, flightOfferDetailsResponseSchema.offerCurrency) &&
        Objects.equals(this.offerCancelationPolicies, flightOfferDetailsResponseSchema.offerCancelationPolicies) &&
        Objects.equals(this.offerAirlineName, flightOfferDetailsResponseSchema.offerAirlineName) &&
        Objects.equals(this.offerAirlineCode, flightOfferDetailsResponseSchema.offerAirlineCode) &&
        Objects.equals(this.offerAirlineLogo, flightOfferDetailsResponseSchema.offerAirlineLogo);
  }

  @Override
  public int hashCode() {
    return Objects.hash(offerId, supplierOfferId, offerIndex, offerPrice, offerCurrency, offerCancelationPolicies, offerAirlineName, offerAirlineCode, offerAirlineLogo);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FlightOfferDetailsResponseSchema {\n");
    
    sb.append("    offerId: ").append(toIndentedString(offerId)).append("\n");
    sb.append("    supplierOfferId: ").append(toIndentedString(supplierOfferId)).append("\n");
    sb.append("    offerIndex: ").append(toIndentedString(offerIndex)).append("\n");
    sb.append("    offerPrice: ").append(toIndentedString(offerPrice)).append("\n");
    sb.append("    offerCurrency: ").append(toIndentedString(offerCurrency)).append("\n");
    sb.append("    offerCancelationPolicies: ").append(toIndentedString(offerCancelationPolicies)).append("\n");
    sb.append("    offerAirlineName: ").append(toIndentedString(offerAirlineName)).append("\n");
    sb.append("    offerAirlineCode: ").append(toIndentedString(offerAirlineCode)).append("\n");
    sb.append("    offerAirlineLogo: ").append(toIndentedString(offerAirlineLogo)).append("\n");
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
