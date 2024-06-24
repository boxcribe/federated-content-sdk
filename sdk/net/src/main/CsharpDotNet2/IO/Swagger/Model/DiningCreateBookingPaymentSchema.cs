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
  public class DiningCreateBookingPaymentSchema {
    /// <summary>
    /// Credit card number.
    /// </summary>
    /// <value>Credit card number.</value>
    [DataMember(Name="card_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "card_number")]
    public string CardNumber { get; set; }

    /// <summary>
    /// Month of card expiration.
    /// </summary>
    /// <value>Month of card expiration.</value>
    [DataMember(Name="card_expiration_month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "card_expiration_month")]
    public decimal? CardExpirationMonth { get; set; }

    /// <summary>
    /// Year of card expiration.
    /// </summary>
    /// <value>Year of card expiration.</value>
    [DataMember(Name="card_expiration_year", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "card_expiration_year")]
    public decimal? CardExpirationYear { get; set; }

    /// <summary>
    /// Card security code.
    /// </summary>
    /// <value>Card security code.</value>
    [DataMember(Name="card_cvv", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "card_cvv")]
    public string CardCvv { get; set; }

    /// <summary>
    /// Name on credit card.
    /// </summary>
    /// <value>Name on credit card.</value>
    [DataMember(Name="card_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "card_name")]
    public string CardName { get; set; }

    /// <summary>
    /// Billing address for the card.
    /// </summary>
    /// <value>Billing address for the card.</value>
    [DataMember(Name="billing_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_address")]
    public string BillingAddress { get; set; }

    /// <summary>
    /// City of the billing address.
    /// </summary>
    /// <value>City of the billing address.</value>
    [DataMember(Name="billing_city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_city")]
    public string BillingCity { get; set; }

    /// <summary>
    /// State of the billing address.
    /// </summary>
    /// <value>State of the billing address.</value>
    [DataMember(Name="billing_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_state")]
    public string BillingState { get; set; }

    /// <summary>
    /// Postal code of the billing address.
    /// </summary>
    /// <value>Postal code of the billing address.</value>
    [DataMember(Name="billing_zip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_zip")]
    public string BillingZip { get; set; }

    /// <summary>
    /// Country of the billing address.
    /// </summary>
    /// <value>Country of the billing address.</value>
    [DataMember(Name="billing_country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_country")]
    public string BillingCountry { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DiningCreateBookingPaymentSchema {\n");
      sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
      sb.Append("  CardExpirationMonth: ").Append(CardExpirationMonth).Append("\n");
      sb.Append("  CardExpirationYear: ").Append(CardExpirationYear).Append("\n");
      sb.Append("  CardCvv: ").Append(CardCvv).Append("\n");
      sb.Append("  CardName: ").Append(CardName).Append("\n");
      sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
      sb.Append("  BillingCity: ").Append(BillingCity).Append("\n");
      sb.Append("  BillingState: ").Append(BillingState).Append("\n");
      sb.Append("  BillingZip: ").Append(BillingZip).Append("\n");
      sb.Append("  BillingCountry: ").Append(BillingCountry).Append("\n");
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
