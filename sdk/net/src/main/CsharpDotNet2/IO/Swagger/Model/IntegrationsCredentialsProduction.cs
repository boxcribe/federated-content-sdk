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
  public class IntegrationsCredentialsProduction {
    /// <summary>
    /// Gets or Sets ApiUrl
    /// </summary>
    [DataMember(Name="api_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "api_url")]
    public string ApiUrl { get; set; }

    /// <summary>
    /// Gets or Sets ClientId
    /// </summary>
    [DataMember(Name="client_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client_id")]
    public string ClientId { get; set; }

    /// <summary>
    /// Gets or Sets ClientSecret
    /// </summary>
    [DataMember(Name="client_secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client_secret")]
    public string ClientSecret { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IntegrationsCredentialsProduction {\n");
      sb.Append("  ApiUrl: ").Append(ApiUrl).Append("\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
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
