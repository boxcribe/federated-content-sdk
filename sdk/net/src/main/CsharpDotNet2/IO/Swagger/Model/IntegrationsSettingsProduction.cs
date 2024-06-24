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
  public class IntegrationsSettingsProduction {
    /// <summary>
    /// Gets or Sets Timeout
    /// </summary>
    [DataMember(Name="timeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeout")]
    public int? Timeout { get; set; }

    /// <summary>
    /// Gets or Sets ProgressiveLoading
    /// </summary>
    [DataMember(Name="progressive_loading", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progressive_loading")]
    public bool? ProgressiveLoading { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IntegrationsSettingsProduction {\n");
      sb.Append("  Timeout: ").Append(Timeout).Append("\n");
      sb.Append("  ProgressiveLoading: ").Append(ProgressiveLoading).Append("\n");
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
