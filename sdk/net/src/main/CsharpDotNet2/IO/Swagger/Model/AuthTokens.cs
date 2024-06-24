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
  public class AuthTokens {
    /// <summary>
    /// Gets or Sets Access
    /// </summary>
    [DataMember(Name="access", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access")]
    public Token Access { get; set; }

    /// <summary>
    /// Gets or Sets Refresh
    /// </summary>
    [DataMember(Name="refresh", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refresh")]
    public Token Refresh { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthTokens {\n");
      sb.Append("  Access: ").Append(Access).Append("\n");
      sb.Append("  Refresh: ").Append(Refresh).Append("\n");
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
