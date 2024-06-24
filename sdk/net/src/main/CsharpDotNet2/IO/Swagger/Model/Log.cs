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
  public class Log {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Headers
    /// </summary>
    [DataMember(Name="headers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "headers")]
    public Object Headers { get; set; }

    /// <summary>
    /// Gets or Sets Request
    /// </summary>
    [DataMember(Name="request", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "request")]
    public Object Request { get; set; }

    /// <summary>
    /// Gets or Sets Response
    /// </summary>
    [DataMember(Name="response", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "response")]
    public Object Response { get; set; }

    /// <summary>
    /// Gets or Sets Date
    /// </summary>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Gets or Sets IntegrationId
    /// </summary>
    [DataMember(Name="integration_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "integration_id")]
    public Guid? IntegrationId { get; set; }

    /// <summary>
    /// Gets or Sets TenantId
    /// </summary>
    [DataMember(Name="tenant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tenant_id")]
    public Guid? TenantId { get; set; }

    /// <summary>
    /// Gets or Sets Method
    /// </summary>
    [DataMember(Name="method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "method")]
    public string Method { get; set; }

    /// <summary>
    /// Gets or Sets EndpointShortname
    /// </summary>
    [DataMember(Name="endpoint_shortname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endpoint_shortname")]
    public string EndpointShortname { get; set; }

    /// <summary>
    /// Gets or Sets ResponseTime
    /// </summary>
    [DataMember(Name="response_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "response_time")]
    public int? ResponseTime { get; set; }

    /// <summary>
    /// Gets or Sets ResponseCode
    /// </summary>
    [DataMember(Name="response_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "response_code")]
    public int? ResponseCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Log {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Headers: ").Append(Headers).Append("\n");
      sb.Append("  Request: ").Append(Request).Append("\n");
      sb.Append("  Response: ").Append(Response).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
      sb.Append("  TenantId: ").Append(TenantId).Append("\n");
      sb.Append("  Method: ").Append(Method).Append("\n");
      sb.Append("  EndpointShortname: ").Append(EndpointShortname).Append("\n");
      sb.Append("  ResponseTime: ").Append(ResponseTime).Append("\n");
      sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
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
