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
  public class HotelBookingDetailsRequestSchema {
    /// <summary>
    /// Unique identifier of the booking for which details are requested.
    /// </summary>
    /// <value>Unique identifier of the booking for which details are requested.</value>
    [DataMember(Name="bookingId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bookingId")]
    public Guid? BookingId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HotelBookingDetailsRequestSchema {\n");
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
