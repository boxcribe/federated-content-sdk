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
  public class Schema {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets TenantId
    /// </summary>
    [DataMember(Name="tenant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tenant_id")]
    public Guid? TenantId { get; set; }

    /// <summary>
    /// Gets or Sets CategoryId
    /// </summary>
    [DataMember(Name="category_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category_id")]
    public Guid? CategoryId { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Slug
    /// </summary>
    [DataMember(Name="slug", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "slug")]
    public string Slug { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets System
    /// </summary>
    [DataMember(Name="system", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system")]
    public bool? System { get; set; }

    /// <summary>
    /// Endpoint url
    /// </summary>
    /// <value>Endpoint url</value>
    [DataMember(Name="endpoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endpoint")]
    public string Endpoint { get; set; }

    /// <summary>
    /// Endpoint name (Group name)
    /// </summary>
    /// <value>Endpoint name (Group name)</value>
    [DataMember(Name="endpoint_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endpoint_name")]
    public string EndpointName { get; set; }

    /// <summary>
    /// Either a Request or Response type (SubGroup name)
    /// </summary>
    /// <value>Either a Request or Response type (SubGroup name)</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// HTTP method for Request types
    /// </summary>
    /// <value>HTTP method for Request types</value>
    [DataMember(Name="method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "method")]
    public string Method { get; set; }

    /// <summary>
    /// Headers for Request type, stored in JSON format
    /// </summary>
    /// <value>Headers for Request type, stored in JSON format</value>
    [DataMember(Name="headers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "headers")]
    public Dictionary<string, string> Headers { get; set; }

    /// <summary>
    /// Query parameters for Request type, stored in JSON format
    /// </summary>
    /// <value>Query parameters for Request type, stored in JSON format</value>
    [DataMember(Name="query", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "query")]
    public Dictionary<string, string> Query { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Schema {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  TenantId: ").Append(TenantId).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Slug: ").Append(Slug).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  System: ").Append(System).Append("\n");
      sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
      sb.Append("  EndpointName: ").Append(EndpointName).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Method: ").Append(Method).Append("\n");
      sb.Append("  Headers: ").Append(Headers).Append("\n");
      sb.Append("  Query: ").Append(Query).Append("\n");
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
