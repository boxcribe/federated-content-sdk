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
import java.util.ArrayList;
import java.util.List;
import java.util.UUID;
/**
 * EventTicketSchema
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class EventTicketSchema {
  @SerializedName("ticket_id")
  private UUID ticketId = null;

  @SerializedName("supplier_ticket_id")
  private UUID supplierTicketId = null;

  @SerializedName("ticket_index")
  private BigDecimal ticketIndex = null;

  @SerializedName("ticket_tax")
  private BigDecimal ticketTax = null;

  @SerializedName("ticket_price")
  private BigDecimal ticketPrice = null;

  @SerializedName("ticket_currency")
  private String ticketCurrency = null;

  @SerializedName("ticket_cancellation_policies")
  private String ticketCancellationPolicies = null;

  @SerializedName("ticket_section")
  private String ticketSection = null;

  @SerializedName("ticket_row")
  private String ticketRow = null;

  @SerializedName("ticket_seat")
  private String ticketSeat = null;

  @SerializedName("ticket_description")
  private String ticketDescription = null;

  @SerializedName("ticket_delivery_options")
  private List<String> ticketDeliveryOptions = null;

  @SerializedName("ticket_quantities")
  private List<Integer> ticketQuantities = null;

  @SerializedName("booking_questions")
  private List<String> bookingQuestions = null;

  public EventTicketSchema ticketId(UUID ticketId) {
    this.ticketId = ticketId;
    return this;
  }

   /**
   * Unique identifier for the ticket.
   * @return ticketId
  **/
  @Schema(description = "Unique identifier for the ticket.")
  public UUID getTicketId() {
    return ticketId;
  }

  public void setTicketId(UUID ticketId) {
    this.ticketId = ticketId;
  }

  public EventTicketSchema supplierTicketId(UUID supplierTicketId) {
    this.supplierTicketId = supplierTicketId;
    return this;
  }

   /**
   * Identifier for the ticket provided by the supplier.
   * @return supplierTicketId
  **/
  @Schema(description = "Identifier for the ticket provided by the supplier.")
  public UUID getSupplierTicketId() {
    return supplierTicketId;
  }

  public void setSupplierTicketId(UUID supplierTicketId) {
    this.supplierTicketId = supplierTicketId;
  }

  public EventTicketSchema ticketIndex(BigDecimal ticketIndex) {
    this.ticketIndex = ticketIndex;
    return this;
  }

   /**
   * Index number of the ticket for ordering.
   * @return ticketIndex
  **/
  @Schema(description = "Index number of the ticket for ordering.")
  public BigDecimal getTicketIndex() {
    return ticketIndex;
  }

  public void setTicketIndex(BigDecimal ticketIndex) {
    this.ticketIndex = ticketIndex;
  }

  public EventTicketSchema ticketTax(BigDecimal ticketTax) {
    this.ticketTax = ticketTax;
    return this;
  }

   /**
   * Applicable tax on the ticket price.
   * @return ticketTax
  **/
  @Schema(description = "Applicable tax on the ticket price.")
  public BigDecimal getTicketTax() {
    return ticketTax;
  }

  public void setTicketTax(BigDecimal ticketTax) {
    this.ticketTax = ticketTax;
  }

  public EventTicketSchema ticketPrice(BigDecimal ticketPrice) {
    this.ticketPrice = ticketPrice;
    return this;
  }

   /**
   * Price of the ticket.
   * @return ticketPrice
  **/
  @Schema(description = "Price of the ticket.")
  public BigDecimal getTicketPrice() {
    return ticketPrice;
  }

  public void setTicketPrice(BigDecimal ticketPrice) {
    this.ticketPrice = ticketPrice;
  }

  public EventTicketSchema ticketCurrency(String ticketCurrency) {
    this.ticketCurrency = ticketCurrency;
    return this;
  }

   /**
   * Currency in which the ticket is priced.
   * @return ticketCurrency
  **/
  @Schema(description = "Currency in which the ticket is priced.")
  public String getTicketCurrency() {
    return ticketCurrency;
  }

  public void setTicketCurrency(String ticketCurrency) {
    this.ticketCurrency = ticketCurrency;
  }

  public EventTicketSchema ticketCancellationPolicies(String ticketCancellationPolicies) {
    this.ticketCancellationPolicies = ticketCancellationPolicies;
    return this;
  }

   /**
   * Policies regarding ticket cancellation.
   * @return ticketCancellationPolicies
  **/
  @Schema(description = "Policies regarding ticket cancellation.")
  public String getTicketCancellationPolicies() {
    return ticketCancellationPolicies;
  }

  public void setTicketCancellationPolicies(String ticketCancellationPolicies) {
    this.ticketCancellationPolicies = ticketCancellationPolicies;
  }

  public EventTicketSchema ticketSection(String ticketSection) {
    this.ticketSection = ticketSection;
    return this;
  }

   /**
   * Section of the venue where the seat is located.
   * @return ticketSection
  **/
  @Schema(description = "Section of the venue where the seat is located.")
  public String getTicketSection() {
    return ticketSection;
  }

  public void setTicketSection(String ticketSection) {
    this.ticketSection = ticketSection;
  }

  public EventTicketSchema ticketRow(String ticketRow) {
    this.ticketRow = ticketRow;
    return this;
  }

   /**
   * Row of the section where the seat is located.
   * @return ticketRow
  **/
  @Schema(description = "Row of the section where the seat is located.")
  public String getTicketRow() {
    return ticketRow;
  }

  public void setTicketRow(String ticketRow) {
    this.ticketRow = ticketRow;
  }

  public EventTicketSchema ticketSeat(String ticketSeat) {
    this.ticketSeat = ticketSeat;
    return this;
  }

   /**
   * Specific seat number.
   * @return ticketSeat
  **/
  @Schema(description = "Specific seat number.")
  public String getTicketSeat() {
    return ticketSeat;
  }

  public void setTicketSeat(String ticketSeat) {
    this.ticketSeat = ticketSeat;
  }

  public EventTicketSchema ticketDescription(String ticketDescription) {
    this.ticketDescription = ticketDescription;
    return this;
  }

   /**
   * Description of the ticket.
   * @return ticketDescription
  **/
  @Schema(description = "Description of the ticket.")
  public String getTicketDescription() {
    return ticketDescription;
  }

  public void setTicketDescription(String ticketDescription) {
    this.ticketDescription = ticketDescription;
  }

  public EventTicketSchema ticketDeliveryOptions(List<String> ticketDeliveryOptions) {
    this.ticketDeliveryOptions = ticketDeliveryOptions;
    return this;
  }

  public EventTicketSchema addTicketDeliveryOptionsItem(String ticketDeliveryOptionsItem) {
    if (this.ticketDeliveryOptions == null) {
      this.ticketDeliveryOptions = new ArrayList<String>();
    }
    this.ticketDeliveryOptions.add(ticketDeliveryOptionsItem);
    return this;
  }

   /**
   * Available options for ticket delivery.
   * @return ticketDeliveryOptions
  **/
  @Schema(description = "Available options for ticket delivery.")
  public List<String> getTicketDeliveryOptions() {
    return ticketDeliveryOptions;
  }

  public void setTicketDeliveryOptions(List<String> ticketDeliveryOptions) {
    this.ticketDeliveryOptions = ticketDeliveryOptions;
  }

  public EventTicketSchema ticketQuantities(List<Integer> ticketQuantities) {
    this.ticketQuantities = ticketQuantities;
    return this;
  }

  public EventTicketSchema addTicketQuantitiesItem(Integer ticketQuantitiesItem) {
    if (this.ticketQuantities == null) {
      this.ticketQuantities = new ArrayList<Integer>();
    }
    this.ticketQuantities.add(ticketQuantitiesItem);
    return this;
  }

   /**
   * Quantities of tickets available for purchase.
   * @return ticketQuantities
  **/
  @Schema(description = "Quantities of tickets available for purchase.")
  public List<Integer> getTicketQuantities() {
    return ticketQuantities;
  }

  public void setTicketQuantities(List<Integer> ticketQuantities) {
    this.ticketQuantities = ticketQuantities;
  }

  public EventTicketSchema bookingQuestions(List<String> bookingQuestions) {
    this.bookingQuestions = bookingQuestions;
    return this;
  }

  public EventTicketSchema addBookingQuestionsItem(String bookingQuestionsItem) {
    if (this.bookingQuestions == null) {
      this.bookingQuestions = new ArrayList<String>();
    }
    this.bookingQuestions.add(bookingQuestionsItem);
    return this;
  }

   /**
   * Questions related to booking the event.
   * @return bookingQuestions
  **/
  @Schema(description = "Questions related to booking the event.")
  public List<String> getBookingQuestions() {
    return bookingQuestions;
  }

  public void setBookingQuestions(List<String> bookingQuestions) {
    this.bookingQuestions = bookingQuestions;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    EventTicketSchema eventTicketSchema = (EventTicketSchema) o;
    return Objects.equals(this.ticketId, eventTicketSchema.ticketId) &&
        Objects.equals(this.supplierTicketId, eventTicketSchema.supplierTicketId) &&
        Objects.equals(this.ticketIndex, eventTicketSchema.ticketIndex) &&
        Objects.equals(this.ticketTax, eventTicketSchema.ticketTax) &&
        Objects.equals(this.ticketPrice, eventTicketSchema.ticketPrice) &&
        Objects.equals(this.ticketCurrency, eventTicketSchema.ticketCurrency) &&
        Objects.equals(this.ticketCancellationPolicies, eventTicketSchema.ticketCancellationPolicies) &&
        Objects.equals(this.ticketSection, eventTicketSchema.ticketSection) &&
        Objects.equals(this.ticketRow, eventTicketSchema.ticketRow) &&
        Objects.equals(this.ticketSeat, eventTicketSchema.ticketSeat) &&
        Objects.equals(this.ticketDescription, eventTicketSchema.ticketDescription) &&
        Objects.equals(this.ticketDeliveryOptions, eventTicketSchema.ticketDeliveryOptions) &&
        Objects.equals(this.ticketQuantities, eventTicketSchema.ticketQuantities) &&
        Objects.equals(this.bookingQuestions, eventTicketSchema.bookingQuestions);
  }

  @Override
  public int hashCode() {
    return Objects.hash(ticketId, supplierTicketId, ticketIndex, ticketTax, ticketPrice, ticketCurrency, ticketCancellationPolicies, ticketSection, ticketRow, ticketSeat, ticketDescription, ticketDeliveryOptions, ticketQuantities, bookingQuestions);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class EventTicketSchema {\n");
    
    sb.append("    ticketId: ").append(toIndentedString(ticketId)).append("\n");
    sb.append("    supplierTicketId: ").append(toIndentedString(supplierTicketId)).append("\n");
    sb.append("    ticketIndex: ").append(toIndentedString(ticketIndex)).append("\n");
    sb.append("    ticketTax: ").append(toIndentedString(ticketTax)).append("\n");
    sb.append("    ticketPrice: ").append(toIndentedString(ticketPrice)).append("\n");
    sb.append("    ticketCurrency: ").append(toIndentedString(ticketCurrency)).append("\n");
    sb.append("    ticketCancellationPolicies: ").append(toIndentedString(ticketCancellationPolicies)).append("\n");
    sb.append("    ticketSection: ").append(toIndentedString(ticketSection)).append("\n");
    sb.append("    ticketRow: ").append(toIndentedString(ticketRow)).append("\n");
    sb.append("    ticketSeat: ").append(toIndentedString(ticketSeat)).append("\n");
    sb.append("    ticketDescription: ").append(toIndentedString(ticketDescription)).append("\n");
    sb.append("    ticketDeliveryOptions: ").append(toIndentedString(ticketDeliveryOptions)).append("\n");
    sb.append("    ticketQuantities: ").append(toIndentedString(ticketQuantities)).append("\n");
    sb.append("    bookingQuestions: ").append(toIndentedString(bookingQuestions)).append("\n");
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