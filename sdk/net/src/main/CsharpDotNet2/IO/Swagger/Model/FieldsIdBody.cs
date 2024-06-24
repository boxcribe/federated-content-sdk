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
  public class FieldsIdBody {
    /// <summary>
    /// Gets or Sets TenantId
    /// </summary>
    [DataMember(Name="tenant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tenant_id")]
    public string TenantId { get; set; }

    /// <summary>
    /// Gets or Sets SchemaId
    /// </summary>
    [DataMember(Name="schema_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schema_id")]
    public string SchemaId { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Slug
    /// </summary>
    [DataMember(Name="slug", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "slug")]
    public string Slug { get; set; }

    /// <summary>
    /// Description of the field
    /// </summary>
    /// <value>Description of the field</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets IsSearchable
    /// </summary>
    [DataMember(Name="is_searchable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_searchable")]
    public bool? IsSearchable { get; set; }

    /// <summary>
    /// Gets or Sets IsSortable
    /// </summary>
    [DataMember(Name="is_sortable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_sortable")]
    public bool? IsSortable { get; set; }

    /// <summary>
    /// Gets or Sets System
    /// </summary>
    [DataMember(Name="system", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system")]
    public bool? System { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FieldsIdBody {\n");
      sb.Append("  TenantId: ").Append(TenantId).Append("\n");
      sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Slug: ").Append(Slug).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  IsSearchable: ").Append(IsSearchable).Append("\n");
      sb.Append("  IsSortable: ").Append(IsSortable).Append("\n");
      sb.Append("  System: ").Append(System).Append("\n");
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
