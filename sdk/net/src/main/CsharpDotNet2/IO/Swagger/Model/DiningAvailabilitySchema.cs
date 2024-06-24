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
  public class DiningAvailabilitySchema {
    /// <summary>
    /// Unique identifier for the dining availability.
    /// </summary>
    /// <value>Unique identifier for the dining availability.</value>
    [DataMember(Name="availability_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availability_id")]
    public Guid? AvailabilityId { get; set; }

    /// <summary>
    /// Identifier for the availability provided by the supplier.
    /// </summary>
    /// <value>Identifier for the availability provided by the supplier.</value>
    [DataMember(Name="supplier_availability_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplier_availability_id")]
    public Guid? SupplierAvailabilityId { get; set; }

    /// <summary>
    /// Index of the availability for sorting and reference.
    /// </summary>
    /// <value>Index of the availability for sorting and reference.</value>
    [DataMember(Name="availability_index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availability_index")]
    public decimal? AvailabilityIndex { get; set; }

    /// <summary>
    /// Date of availability for dining.
    /// </summary>
    /// <value>Date of availability for dining.</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Time of availability for dining.
    /// </summary>
    /// <value>Time of availability for dining.</value>
    [DataMember(Name="time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time")]
    public string Time { get; set; }

    /// <summary>
    /// Number of adults for the dining reservation.
    /// </summary>
    /// <value>Number of adults for the dining reservation.</value>
    [DataMember(Name="adults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adults")]
    public decimal? Adults { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DiningAvailabilitySchema {\n");
      sb.Append("  AvailabilityId: ").Append(AvailabilityId).Append("\n");
      sb.Append("  SupplierAvailabilityId: ").Append(SupplierAvailabilityId).Append("\n");
      sb.Append("  AvailabilityIndex: ").Append(AvailabilityIndex).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
      sb.Append("  Adults: ").Append(Adults).Append("\n");
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
