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
  public class FlightOfferResponseItemSchema {
    /// <summary>
    /// Unique identifier for the offer.
    /// </summary>
    /// <value>Unique identifier for the offer.</value>
    [DataMember(Name="offer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_id")]
    public Guid? OfferId { get; set; }

    /// <summary>
    /// Unique identifier for the supplier’s offer.
    /// </summary>
    /// <value>Unique identifier for the supplier’s offer.</value>
    [DataMember(Name="supplier_offer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplier_offer_id")]
    public Guid? SupplierOfferId { get; set; }

    /// <summary>
    /// Index of the offer for sorting purposes.
    /// </summary>
    /// <value>Index of the offer for sorting purposes.</value>
    [DataMember(Name="offer_index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_index")]
    public int? OfferIndex { get; set; }

    /// <summary>
    /// Price of the offer.
    /// </summary>
    /// <value>Price of the offer.</value>
    [DataMember(Name="offer_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_price")]
    public double? OfferPrice { get; set; }

    /// <summary>
    /// Currency of the offer price.
    /// </summary>
    /// <value>Currency of the offer price.</value>
    [DataMember(Name="offer_currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_currency")]
    public string OfferCurrency { get; set; }

    /// <summary>
    /// Cancellation policies applicable to the offer.
    /// </summary>
    /// <value>Cancellation policies applicable to the offer.</value>
    [DataMember(Name="offer_cancelation_policies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_cancelation_policies")]
    public Dictionary<string, Object> OfferCancelationPolicies { get; set; }

    /// <summary>
    /// Name of the airline providing the offer.
    /// </summary>
    /// <value>Name of the airline providing the offer.</value>
    [DataMember(Name="offer_airline_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_airline_name")]
    public string OfferAirlineName { get; set; }

    /// <summary>
    /// Code of the airline providing the offer.
    /// </summary>
    /// <value>Code of the airline providing the offer.</value>
    [DataMember(Name="offer_airline_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_airline_code")]
    public string OfferAirlineCode { get; set; }

    /// <summary>
    /// Logo URL of the airline.
    /// </summary>
    /// <value>Logo URL of the airline.</value>
    [DataMember(Name="offer_airline_logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_airline_logo")]
    public string OfferAirlineLogo { get; set; }

    /// <summary>
    /// Array of flight legs, each described in FlightLegOfferRequestSchema.
    /// </summary>
    /// <value>Array of flight legs, each described in FlightLegOfferRequestSchema.</value>
    [DataMember(Name="legs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "legs")]
    public List<FlightLegOfferRequestSchema> Legs { get; set; }

    /// <summary>
    /// Array of passengers, each described in FlightPassengerOfferRequestSchema.
    /// </summary>
    /// <value>Array of passengers, each described in FlightPassengerOfferRequestSchema.</value>
    [DataMember(Name="passengers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passengers")]
    public List<FlightPassengerOfferRequestSchema> Passengers { get; set; }

    /// <summary>
    /// Array of codes for accessing special negotiated fares.
    /// </summary>
    /// <value>Array of codes for accessing special negotiated fares.</value>
    [DataMember(Name="private_fare_codes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "private_fare_codes")]
    public List<string> PrivateFareCodes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FlightOfferResponseItemSchema {\n");
      sb.Append("  OfferId: ").Append(OfferId).Append("\n");
      sb.Append("  SupplierOfferId: ").Append(SupplierOfferId).Append("\n");
      sb.Append("  OfferIndex: ").Append(OfferIndex).Append("\n");
      sb.Append("  OfferPrice: ").Append(OfferPrice).Append("\n");
      sb.Append("  OfferCurrency: ").Append(OfferCurrency).Append("\n");
      sb.Append("  OfferCancelationPolicies: ").Append(OfferCancelationPolicies).Append("\n");
      sb.Append("  OfferAirlineName: ").Append(OfferAirlineName).Append("\n");
      sb.Append("  OfferAirlineCode: ").Append(OfferAirlineCode).Append("\n");
      sb.Append("  OfferAirlineLogo: ").Append(OfferAirlineLogo).Append("\n");
      sb.Append("  Legs: ").Append(Legs).Append("\n");
      sb.Append("  Passengers: ").Append(Passengers).Append("\n");
      sb.Append("  PrivateFareCodes: ").Append(PrivateFareCodes).Append("\n");
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
