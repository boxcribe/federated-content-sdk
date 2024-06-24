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
  public class SchemasBody {
    /// <summary>
    /// The unique identifier of the tenant
    /// </summary>
    /// <value>The unique identifier of the tenant</value>
    [DataMember(Name="tenant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tenant_id")]
    public Guid? TenantId { get; set; }

    /// <summary>
    /// The unique identifier of the category
    /// </summary>
    /// <value>The unique identifier of the category</value>
    [DataMember(Name="category_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category_id")]
    public Guid? CategoryId { get; set; }

    /// <summary>
    /// Name of the schema
    /// </summary>
    /// <value>Name of the schema</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Slug for the schema
    /// </summary>
    /// <value>Slug for the schema</value>
    [DataMember(Name="slug", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "slug")]
    public string Slug { get; set; }

    /// <summary>
    /// Status of the schema
    /// </summary>
    /// <value>Status of the schema</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Whether the schema is a system schema
    /// </summary>
    /// <value>Whether the schema is a system schema</value>
    [DataMember(Name="system", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system")]
    public bool? System { get; set; }

    /// <summary>
    /// Endpoint URL
    /// </summary>
    /// <value>Endpoint URL</value>
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
    /// Type of the schema (Request or Response)
    /// </summary>
    /// <value>Type of the schema (Request or Response)</value>
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
      sb.Append("class SchemasBody {\n");
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
