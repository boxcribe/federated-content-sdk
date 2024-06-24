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
  public class FlightOfferDetailsRequestSchemaRepriceRequest {
    /// <summary>
    /// Unique identifier of the flight offer to be repriced.
    /// </summary>
    /// <value>Unique identifier of the flight offer to be repriced.</value>
    [DataMember(Name="offer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_id")]
    public Guid? OfferId { get; set; }

    /// <summary>
    /// Array of passenger seats, each defined in OfferPassengerSelectedSeatSchema.
    /// </summary>
    /// <value>Array of passenger seats, each defined in OfferPassengerSelectedSeatSchema.</value>
    [DataMember(Name="seats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seats")]
    public List<OfferPassengerSelectedSeatSchema> Seats { get; set; }

    /// <summary>
    /// Array of extra baggage, each defined in OfferPassengerExtraBagSchema.
    /// </summary>
    /// <value>Array of extra baggage, each defined in OfferPassengerExtraBagSchema.</value>
    [DataMember(Name="bags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bags")]
    public List<OfferPassengerExtraBagSchema> Bags { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FlightOfferDetailsRequestSchemaRepriceRequest {\n");
      sb.Append("  OfferId: ").Append(OfferId).Append("\n");
      sb.Append("  Seats: ").Append(Seats).Append("\n");
      sb.Append("  Bags: ").Append(Bags).Append("\n");
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
