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
  public class FlightLegOfferRequestSchema {
    /// <summary>
    /// IATA code for the origin airport.
    /// </summary>
    /// <value>IATA code for the origin airport.</value>
    [DataMember(Name="origin_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin_code")]
    public string OriginCode { get; set; }

    /// <summary>
    /// IATA code for the destination airport.
    /// </summary>
    /// <value>IATA code for the destination airport.</value>
    [DataMember(Name="destination_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destination_code")]
    public string DestinationCode { get; set; }

    /// <summary>
    /// Scheduled date of departure.
    /// </summary>
    /// <value>Scheduled date of departure.</value>
    [DataMember(Name="departure_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "departure_date")]
    public DateTime? DepartureDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FlightLegOfferRequestSchema {\n");
      sb.Append("  OriginCode: ").Append(OriginCode).Append("\n");
      sb.Append("  DestinationCode: ").Append(DestinationCode).Append("\n");
      sb.Append("  DepartureDate: ").Append(DepartureDate).Append("\n");
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
