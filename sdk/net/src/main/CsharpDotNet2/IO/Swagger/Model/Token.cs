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
  public class Token {
    /// <summary>
    /// Gets or Sets _Token
    /// </summary>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string _Token { get; set; }

    /// <summary>
    /// Gets or Sets Expires
    /// </summary>
    [DataMember(Name="expires", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expires")]
    public DateTime? Expires { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Token {\n");
      sb.Append("  _Token: ").Append(_Token).Append("\n");
      sb.Append("  Expires: ").Append(Expires).Append("\n");
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
