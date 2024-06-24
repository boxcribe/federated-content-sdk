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
  public class FlightOfferLegSchema {
    /// <summary>
    /// Unique identifier for the leg of a journey.
    /// </summary>
    /// <value>Unique identifier for the leg of a journey.</value>
    [DataMember(Name="leg_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "leg_id")]
    public Guid? LegId { get; set; }

    /// <summary>
    /// Duration of the leg in minutes.
    /// </summary>
    /// <value>Duration of the leg in minutes.</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public int? Duration { get; set; }

    /// <summary>
    /// Array of Flight Offer Segment Schedule.
    /// </summary>
    /// <value>Array of Flight Offer Segment Schedule.</value>
    [DataMember(Name="segments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segments")]
    public List<FlightOfferSegmentSchema> Segments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FlightOfferLegSchema {\n");
      sb.Append("  LegId: ").Append(LegId).Append("\n");
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      sb.Append("  Segments: ").Append(Segments).Append("\n");
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
