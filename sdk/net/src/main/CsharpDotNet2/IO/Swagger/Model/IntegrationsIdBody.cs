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
  public class IntegrationsIdBody {
    /// <summary>
    /// Gets or Sets TenantId
    /// </summary>
    [DataMember(Name="tenant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tenant_id")]
    public string TenantId { get; set; }

    /// <summary>
    /// Gets or Sets CategoryId
    /// </summary>
    [DataMember(Name="category_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category_id")]
    public string CategoryId { get; set; }

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
    /// Gets or Sets Logo
    /// </summary>
    [DataMember(Name="logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logo")]
    public string Logo { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets CredentialsProduction
    /// </summary>
    [DataMember(Name="credentials_production", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credentials_production")]
    public IntegrationsCredentialsProduction CredentialsProduction { get; set; }

    /// <summary>
    /// Gets or Sets CredentialsSandbox
    /// </summary>
    [DataMember(Name="credentials_sandbox", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credentials_sandbox")]
    public IntegrationsCredentialsProduction CredentialsSandbox { get; set; }

    /// <summary>
    /// Gets or Sets EnvProduction
    /// </summary>
    [DataMember(Name="env_production", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "env_production")]
    public string EnvProduction { get; set; }

    /// <summary>
    /// Gets or Sets EnvSandbox
    /// </summary>
    [DataMember(Name="env_sandbox", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "env_sandbox")]
    public string EnvSandbox { get; set; }

    /// <summary>
    /// Gets or Sets SettingsProduction
    /// </summary>
    [DataMember(Name="settings_production", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "settings_production")]
    public IntegrationsSettingsProduction SettingsProduction { get; set; }

    /// <summary>
    /// Gets or Sets SettingsSandbox
    /// </summary>
    [DataMember(Name="settings_sandbox", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "settings_sandbox")]
    public IntegrationsSettingsProduction SettingsSandbox { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IntegrationsIdBody {\n");
      sb.Append("  TenantId: ").Append(TenantId).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Slug: ").Append(Slug).Append("\n");
      sb.Append("  Logo: ").Append(Logo).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  CredentialsProduction: ").Append(CredentialsProduction).Append("\n");
      sb.Append("  CredentialsSandbox: ").Append(CredentialsSandbox).Append("\n");
      sb.Append("  EnvProduction: ").Append(EnvProduction).Append("\n");
      sb.Append("  EnvSandbox: ").Append(EnvSandbox).Append("\n");
      sb.Append("  SettingsProduction: ").Append(SettingsProduction).Append("\n");
      sb.Append("  SettingsSandbox: ").Append(SettingsSandbox).Append("\n");
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
