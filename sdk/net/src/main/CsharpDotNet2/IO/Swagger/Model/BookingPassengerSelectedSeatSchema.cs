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
  public class BookingPassengerSelectedSeatSchema {
    /// <summary>
    /// Identifier of the passenger selecting a seat.
    /// </summary>
    /// <value>Identifier of the passenger selecting a seat.</value>
    [DataMember(Name="passenger_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passenger_id")]
    public Guid? PassengerId { get; set; }

    /// <summary>
    /// Identifier of the flight leg associated with the seat selection.
    /// </summary>
    /// <value>Identifier of the flight leg associated with the seat selection.</value>
    [DataMember(Name="leg_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "leg_id")]
    public Guid? LegId { get; set; }

    /// <summary>
    /// Identifier of the flight segment for the seat selection.
    /// </summary>
    /// <value>Identifier of the flight segment for the seat selection.</value>
    [DataMember(Name="segment_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segment_id")]
    public Guid? SegmentId { get; set; }

    /// <summary>
    /// Seat number selected by the passenger.
    /// </summary>
    /// <value>Seat number selected by the passenger.</value>
    [DataMember(Name="seat_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seat_number")]
    public string SeatNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BookingPassengerSelectedSeatSchema {\n");
      sb.Append("  PassengerId: ").Append(PassengerId).Append("\n");
      sb.Append("  LegId: ").Append(LegId).Append("\n");
      sb.Append("  SegmentId: ").Append(SegmentId).Append("\n");
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
