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
  public class TransportGetOfferAvailabilityRequest {
    /// <summary>
    /// Unique identifier of the transport offer.
    /// </summary>
    /// <value>Unique identifier of the transport offer.</value>
    [DataMember(Name="offer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_id")]
    public Guid? OfferId { get; set; }

    /// <summary>
    /// Date of the pickup.
    /// </summary>
    /// <value>Date of the pickup.</value>
    [DataMember(Name="pickup_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_date")]
    public DateTime? PickupDate { get; set; }

    /// <summary>
    /// Time of the pickup.
    /// </summary>
    /// <value>Time of the pickup.</value>
    [DataMember(Name="pickup_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_time")]
    public string PickupTime { get; set; }

    /// <summary>
    /// Number of adults.
    /// </summary>
    /// <value>Number of adults.</value>
    [DataMember(Name="adults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adults")]
    public int? Adults { get; set; }

    /// <summary>
    /// Number of children.
    /// </summary>
    /// <value>Number of children.</value>
    [DataMember(Name="children", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "children")]
    public int? Children { get; set; }

    /// <summary>
    /// Date of the return.
    /// </summary>
    /// <value>Date of the return.</value>
    [DataMember(Name="return_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_date")]
    public DateTime? ReturnDate { get; set; }

    /// <summary>
    /// Time of the return.
    /// </summary>
    /// <value>Time of the return.</value>
    [DataMember(Name="return_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_time")]
    public string ReturnTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransportGetOfferAvailabilityRequest {\n");
      sb.Append("  OfferId: ").Append(OfferId).Append("\n");
      sb.Append("  PickupDate: ").Append(PickupDate).Append("\n");
      sb.Append("  PickupTime: ").Append(PickupTime).Append("\n");
      sb.Append("  Adults: ").Append(Adults).Append("\n");
      sb.Append("  Children: ").Append(Children).Append("\n");
      sb.Append("  ReturnDate: ").Append(ReturnDate).Append("\n");
      sb.Append("  ReturnTime: ").Append(ReturnTime).Append("\n");
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
