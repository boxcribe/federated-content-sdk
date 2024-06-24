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
import org.threeten.bp.LocalDate;
/**
 * DiningAvailabilitySchema
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class DiningAvailabilitySchema {
  @SerializedName("availability_id")
  private UUID availabilityId = null;

  @SerializedName("supplier_availability_id")
  private UUID supplierAvailabilityId = null;

  @SerializedName("availability_index")
  private BigDecimal availabilityIndex = null;

  @SerializedName("date")
  private LocalDate date = null;

  @SerializedName("time")
  private String time = null;

  @SerializedName("adults")
  private BigDecimal adults = null;

  public DiningAvailabilitySchema availabilityId(UUID availabilityId) {
    this.availabilityId = availabilityId;
    return this;
  }

   /**
   * Unique identifier for the dining availability.
   * @return availabilityId
  **/
  @Schema(description = "Unique identifier for the dining availability.")
  public UUID getAvailabilityId() {
    return availabilityId;
  }

  public void setAvailabilityId(UUID availabilityId) {
    this.availabilityId = availabilityId;
  }

  public DiningAvailabilitySchema supplierAvailabilityId(UUID supplierAvailabilityId) {
    this.supplierAvailabilityId = supplierAvailabilityId;
    return this;
  }

   /**
   * Identifier for the availability provided by the supplier.
   * @return supplierAvailabilityId
  **/
  @Schema(description = "Identifier for the availability provided by the supplier.")
  public UUID getSupplierAvailabilityId() {
    return supplierAvailabilityId;
  }

  public void setSupplierAvailabilityId(UUID supplierAvailabilityId) {
    this.supplierAvailabilityId = supplierAvailabilityId;
  }

  public DiningAvailabilitySchema availabilityIndex(BigDecimal availabilityIndex) {
    this.availabilityIndex = availabilityIndex;
    return this;
  }

   /**
   * Index of the availability for sorting and reference.
   * @return availabilityIndex
  **/
  @Schema(description = "Index of the availability for sorting and reference.")
  public BigDecimal getAvailabilityIndex() {
    return availabilityIndex;
  }

  public void setAvailabilityIndex(BigDecimal availabilityIndex) {
    this.availabilityIndex = availabilityIndex;
  }

  public DiningAvailabilitySchema date(LocalDate date) {
    this.date = date;
    return this;
  }

   /**
   * Date of availability for dining.
   * @return date
  **/
  @Schema(description = "Date of availability for dining.")
  public LocalDate getDate() {
    return date;
  }

  public void setDate(LocalDate date) {
    this.date = date;
  }

  public DiningAvailabilitySchema time(String time) {
    this.time = time;
    return this;
  }

   /**
   * Time of availability for dining.
   * @return time
  **/
  @Schema(description = "Time of availability for dining.")
  public String getTime() {
    return time;
  }

  public void setTime(String time) {
    this.time = time;
  }

  public DiningAvailabilitySchema adults(BigDecimal adults) {
    this.adults = adults;
    return this;
  }

   /**
   * Number of adults for the dining reservation.
   * @return adults
  **/
  @Schema(description = "Number of adults for the dining reservation.")
  public BigDecimal getAdults() {
    return adults;
  }

  public void setAdults(BigDecimal adults) {
    this.adults = adults;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DiningAvailabilitySchema diningAvailabilitySchema = (DiningAvailabilitySchema) o;
    return Objects.equals(this.availabilityId, diningAvailabilitySchema.availabilityId) &&
        Objects.equals(this.supplierAvailabilityId, diningAvailabilitySchema.supplierAvailabilityId) &&
        Objects.equals(this.availabilityIndex, diningAvailabilitySchema.availabilityIndex) &&
        Objects.equals(this.date, diningAvailabilitySchema.date) &&
        Objects.equals(this.time, diningAvailabilitySchema.time) &&
        Objects.equals(this.adults, diningAvailabilitySchema.adults);
  }

  @Override
  public int hashCode() {
    return Objects.hash(availabilityId, supplierAvailabilityId, availabilityIndex, date, time, adults);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DiningAvailabilitySchema {\n");
    
    sb.append("    availabilityId: ").append(toIndentedString(availabilityId)).append("\n");
    sb.append("    supplierAvailabilityId: ").append(toIndentedString(supplierAvailabilityId)).append("\n");
    sb.append("    availabilityIndex: ").append(toIndentedString(availabilityIndex)).append("\n");
    sb.append("    date: ").append(toIndentedString(date)).append("\n");
    sb.append("    time: ").append(toIndentedString(time)).append("\n");
    sb.append("    adults: ").append(toIndentedString(adults)).append("\n");
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