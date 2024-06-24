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
  public class FlightOfferSegmentPassengerSchema {
    /// <summary>
    /// Unique identifier for a passenger.
    /// </summary>
    /// <value>Unique identifier for a passenger.</value>
    [DataMember(Name="passenger_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passenger_id")]
    public Guid? PassengerId { get; set; }

    /// <summary>
    /// Class options: first, business, premium economy, economy.
    /// </summary>
    /// <value>Class options: first, business, premium economy, economy.</value>
    [DataMember(Name="cabin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cabin")]
    public string Cabin { get; set; }

    /// <summary>
    /// Array of extra baggage, detailing type and qty.
    /// </summary>
    /// <value>Array of extra baggage, detailing type and qty.</value>
    [DataMember(Name="bags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bags")]
    public List<FlightOfferSegmentPassengerSchemaBags> Bags { get; set; }

    /// <summary>
    /// Seat number assigned to the passenger, returned only on reprice with seat selection.
    /// </summary>
    /// <value>Seat number assigned to the passenger, returned only on reprice with seat selection.</value>
    [DataMember(Name="seat_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seat_number")]
    public string SeatNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FlightOfferSegmentPassengerSchema {\n");
      sb.Append("  PassengerId: ").Append(PassengerId).Append("\n");
      sb.Append("  Cabin: ").Append(Cabin).Append("\n");
      sb.Append("  Bags: ").Append(Bags).Append("\n");
      sb.Append("  SeatNumber: ").Append(SeatNumber).Append("\n");
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
