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
  public class CarGetOfferAvailabilityRequest {
    /// <summary>
    /// Unique identifier of the car offer.
    /// </summary>
    /// <value>Unique identifier of the car offer.</value>
    [DataMember(Name="offer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_id")]
    public Guid? OfferId { get; set; }

    /// <summary>
    /// Scheduled date for car pickup.
    /// </summary>
    /// <value>Scheduled date for car pickup.</value>
    [DataMember(Name="pickup_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_date")]
    public DateTime? PickupDate { get; set; }

    /// <summary>
    /// Scheduled time for car pickup.
    /// </summary>
    /// <value>Scheduled time for car pickup.</value>
    [DataMember(Name="pickup_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_time")]
    public string PickupTime { get; set; }

    /// <summary>
    /// Scheduled date for car dropoff.
    /// </summary>
    /// <value>Scheduled date for car dropoff.</value>
    [DataMember(Name="dropoff_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dropoff_date")]
    public DateTime? DropoffDate { get; set; }

    /// <summary>
    /// Scheduled time for car dropoff.
    /// </summary>
    /// <value>Scheduled time for car dropoff.</value>
    [DataMember(Name="dropoff_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dropoff_time")]
    public string DropoffTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CarGetOfferAvailabilityRequest {\n");
      sb.Append("  OfferId: ").Append(OfferId).Append("\n");
      sb.Append("  PickupDate: ").Append(PickupDate).Append("\n");
      sb.Append("  PickupTime: ").Append(PickupTime).Append("\n");
      sb.Append("  DropoffDate: ").Append(DropoffDate).Append("\n");
      sb.Append("  DropoffTime: ").Append(DropoffTime).Append("\n");
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
