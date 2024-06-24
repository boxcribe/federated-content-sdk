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
  public class CarCreateBookingRequestSchema {
    /// <summary>
    /// Unique identifier for the offer.
    /// </summary>
    /// <value>Unique identifier for the offer.</value>
    [DataMember(Name="offer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_id")]
    public Guid? OfferId { get; set; }

    /// <summary>
    /// Gets or Sets Customer
    /// </summary>
    [DataMember(Name="customer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer")]
    public CarCreateBookingCustomerSchema Customer { get; set; }

    /// <summary>
    /// Gets or Sets Payment
    /// </summary>
    [DataMember(Name="payment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment")]
    public CarCreateBookingPaymentSchema Payment { get; set; }

    /// <summary>
    /// Currency used for the booking.
    /// </summary>
    /// <value>Currency used for the booking.</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Customer reference identifier.
    /// </summary>
    /// <value>Customer reference identifier.</value>
    [DataMember(Name="customer_reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer_reference")]
    public string CustomerReference { get; set; }

    /// <summary>
    /// Booking reference identifier.
    /// </summary>
    /// <value>Booking reference identifier.</value>
    [DataMember(Name="booking_reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "booking_reference")]
    public string BookingReference { get; set; }

    /// <summary>
    /// Payment transaction reference.
    /// </summary>
    /// <value>Payment transaction reference.</value>
    [DataMember(Name="payment_reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment_reference")]
    public string PaymentReference { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CarCreateBookingRequestSchema {\n");
      sb.Append("  OfferId: ").Append(OfferId).Append("\n");
      sb.Append("  Customer: ").Append(Customer).Append("\n");
      sb.Append("  Payment: ").Append(Payment).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  CustomerReference: ").Append(CustomerReference).Append("\n");
      sb.Append("  BookingReference: ").Append(BookingReference).Append("\n");
      sb.Append("  PaymentReference: ").Append(PaymentReference).Append("\n");
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
