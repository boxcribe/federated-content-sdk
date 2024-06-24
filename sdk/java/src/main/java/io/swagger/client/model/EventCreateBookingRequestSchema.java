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
import io.swagger.client.model.EventCreateBookingCustomerSchema;
import io.swagger.client.model.EventCreateBookingPaymentSchema;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;
import java.util.UUID;
/**
 * EventCreateBookingRequestSchema
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class EventCreateBookingRequestSchema {
  @SerializedName("offer_id")
  private UUID offerId = null;

  @SerializedName("ticket_id")
  private UUID ticketId = null;

  @SerializedName("ticket_qty")
  private BigDecimal ticketQty = null;

  @SerializedName("customer")
  private EventCreateBookingCustomerSchema customer = null;

  @SerializedName("payment")
  private EventCreateBookingPaymentSchema payment = null;

  @SerializedName("currency")
  private String currency = null;

  @SerializedName("customer_reference")
  private String customerReference = null;

  @SerializedName("booking_reference")
  private String bookingReference = null;

  @SerializedName("payment_reference")
  private String paymentReference = null;

  @SerializedName("booking_questions")
  private List<String> bookingQuestions = null;

  public EventCreateBookingRequestSchema offerId(UUID offerId) {
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

  public EventCreateBookingRequestSchema ticketId(UUID ticketId) {
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

  public EventCreateBookingRequestSchema ticketQty(BigDecimal ticketQty) {
    this.ticketQty = ticketQty;
    return this;
  }

   /**
   * Ticket quantity for ordering.
   * @return ticketQty
  **/
  @Schema(description = "Ticket quantity for ordering.")
  public BigDecimal getTicketQty() {
    return ticketQty;
  }

  public void setTicketQty(BigDecimal ticketQty) {
    this.ticketQty = ticketQty;
  }

  public EventCreateBookingRequestSchema customer(EventCreateBookingCustomerSchema customer) {
    this.customer = customer;
    return this;
  }

   /**
   * Get customer
   * @return customer
  **/
  @Schema(description = "")
  public EventCreateBookingCustomerSchema getCustomer() {
    return customer;
  }

  public void setCustomer(EventCreateBookingCustomerSchema customer) {
    this.customer = customer;
  }

  public EventCreateBookingRequestSchema payment(EventCreateBookingPaymentSchema payment) {
    this.payment = payment;
    return this;
  }

   /**
   * Get payment
   * @return payment
  **/
  @Schema(description = "")
  public EventCreateBookingPaymentSchema getPayment() {
    return payment;
  }

  public void setPayment(EventCreateBookingPaymentSchema payment) {
    this.payment = payment;
  }

  public EventCreateBookingRequestSchema currency(String currency) {
    this.currency = currency;
    return this;
  }

   /**
   * Currency used for the booking.
   * @return currency
  **/
  @Schema(description = "Currency used for the booking.")
  public String getCurrency() {
    return currency;
  }

  public void setCurrency(String currency) {
    this.currency = currency;
  }

  public EventCreateBookingRequestSchema customerReference(String customerReference) {
    this.customerReference = customerReference;
    return this;
  }

   /**
   * Customer reference identifier.
   * @return customerReference
  **/
  @Schema(description = "Customer reference identifier.")
  public String getCustomerReference() {
    return customerReference;
  }

  public void setCustomerReference(String customerReference) {
    this.customerReference = customerReference;
  }

  public EventCreateBookingRequestSchema bookingReference(String bookingReference) {
    this.bookingReference = bookingReference;
    return this;
  }

   /**
   * Booking reference identifier.
   * @return bookingReference
  **/
  @Schema(description = "Booking reference identifier.")
  public String getBookingReference() {
    return bookingReference;
  }

  public void setBookingReference(String bookingReference) {
    this.bookingReference = bookingReference;
  }

  public EventCreateBookingRequestSchema paymentReference(String paymentReference) {
    this.paymentReference = paymentReference;
    return this;
  }

   /**
   * Payment transaction reference.
   * @return paymentReference
  **/
  @Schema(description = "Payment transaction reference.")
  public String getPaymentReference() {
    return paymentReference;
  }

  public void setPaymentReference(String paymentReference) {
    this.paymentReference = paymentReference;
  }

  public EventCreateBookingRequestSchema bookingQuestions(List<String> bookingQuestions) {
    this.bookingQuestions = bookingQuestions;
    return this;
  }

  public EventCreateBookingRequestSchema addBookingQuestionsItem(String bookingQuestionsItem) {
    if (this.bookingQuestions == null) {
      this.bookingQuestions = new ArrayList<String>();
    }
    this.bookingQuestions.add(bookingQuestionsItem);
    return this;
  }

   /**
   * Questions related to booking the tour variant.
   * @return bookingQuestions
  **/
  @Schema(description = "Questions related to booking the tour variant.")
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
    EventCreateBookingRequestSchema eventCreateBookingRequestSchema = (EventCreateBookingRequestSchema) o;
    return Objects.equals(this.offerId, eventCreateBookingRequestSchema.offerId) &&
        Objects.equals(this.ticketId, eventCreateBookingRequestSchema.ticketId) &&
        Objects.equals(this.ticketQty, eventCreateBookingRequestSchema.ticketQty) &&
        Objects.equals(this.customer, eventCreateBookingRequestSchema.customer) &&
        Objects.equals(this.payment, eventCreateBookingRequestSchema.payment) &&
        Objects.equals(this.currency, eventCreateBookingRequestSchema.currency) &&
        Objects.equals(this.customerReference, eventCreateBookingRequestSchema.customerReference) &&
        Objects.equals(this.bookingReference, eventCreateBookingRequestSchema.bookingReference) &&
        Objects.equals(this.paymentReference, eventCreateBookingRequestSchema.paymentReference) &&
        Objects.equals(this.bookingQuestions, eventCreateBookingRequestSchema.bookingQuestions);
  }

  @Override
  public int hashCode() {
    return Objects.hash(offerId, ticketId, ticketQty, customer, payment, currency, customerReference, bookingReference, paymentReference, bookingQuestions);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class EventCreateBookingRequestSchema {\n");
    
    sb.append("    offerId: ").append(toIndentedString(offerId)).append("\n");
    sb.append("    ticketId: ").append(toIndentedString(ticketId)).append("\n");
    sb.append("    ticketQty: ").append(toIndentedString(ticketQty)).append("\n");
    sb.append("    customer: ").append(toIndentedString(customer)).append("\n");
    sb.append("    payment: ").append(toIndentedString(payment)).append("\n");
    sb.append("    currency: ").append(toIndentedString(currency)).append("\n");
    sb.append("    customerReference: ").append(toIndentedString(customerReference)).append("\n");
    sb.append("    bookingReference: ").append(toIndentedString(bookingReference)).append("\n");
    sb.append("    paymentReference: ").append(toIndentedString(paymentReference)).append("\n");
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
