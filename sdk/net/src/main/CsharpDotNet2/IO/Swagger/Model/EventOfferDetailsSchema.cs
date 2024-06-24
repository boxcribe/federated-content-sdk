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
  public class EventOfferDetailsSchema {
    /// <summary>
    /// Array of EventTicketSchema.
    /// </summary>
    /// <value>Array of EventTicketSchema.</value>
    [DataMember(Name="tickets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tickets")]
    public List<EventTicketSchema> Tickets { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EventOfferDetailsSchema {\n");
      sb.Append("  Tickets: ").Append(Tickets).Append("\n");
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
