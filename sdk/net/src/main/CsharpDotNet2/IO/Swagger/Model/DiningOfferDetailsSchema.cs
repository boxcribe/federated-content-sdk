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
  public class DiningOfferDetailsSchema {
    /// <summary>
    /// Array of DiningAvailabilitySchema.
    /// </summary>
    /// <value>Array of DiningAvailabilitySchema.</value>
    [DataMember(Name="availabilities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availabilities")]
    public List<DiningAvailabilitySchema> Availabilities { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DiningOfferDetailsSchema {\n");
      sb.Append("  Availabilities: ").Append(Availabilities).Append("\n");
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
