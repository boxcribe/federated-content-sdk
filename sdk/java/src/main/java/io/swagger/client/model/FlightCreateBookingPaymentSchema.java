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
/**
 * FlightCreateBookingPaymentSchema
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class FlightCreateBookingPaymentSchema {
  @SerializedName("card_number")
  private String cardNumber = null;

  @SerializedName("card_expiration_month")
  private Integer cardExpirationMonth = null;

  @SerializedName("card_expiration_year")
  private Integer cardExpirationYear = null;

  @SerializedName("card_cvv")
  private String cardCvv = null;

  @SerializedName("card_name")
  private String cardName = null;

  @SerializedName("billing_address")
  private String billingAddress = null;

  @SerializedName("billing_city")
  private String billingCity = null;

  @SerializedName("billing_state")
  private String billingState = null;

  @SerializedName("billing_zip")
  private String billingZip = null;

  @SerializedName("billing_country")
  private String billingCountry = null;

  public FlightCreateBookingPaymentSchema cardNumber(String cardNumber) {
    this.cardNumber = cardNumber;
    return this;
  }

   /**
   * Credit card number used for the payment.
   * @return cardNumber
  **/
  @Schema(description = "Credit card number used for the payment.")
  public String getCardNumber() {
    return cardNumber;
  }

  public void setCardNumber(String cardNumber) {
    this.cardNumber = cardNumber;
  }

  public FlightCreateBookingPaymentSchema cardExpirationMonth(Integer cardExpirationMonth) {
    this.cardExpirationMonth = cardExpirationMonth;
    return this;
  }

   /**
   * Expiration month of the credit card.
   * @return cardExpirationMonth
  **/
  @Schema(description = "Expiration month of the credit card.")
  public Integer getCardExpirationMonth() {
    return cardExpirationMonth;
  }

  public void setCardExpirationMonth(Integer cardExpirationMonth) {
    this.cardExpirationMonth = cardExpirationMonth;
  }

  public FlightCreateBookingPaymentSchema cardExpirationYear(Integer cardExpirationYear) {
    this.cardExpirationYear = cardExpirationYear;
    return this;
  }

   /**
   * Expiration year of the credit card.
   * @return cardExpirationYear
  **/
  @Schema(description = "Expiration year of the credit card.")
  public Integer getCardExpirationYear() {
    return cardExpirationYear;
  }

  public void setCardExpirationYear(Integer cardExpirationYear) {
    this.cardExpirationYear = cardExpirationYear;
  }

  public FlightCreateBookingPaymentSchema cardCvv(String cardCvv) {
    this.cardCvv = cardCvv;
    return this;
  }

   /**
   * CVV of the credit card.
   * @return cardCvv
  **/
  @Schema(description = "CVV of the credit card.")
  public String getCardCvv() {
    return cardCvv;
  }

  public void setCardCvv(String cardCvv) {
    this.cardCvv = cardCvv;
  }

  public FlightCreateBookingPaymentSchema cardName(String cardName) {
    this.cardName = cardName;
    return this;
  }

   /**
   * Name on the credit card.
   * @return cardName
  **/
  @Schema(description = "Name on the credit card.")
  public String getCardName() {
    return cardName;
  }

  public void setCardName(String cardName) {
    this.cardName = cardName;
  }

  public FlightCreateBookingPaymentSchema billingAddress(String billingAddress) {
    this.billingAddress = billingAddress;
    return this;
  }

   /**
   * Billing address associated with the credit card.
   * @return billingAddress
  **/
  @Schema(description = "Billing address associated with the credit card.")
  public String getBillingAddress() {
    return billingAddress;
  }

  public void setBillingAddress(String billingAddress) {
    this.billingAddress = billingAddress;
  }

  public FlightCreateBookingPaymentSchema billingCity(String billingCity) {
    this.billingCity = billingCity;
    return this;
  }

   /**
   * City part of the billing address.
   * @return billingCity
  **/
  @Schema(description = "City part of the billing address.")
  public String getBillingCity() {
    return billingCity;
  }

  public void setBillingCity(String billingCity) {
    this.billingCity = billingCity;
  }

  public FlightCreateBookingPaymentSchema billingState(String billingState) {
    this.billingState = billingState;
    return this;
  }

   /**
   * State part of the billing address.
   * @return billingState
  **/
  @Schema(description = "State part of the billing address.")
  public String getBillingState() {
    return billingState;
  }

  public void setBillingState(String billingState) {
    this.billingState = billingState;
  }

  public FlightCreateBookingPaymentSchema billingZip(String billingZip) {
    this.billingZip = billingZip;
    return this;
  }

   /**
   * Postal code part of the billing address.
   * @return billingZip
  **/
  @Schema(description = "Postal code part of the billing address.")
  public String getBillingZip() {
    return billingZip;
  }

  public void setBillingZip(String billingZip) {
    this.billingZip = billingZip;
  }

  public FlightCreateBookingPaymentSchema billingCountry(String billingCountry) {
    this.billingCountry = billingCountry;
    return this;
  }

   /**
   * Country part of the billing address.
   * @return billingCountry
  **/
  @Schema(description = "Country part of the billing address.")
  public String getBillingCountry() {
    return billingCountry;
  }

  public void setBillingCountry(String billingCountry) {
    this.billingCountry = billingCountry;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FlightCreateBookingPaymentSchema flightCreateBookingPaymentSchema = (FlightCreateBookingPaymentSchema) o;
    return Objects.equals(this.cardNumber, flightCreateBookingPaymentSchema.cardNumber) &&
        Objects.equals(this.cardExpirationMonth, flightCreateBookingPaymentSchema.cardExpirationMonth) &&
        Objects.equals(this.cardExpirationYear, flightCreateBookingPaymentSchema.cardExpirationYear) &&
        Objects.equals(this.cardCvv, flightCreateBookingPaymentSchema.cardCvv) &&
        Objects.equals(this.cardName, flightCreateBookingPaymentSchema.cardName) &&
        Objects.equals(this.billingAddress, flightCreateBookingPaymentSchema.billingAddress) &&
        Objects.equals(this.billingCity, flightCreateBookingPaymentSchema.billingCity) &&
        Objects.equals(this.billingState, flightCreateBookingPaymentSchema.billingState) &&
        Objects.equals(this.billingZip, flightCreateBookingPaymentSchema.billingZip) &&
        Objects.equals(this.billingCountry, flightCreateBookingPaymentSchema.billingCountry);
  }

  @Override
  public int hashCode() {
    return Objects.hash(cardNumber, cardExpirationMonth, cardExpirationYear, cardCvv, cardName, billingAddress, billingCity, billingState, billingZip, billingCountry);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FlightCreateBookingPaymentSchema {\n");
    
    sb.append("    cardNumber: ").append(toIndentedString(cardNumber)).append("\n");
    sb.append("    cardExpirationMonth: ").append(toIndentedString(cardExpirationMonth)).append("\n");
    sb.append("    cardExpirationYear: ").append(toIndentedString(cardExpirationYear)).append("\n");
    sb.append("    cardCvv: ").append(toIndentedString(cardCvv)).append("\n");
    sb.append("    cardName: ").append(toIndentedString(cardName)).append("\n");
    sb.append("    billingAddress: ").append(toIndentedString(billingAddress)).append("\n");
    sb.append("    billingCity: ").append(toIndentedString(billingCity)).append("\n");
    sb.append("    billingState: ").append(toIndentedString(billingState)).append("\n");
    sb.append("    billingZip: ").append(toIndentedString(billingZip)).append("\n");
    sb.append("    billingCountry: ").append(toIndentedString(billingCountry)).append("\n");
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