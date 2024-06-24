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
  public class FlightOfferSeatmapSchema {
    /// <summary>
    /// Unique identifier for a specific seatmap.
    /// </summary>
    /// <value>Unique identifier for a specific seatmap.</value>
    [DataMember(Name="seatmap_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seatmap_id")]
    public Guid? SeatmapId { get; set; }

    /// <summary>
    /// Identifier for a specific leg of the journey related to the seatmap.
    /// </summary>
    /// <value>Identifier for a specific leg of the journey related to the seatmap.</value>
    [DataMember(Name="leg_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "leg_id")]
    public Guid? LegId { get; set; }

    /// <summary>
    /// Identifier for a specific segment of the journey related to the seatmap.
    /// </summary>
    /// <value>Identifier for a specific segment of the journey related to the seatmap.</value>
    [DataMember(Name="segment_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segment_id")]
    public Guid? SegmentId { get; set; }

    /// <summary>
    /// Json data containing detailed seatmap information including layout and availability.
    /// </summary>
    /// <value>Json data containing detailed seatmap information including layout and availability.</value>
    [DataMember(Name="seatmap_data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seatmap_data")]
    public Object SeatmapData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FlightOfferSeatmapSchema {\n");
      sb.Append("  SeatmapId: ").Append(SeatmapId).Append("\n");
      sb.Append("  LegId: ").Append(LegId).Append("\n");
      sb.Append("  SegmentId: ").Append(SegmentId).Append("\n");
      sb.Append("  SeatmapData: ").Append(SeatmapData).Append("\n");
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
