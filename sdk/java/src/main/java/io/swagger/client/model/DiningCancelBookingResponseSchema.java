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
import io.swagger.client.model.DiningAvailabilitySchema;
import io.swagger.client.model.DiningBookingCustomerSchema;
import io.swagger.client.model.DiningOfferRequestSchema;
import io.swagger.client.model.DiningOfferResponseItemSchema;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.math.BigDecimal;
import java.util.UUID;
/**
 * DiningCancelBookingResponseSchema
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class DiningCancelBookingResponseSchema {
  @SerializedName("company_id")
  private UUID companyId = null;

  @SerializedName("tenant_id")
  private UUID tenantId = null;

  @SerializedName("category_id")
  private UUID categoryId = null;

  @SerializedName("supplier_id")
  private UUID supplierId = null;

  @SerializedName("booking_id")
  private UUID bookingId = null;

  @SerializedName("supplier_booking_id")
  private UUID supplierBookingId = null;

  @SerializedName("supplier_booking_reference")
  private String supplierBookingReference = null;

  @SerializedName("customer_reference")
  private String customerReference = null;

  @SerializedName("booking_reference")
  private String bookingReference = null;

  @SerializedName("payment_reference")
  private String paymentReference = null;

  @SerializedName("booking_status")
  private String bookingStatus = null;

  @SerializedName("booking_tax")
  private BigDecimal bookingTax = null;

  @SerializedName("booking_price")
  private BigDecimal bookingPrice = null;

  @SerializedName("booking_currency")
  private String bookingCurrency = null;

  @SerializedName("booking_cancellation_policies")
  private String bookingCancellationPolicies = null;

  @SerializedName("customer")
  private DiningBookingCustomerSchema customer = null;

  @SerializedName("offer_request")
  private DiningOfferRequestSchema offerRequest = null;

  @SerializedName("offer")
  private DiningOfferResponseItemSchema offer = null;

  @SerializedName("availability")
  private DiningAvailabilitySchema availability = null;

  @SerializedName("success")
  private Boolean success = null;

  @SerializedName("error_message")
  private String errorMessage = null;

  public DiningCancelBookingResponseSchema companyId(UUID companyId) {
    this.companyId = companyId;
    return this;
  }

   /**
   * Identifier for the company associated with the booking.
   * @return companyId
  **/
  @Schema(description = "Identifier for the company associated with the booking.")
  public UUID getCompanyId() {
    return companyId;
  }

  public void setCompanyId(UUID companyId) {
    this.companyId = companyId;
  }

  public DiningCancelBookingResponseSchema tenantId(UUID tenantId) {
    this.tenantId = tenantId;
    return this;
  }

   /**
   * Identifier for the tenant associated with the booking.
   * @return tenantId
  **/
  @Schema(description = "Identifier for the tenant associated with the booking.")
  public UUID getTenantId() {
    return tenantId;
  }

  public void setTenantId(UUID tenantId) {
    this.tenantId = tenantId;
  }

  public DiningCancelBookingResponseSchema categoryId(UUID categoryId) {
    this.categoryId = categoryId;
    return this;
  }

   /**
   * Identifier for the category of the booking.
   * @return categoryId
  **/
  @Schema(description = "Identifier for the category of the booking.")
  public UUID getCategoryId() {
    return categoryId;
  }

  public void setCategoryId(UUID categoryId) {
    this.categoryId = categoryId;
  }

  public DiningCancelBookingResponseSchema supplierId(UUID supplierId) {
    this.supplierId = supplierId;
    return this;
  }

   /**
   * Identifier for the supplier of the booking.
   * @return supplierId
  **/
  @Schema(description = "Identifier for the supplier of the booking.")
  public UUID getSupplierId() {
    return supplierId;
  }

  public void setSupplierId(UUID supplierId) {
    this.supplierId = supplierId;
  }

  public DiningCancelBookingResponseSchema bookingId(UUID bookingId) {
    this.bookingId = bookingId;
    return this;
  }

   /**
   * Unique identifier for the booking.
   * @return bookingId
  **/
  @Schema(description = "Unique identifier for the booking.")
  public UUID getBookingId() {
    return bookingId;
  }

  public void setBookingId(UUID bookingId) {
    this.bookingId = bookingId;
  }

  public DiningCancelBookingResponseSchema supplierBookingId(UUID supplierBookingId) {
    this.supplierBookingId = supplierBookingId;
    return this;
  }

   /**
   * Supplier’s identifier for the booking.
   * @return supplierBookingId
  **/
  @Schema(description = "Supplier’s identifier for the booking.")
  public UUID getSupplierBookingId() {
    return supplierBookingId;
  }

  public void setSupplierBookingId(UUID supplierBookingId) {
    this.supplierBookingId = supplierBookingId;
  }

  public DiningCancelBookingResponseSchema supplierBookingReference(String supplierBookingReference) {
    this.supplierBookingReference = supplierBookingReference;
    return this;
  }

   /**
   * Reference number provided by the supplier for the booking.
   * @return supplierBookingReference
  **/
  @Schema(description = "Reference number provided by the supplier for the booking.")
  public String getSupplierBookingReference() {
    return supplierBookingReference;
  }

  public void setSupplierBookingReference(String supplierBookingReference) {
    this.supplierBookingReference = supplierBookingReference;
  }

  public DiningCancelBookingResponseSchema customerReference(String customerReference) {
    this.customerReference = customerReference;
    return this;
  }

   /**
   * Customer reference number associated with the booking.
   * @return customerReference
  **/
  @Schema(description = "Customer reference number associated with the booking.")
  public String getCustomerReference() {
    return customerReference;
  }

  public void setCustomerReference(String customerReference) {
    this.customerReference = customerReference;
  }

  public DiningCancelBookingResponseSchema bookingReference(String bookingReference) {
    this.bookingReference = bookingReference;
    return this;
  }

   /**
   * Internal reference number for the booking.
   * @return bookingReference
  **/
  @Schema(description = "Internal reference number for the booking.")
  public String getBookingReference() {
    return bookingReference;
  }

  public void setBookingReference(String bookingReference) {
    this.bookingReference = bookingReference;
  }

  public DiningCancelBookingResponseSchema paymentReference(String paymentReference) {
    this.paymentReference = paymentReference;
    return this;
  }

   /**
   * Reference number for the payment associated with the booking.
   * @return paymentReference
  **/
  @Schema(description = "Reference number for the payment associated with the booking.")
  public String getPaymentReference() {
    return paymentReference;
  }

  public void setPaymentReference(String paymentReference) {
    this.paymentReference = paymentReference;
  }

  public DiningCancelBookingResponseSchema bookingStatus(String bookingStatus) {
    this.bookingStatus = bookingStatus;
    return this;
  }

   /**
   * Current status of the booking.
   * @return bookingStatus
  **/
  @Schema(description = "Current status of the booking.")
  public String getBookingStatus() {
    return bookingStatus;
  }

  public void setBookingStatus(String bookingStatus) {
    this.bookingStatus = bookingStatus;
  }

  public DiningCancelBookingResponseSchema bookingTax(BigDecimal bookingTax) {
    this.bookingTax = bookingTax;
    return this;
  }

   /**
   * Tax applied to the booking.
   * @return bookingTax
  **/
  @Schema(description = "Tax applied to the booking.")
  public BigDecimal getBookingTax() {
    return bookingTax;
  }

  public void setBookingTax(BigDecimal bookingTax) {
    this.bookingTax = bookingTax;
  }

  public DiningCancelBookingResponseSchema bookingPrice(BigDecimal bookingPrice) {
    this.bookingPrice = bookingPrice;
    return this;
  }

   /**
   * Total price of the booking.
   * @return bookingPrice
  **/
  @Schema(description = "Total price of the booking.")
  public BigDecimal getBookingPrice() {
    return bookingPrice;
  }

  public void setBookingPrice(BigDecimal bookingPrice) {
    this.bookingPrice = bookingPrice;
  }

  public DiningCancelBookingResponseSchema bookingCurrency(String bookingCurrency) {
    this.bookingCurrency = bookingCurrency;
    return this;
  }

   /**
   * Currency used for the booking pricing.
   * @return bookingCurrency
  **/
  @Schema(description = "Currency used for the booking pricing.")
  public String getBookingCurrency() {
    return bookingCurrency;
  }

  public void setBookingCurrency(String bookingCurrency) {
    this.bookingCurrency = bookingCurrency;
  }

  public DiningCancelBookingResponseSchema bookingCancellationPolicies(String bookingCancellationPolicies) {
    this.bookingCancellationPolicies = bookingCancellationPolicies;
    return this;
  }

   /**
   * Cancellation policies applicable to the booking.
   * @return bookingCancellationPolicies
  **/
  @Schema(description = "Cancellation policies applicable to the booking.")
  public String getBookingCancellationPolicies() {
    return bookingCancellationPolicies;
  }

  public void setBookingCancellationPolicies(String bookingCancellationPolicies) {
    this.bookingCancellationPolicies = bookingCancellationPolicies;
  }

  public DiningCancelBookingResponseSchema customer(DiningBookingCustomerSchema customer) {
    this.customer = customer;
    return this;
  }

   /**
   * Get customer
   * @return customer
  **/
  @Schema(description = "")
  public DiningBookingCustomerSchema getCustomer() {
    return customer;
  }

  public void setCustomer(DiningBookingCustomerSchema customer) {
    this.customer = customer;
  }

  public DiningCancelBookingResponseSchema offerRequest(DiningOfferRequestSchema offerRequest) {
    this.offerRequest = offerRequest;
    return this;
  }

   /**
   * Get offerRequest
   * @return offerRequest
  **/
  @Schema(description = "")
  public DiningOfferRequestSchema getOfferRequest() {
    return offerRequest;
  }

  public void setOfferRequest(DiningOfferRequestSchema offerRequest) {
    this.offerRequest = offerRequest;
  }

  public DiningCancelBookingResponseSchema offer(DiningOfferResponseItemSchema offer) {
    this.offer = offer;
    return this;
  }

   /**
   * Get offer
   * @return offer
  **/
  @Schema(description = "")
  public DiningOfferResponseItemSchema getOffer() {
    return offer;
  }

  public void setOffer(DiningOfferResponseItemSchema offer) {
    this.offer = offer;
  }

  public DiningCancelBookingResponseSchema availability(DiningAvailabilitySchema availability) {
    this.availability = availability;
    return this;
  }

   /**
   * Get availability
   * @return availability
  **/
  @Schema(description = "")
  public DiningAvailabilitySchema getAvailability() {
    return availability;
  }

  public void setAvailability(DiningAvailabilitySchema availability) {
    this.availability = availability;
  }

  public DiningCancelBookingResponseSchema success(Boolean success) {
    this.success = success;
    return this;
  }

   /**
   * Indicates if the booking was successful.
   * @return success
  **/
  @Schema(description = "Indicates if the booking was successful.")
  public Boolean isSuccess() {
    return success;
  }

  public void setSuccess(Boolean success) {
    this.success = success;
  }

  public DiningCancelBookingResponseSchema errorMessage(String errorMessage) {
    this.errorMessage = errorMessage;
    return this;
  }

   /**
   * Provides details on any error that occurred during the booking process.
   * @return errorMessage
  **/
  @Schema(description = "Provides details on any error that occurred during the booking process.")
  public String getErrorMessage() {
    return errorMessage;
  }

  public void setErrorMessage(String errorMessage) {
    this.errorMessage = errorMessage;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DiningCancelBookingResponseSchema diningCancelBookingResponseSchema = (DiningCancelBookingResponseSchema) o;
    return Objects.equals(this.companyId, diningCancelBookingResponseSchema.companyId) &&
        Objects.equals(this.tenantId, diningCancelBookingResponseSchema.tenantId) &&
        Objects.equals(this.categoryId, diningCancelBookingResponseSchema.categoryId) &&
        Objects.equals(this.supplierId, diningCancelBookingResponseSchema.supplierId) &&
        Objects.equals(this.bookingId, diningCancelBookingResponseSchema.bookingId) &&
        Objects.equals(this.supplierBookingId, diningCancelBookingResponseSchema.supplierBookingId) &&
        Objects.equals(this.supplierBookingReference, diningCancelBookingResponseSchema.supplierBookingReference) &&
        Objects.equals(this.customerReference, diningCancelBookingResponseSchema.customerReference) &&
        Objects.equals(this.bookingReference, diningCancelBookingResponseSchema.bookingReference) &&
        Objects.equals(this.paymentReference, diningCancelBookingResponseSchema.paymentReference) &&
        Objects.equals(this.bookingStatus, diningCancelBookingResponseSchema.bookingStatus) &&
        Objects.equals(this.bookingTax, diningCancelBookingResponseSchema.bookingTax) &&
        Objects.equals(this.bookingPrice, diningCancelBookingResponseSchema.bookingPrice) &&
        Objects.equals(this.bookingCurrency, diningCancelBookingResponseSchema.bookingCurrency) &&
        Objects.equals(this.bookingCancellationPolicies, diningCancelBookingResponseSchema.bookingCancellationPolicies) &&
        Objects.equals(this.customer, diningCancelBookingResponseSchema.customer) &&
        Objects.equals(this.offerRequest, diningCancelBookingResponseSchema.offerRequest) &&
        Objects.equals(this.offer, diningCancelBookingResponseSchema.offer) &&
        Objects.equals(this.availability, diningCancelBookingResponseSchema.availability) &&
        Objects.equals(this.success, diningCancelBookingResponseSchema.success) &&
        Objects.equals(this.errorMessage, diningCancelBookingResponseSchema.errorMessage);
  }

  @Override
  public int hashCode() {
    return Objects.hash(companyId, tenantId, categoryId, supplierId, bookingId, supplierBookingId, supplierBookingReference, customerReference, bookingReference, paymentReference, bookingStatus, bookingTax, bookingPrice, bookingCurrency, bookingCancellationPolicies, customer, offerRequest, offer, availability, success, errorMessage);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DiningCancelBookingResponseSchema {\n");
    
    sb.append("    companyId: ").append(toIndentedString(companyId)).append("\n");
    sb.append("    tenantId: ").append(toIndentedString(tenantId)).append("\n");
    sb.append("    categoryId: ").append(toIndentedString(categoryId)).append("\n");
    sb.append("    supplierId: ").append(toIndentedString(supplierId)).append("\n");
    sb.append("    bookingId: ").append(toIndentedString(bookingId)).append("\n");
    sb.append("    supplierBookingId: ").append(toIndentedString(supplierBookingId)).append("\n");
    sb.append("    supplierBookingReference: ").append(toIndentedString(supplierBookingReference)).append("\n");
    sb.append("    customerReference: ").append(toIndentedString(customerReference)).append("\n");
    sb.append("    bookingReference: ").append(toIndentedString(bookingReference)).append("\n");
    sb.append("    paymentReference: ").append(toIndentedString(paymentReference)).append("\n");
    sb.append("    bookingStatus: ").append(toIndentedString(bookingStatus)).append("\n");
    sb.append("    bookingTax: ").append(toIndentedString(bookingTax)).append("\n");
    sb.append("    bookingPrice: ").append(toIndentedString(bookingPrice)).append("\n");
    sb.append("    bookingCurrency: ").append(toIndentedString(bookingCurrency)).append("\n");
    sb.append("    bookingCancellationPolicies: ").append(toIndentedString(bookingCancellationPolicies)).append("\n");
    sb.append("    customer: ").append(toIndentedString(customer)).append("\n");
    sb.append("    offerRequest: ").append(toIndentedString(offerRequest)).append("\n");
    sb.append("    offer: ").append(toIndentedString(offer)).append("\n");
    sb.append("    availability: ").append(toIndentedString(availability)).append("\n");
    sb.append("    success: ").append(toIndentedString(success)).append("\n");
    sb.append("    errorMessage: ").append(toIndentedString(errorMessage)).append("\n");
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
