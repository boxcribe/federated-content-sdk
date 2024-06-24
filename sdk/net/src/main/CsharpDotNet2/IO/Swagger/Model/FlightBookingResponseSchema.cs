using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class FlightBookingResponseSchema {
    /// <summary>
    /// Identifier for the company associated with the booking.
    /// </summary>
    /// <value>Identifier for the company associated with the booking.</value>
    [DataMember(Name="company_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company_id")]
    public Guid? CompanyId { get; set; }

    /// <summary>
    /// Identifier for the tenant associated with the booking.
    /// </summary>
    /// <value>Identifier for the tenant associated with the booking.</value>
    [DataMember(Name="tenant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tenant_id")]
    public Guid? TenantId { get; set; }

    /// <summary>
    /// Identifier for the category of the booking.
    /// </summary>
    /// <value>Identifier for the category of the booking.</value>
    [DataMember(Name="category_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category_id")]
    public Guid? CategoryId { get; set; }

    /// <summary>
    /// Identifier for the supplier of the booking.
    /// </summary>
    /// <value>Identifier for the supplier of the booking.</value>
    [DataMember(Name="supplier_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplier_id")]
    public Guid? SupplierId { get; set; }

    /// <summary>
    /// Unique identifier for the booking.
    /// </summary>
    /// <value>Unique identifier for the booking.</value>
    [DataMember(Name="booking_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "booking_id")]
    public Guid? BookingId { get; set; }

    /// <summary>
    /// Supplier’s identifier for the booking.
    /// </summary>
    /// <value>Supplier’s identifier for the booking.</value>
    [DataMember(Name="supplier_booking_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplier_booking_id")]
    public Guid? SupplierBookingId { get; set; }

    /// <summary>
    /// Reference number provided by the supplier for the booking.
    /// </summary>
    /// <value>Reference number provided by the supplier for the booking.</value>
    [DataMember(Name="supplier_booking_reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplier_booking_reference")]
    public string SupplierBookingReference { get; set; }

    /// <summary>
    /// Customer reference number associated with the booking.
    /// </summary>
    /// <value>Customer reference number associated with the booking.</value>
    [DataMember(Name="customer_reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer_reference")]
    public string CustomerReference { get; set; }

    /// <summary>
    /// Internal reference number for the booking.
    /// </summary>
    /// <value>Internal reference number for the booking.</value>
    [DataMember(Name="booking_reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "booking_reference")]
    public string BookingReference { get; set; }

    /// <summary>
    /// Reference number for the payment associated with the booking.
    /// </summary>
    /// <value>Reference number for the payment associated with the booking.</value>
    [DataMember(Name="payment_reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment_reference")]
    public string PaymentReference { get; set; }

    /// <summary>
    /// Current status of the booking.
    /// </summary>
    /// <value>Current status of the booking.</value>
    [DataMember(Name="booking_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "booking_status")]
    public string BookingStatus { get; set; }

    /// <summary>
    /// Tax applied to the booking.
    /// </summary>
    /// <value>Tax applied to the booking.</value>
    [DataMember(Name="booking_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "booking_tax")]
    public double? BookingTax { get; set; }

    /// <summary>
    /// Total price of the booking.
    /// </summary>
    /// <value>Total price of the booking.</value>
    [DataMember(Name="booking_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "booking_price")]
    public double? BookingPrice { get; set; }

    /// <summary>
    /// Currency used for the booking pricing.
    /// </summary>
    /// <value>Currency used for the booking pricing.</value>
    [DataMember(Name="booking_currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "booking_currency")]
    public string BookingCurrency { get; set; }

    /// <summary>
    /// Cancellation policies applicable to the booking.
    /// </summary>
    /// <value>Cancellation policies applicable to the booking.</value>
    [DataMember(Name="booking_cancellation_policies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "booking_cancellation_policies")]
    public string BookingCancellationPolicies { get; set; }

    /// <summary>
    /// Gets or Sets Customer
    /// </summary>
    [DataMember(Name="customer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer")]
    public FlightBookingCustomerSchema Customer { get; set; }

    /// <summary>
    /// Gets or Sets OfferRequest
    /// </summary>
    [DataMember(Name="offer_request", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_request")]
    public FlightOfferRequestSchema OfferRequest { get; set; }

    /// <summary>
    /// Gets or Sets Offer
    /// </summary>
    [DataMember(Name="offer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer")]
    public FlightOfferResponseItemSchema Offer { get; set; }

    /// <summary>
    /// List of passengers, each detailed in FlightBookingCustomerSchema.
    /// </summary>
    /// <value>List of passengers, each detailed in FlightBookingCustomerSchema.</value>
    [DataMember(Name="passengers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passengers")]
    public List<FlightBookingCustomerSchema> Passengers { get; set; }

    /// <summary>
    /// Indicates if the booking was successful.
    /// </summary>
    /// <value>Indicates if the booking was successful.</value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    /// <summary>
    /// Provides details on any error that occurred during the booking process.
    /// </summary>
    /// <value>Provides details on any error that occurred during the booking process.</value>
    [DataMember(Name="error_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_message")]
    public string ErrorMessage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FlightBookingResponseSchema {\n");
      sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
      sb.Append("  TenantId: ").Append(TenantId).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  SupplierId: ").Append(SupplierId).Append("\n");
      sb.Append("  BookingId: ").Append(BookingId).Append("\n");
      sb.Append("  SupplierBookingId: ").Append(SupplierBookingId).Append("\n");
      sb.Append("  SupplierBookingReference: ").Append(SupplierBookingReference).Append("\n");
      sb.Append("  CustomerReference: ").Append(CustomerReference).Append("\n");
      sb.Append("  BookingReference: ").Append(BookingReference).Append("\n");
      sb.Append("  PaymentReference: ").Append(PaymentReference).Append("\n");
      sb.Append("  BookingStatus: ").Append(BookingStatus).Append("\n");
      sb.Append("  BookingTax: ").Append(BookingTax).Append("\n");
      sb.Append("  BookingPrice: ").Append(BookingPrice).Append("\n");
      sb.Append("  BookingCurrency: ").Append(BookingCurrency).Append("\n");
      sb.Append("  BookingCancellationPolicies: ").Append(BookingCancellationPolicies).Append("\n");
      sb.Append("  Customer: ").Append(Customer).Append("\n");
      sb.Append("  OfferRequest: ").Append(OfferRequest).Append("\n");
      sb.Append("  Offer: ").Append(Offer).Append("\n");
      sb.Append("  Passengers: ").Append(Passengers).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
