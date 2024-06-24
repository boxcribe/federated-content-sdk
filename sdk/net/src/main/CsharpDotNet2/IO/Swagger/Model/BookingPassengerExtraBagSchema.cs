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
  public class BookingPassengerExtraBagSchema {
    /// <summary>
    /// Identifier of the passenger with extra baggage.
    /// </summary>
    /// <value>Identifier of the passenger with extra baggage.</value>
    [DataMember(Name="passenger_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passenger_id")]
    public Guid? PassengerId { get; set; }

    /// <summary>
    /// Identifier of the flight leg associated with the extra baggage.
    /// </summary>
    /// <value>Identifier of the flight leg associated with the extra baggage.</value>
    [DataMember(Name="leg_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "leg_id")]
    public Guid? LegId { get; set; }

    /// <summary>
    /// Identifier of the flight segment associated with the extra baggage.
    /// </summary>
    /// <value>Identifier of the flight segment associated with the extra baggage.</value>
    [DataMember(Name="segment_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segment_id")]
    public Guid? SegmentId { get; set; }

    /// <summary>
    /// Type of bag added as extra baggage.
    /// </summary>
    /// <value>Type of bag added as extra baggage.</value>
    [DataMember(Name="bag_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bag_type")]
    public string BagType { get; set; }

    /// <summary>
    /// Quantity of the extra bags.
    /// </summary>
    /// <value>Quantity of the extra bags.</value>
    [DataMember(Name="bag_quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bag_quantity")]
    public int? BagQuantity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BookingPassengerExtraBagSchema {\n");
      sb.Append("  PassengerId: ").Append(PassengerId).Append("\n");
      sb.Append("  LegId: ").Append(LegId).Append("\n");
      sb.Append("  SegmentId: ").Append(SegmentId).Append("\n");
      sb.Append("  BagType: ").Append(BagType).Append("\n");
      sb.Append("  BagQuantity: ").Append(BagQuantity).Append("\n");
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
