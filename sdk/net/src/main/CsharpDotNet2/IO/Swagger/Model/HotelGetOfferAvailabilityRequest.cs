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
  public class HotelGetOfferAvailabilityRequest {
    /// <summary>
    /// Unique identifier of the hotel offer.
    /// </summary>
    /// <value>Unique identifier of the hotel offer.</value>
    [DataMember(Name="offer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_id")]
    public Guid? OfferId { get; set; }

    /// <summary>
    /// Scheduled check-in date for the hotel stay.
    /// </summary>
    /// <value>Scheduled check-in date for the hotel stay.</value>
    [DataMember(Name="checkin_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkin_date")]
    public DateTime? CheckinDate { get; set; }

    /// <summary>
    /// Scheduled check-out date for the hotel stay.
    /// </summary>
    /// <value>Scheduled check-out date for the hotel stay.</value>
    [DataMember(Name="checkout_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkout_date")]
    public DateTime? CheckoutDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HotelGetOfferAvailabilityRequest {\n");
      sb.Append("  OfferId: ").Append(OfferId).Append("\n");
      sb.Append("  CheckinDate: ").Append(CheckinDate).Append("\n");
      sb.Append("  CheckoutDate: ").Append(CheckoutDate).Append("\n");
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
