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
  public class DiningBookingDetailsRequestSchema {
    /// <summary>
    /// Identifier of the booking for which details are requested.
    /// </summary>
    /// <value>Identifier of the booking for which details are requested.</value>
    [DataMember(Name="booking_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "booking_id")]
    public Guid? BookingId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DiningBookingDetailsRequestSchema {\n");
      sb.Append("  BookingId: ").Append(BookingId).Append("\n");
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
