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
import java.util.UUID;
/**
 * TransportCancelBookingRequestSchema
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class TransportCancelBookingRequestSchema {
  @SerializedName("booking_id")
  private UUID bookingId = null;

  @SerializedName("cancelation_reason")
  private String cancelationReason = null;

  public TransportCancelBookingRequestSchema bookingId(UUID bookingId) {
    this.bookingId = bookingId;
    return this;
  }

   /**
   * Identifier of the booking to be canceled.
   * @return bookingId
  **/
  @Schema(description = "Identifier of the booking to be canceled.")
  public UUID getBookingId() {
    return bookingId;
  }

  public void setBookingId(UUID bookingId) {
    this.bookingId = bookingId;
  }

  public TransportCancelBookingRequestSchema cancelationReason(String cancelationReason) {
    this.cancelationReason = cancelationReason;
    return this;
  }

   /**
   * Reason provided for the cancellation.
   * @return cancelationReason
  **/
  @Schema(description = "Reason provided for the cancellation.")
  public String getCancelationReason() {
    return cancelationReason;
  }

  public void setCancelationReason(String cancelationReason) {
    this.cancelationReason = cancelationReason;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TransportCancelBookingRequestSchema transportCancelBookingRequestSchema = (TransportCancelBookingRequestSchema) o;
    return Objects.equals(this.bookingId, transportCancelBookingRequestSchema.bookingId) &&
        Objects.equals(this.cancelationReason, transportCancelBookingRequestSchema.cancelationReason);
  }

  @Override
  public int hashCode() {
    return Objects.hash(bookingId, cancelationReason);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TransportCancelBookingRequestSchema {\n");
    
    sb.append("    bookingId: ").append(toIndentedString(bookingId)).append("\n");
    sb.append("    cancelationReason: ").append(toIndentedString(cancelationReason)).append("\n");
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
