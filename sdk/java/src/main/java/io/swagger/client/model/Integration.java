/*
 * Federated Content API
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.UUID;
/**
 * Integration
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class Integration {
  @SerializedName("id")
  private UUID id = null;

  @SerializedName("tenant_id")
  private UUID tenantId = null;

  @SerializedName("category_id")
  private UUID categoryId = null;

  @SerializedName("name")
  private String name = null;

  @SerializedName("slug")
  private String slug = null;

  @SerializedName("logo")
  private String logo = null;

  /**
   * Gets or Sets status
   */
  @JsonAdapter(StatusEnum.Adapter.class)
  public enum StatusEnum {
    @SerializedName("Active")
    ACTIVE("Active"),
    @SerializedName("Inactive")
    INACTIVE("Inactive");

    private String value;

    StatusEnum(String value) {
      this.value = value;
    }
    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
    public static StatusEnum fromValue(String input) {
      for (StatusEnum b : StatusEnum.values()) {
        if (b.value.equals(input)) {
          return b;
        }
      }
      return null;
    }
    public static class Adapter extends TypeAdapter<StatusEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final StatusEnum enumeration) throws IOException {
        jsonWriter.value(String.valueOf(enumeration.getValue()));
      }

      @Override
      public StatusEnum read(final JsonReader jsonReader) throws IOException {
        Object value = jsonReader.nextString();
        return StatusEnum.fromValue((String)(value));
      }
    }
  }  @SerializedName("status")
  private StatusEnum status = StatusEnum.ACTIVE;

  @SerializedName("credentials_production")
  private Object credentialsProduction = null;

  @SerializedName("credentials_sandbox")
  private Object credentialsSandbox = null;

  /**
   * Gets or Sets envProduction
   */
  @JsonAdapter(EnvProductionEnum.Adapter.class)
  public enum EnvProductionEnum {
    @SerializedName("Production")
    PRODUCTION("Production"),
    @SerializedName("Sandbox")
    SANDBOX("Sandbox");

    private String value;

    EnvProductionEnum(String value) {
      this.value = value;
    }
    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
    public static EnvProductionEnum fromValue(String input) {
      for (EnvProductionEnum b : EnvProductionEnum.values()) {
        if (b.value.equals(input)) {
          return b;
        }
      }
      return null;
    }
    public static class Adapter extends TypeAdapter<EnvProductionEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final EnvProductionEnum enumeration) throws IOException {
        jsonWriter.value(String.valueOf(enumeration.getValue()));
      }

      @Override
      public EnvProductionEnum read(final JsonReader jsonReader) throws IOException {
        Object value = jsonReader.nextString();
        return EnvProductionEnum.fromValue((String)(value));
      }
    }
  }  @SerializedName("env_production")
  private EnvProductionEnum envProduction = EnvProductionEnum.PRODUCTION;

  /**
   * Gets or Sets envSandbox
   */
  @JsonAdapter(EnvSandboxEnum.Adapter.class)
  public enum EnvSandboxEnum {
    @SerializedName("Production")
    PRODUCTION("Production"),
    @SerializedName("Sandbox")
    SANDBOX("Sandbox");

    private String value;

    EnvSandboxEnum(String value) {
      this.value = value;
    }
    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
    public static EnvSandboxEnum fromValue(String input) {
      for (EnvSandboxEnum b : EnvSandboxEnum.values()) {
        if (b.value.equals(input)) {
          return b;
        }
      }
      return null;
    }
    public static class Adapter extends TypeAdapter<EnvSandboxEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final EnvSandboxEnum enumeration) throws IOException {
        jsonWriter.value(String.valueOf(enumeration.getValue()));
      }

      @Override
      public EnvSandboxEnum read(final JsonReader jsonReader) throws IOException {
        Object value = jsonReader.nextString();
        return EnvSandboxEnum.fromValue((String)(value));
      }
    }
  }  @SerializedName("env_sandbox")
  private EnvSandboxEnum envSandbox = EnvSandboxEnum.SANDBOX;

  @SerializedName("settings_production")
  private Object settingsProduction = null;

  @SerializedName("settings_sandbox")
  private Object settingsSandbox = null;

  public Integration id(UUID id) {
    this.id = id;
    return this;
  }

   /**
   * Get id
   * @return id
  **/
  @Schema(description = "")
  public UUID getId() {
    return id;
  }

  public void setId(UUID id) {
    this.id = id;
  }

  public Integration tenantId(UUID tenantId) {
    this.tenantId = tenantId;
    return this;
  }

   /**
   * Get tenantId
   * @return tenantId
  **/
  @Schema(description = "")
  public UUID getTenantId() {
    return tenantId;
  }

  public void setTenantId(UUID tenantId) {
    this.tenantId = tenantId;
  }

  public Integration categoryId(UUID categoryId) {
    this.categoryId = categoryId;
    return this;
  }

   /**
   * Get categoryId
   * @return categoryId
  **/
  @Schema(description = "")
  public UUID getCategoryId() {
    return categoryId;
  }

  public void setCategoryId(UUID categoryId) {
    this.categoryId = categoryId;
  }

  public Integration name(String name) {
    this.name = name;
    return this;
  }

   /**
   * Get name
   * @return name
  **/
  @Schema(description = "")
  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public Integration slug(String slug) {
    this.slug = slug;
    return this;
  }

   /**
   * Get slug
   * @return slug
  **/
  @Schema(description = "")
  public String getSlug() {
    return slug;
  }

  public void setSlug(String slug) {
    this.slug = slug;
  }

  public Integration logo(String logo) {
    this.logo = logo;
    return this;
  }

   /**
   * Get logo
   * @return logo
  **/
  @Schema(description = "")
  public String getLogo() {
    return logo;
  }

  public void setLogo(String logo) {
    this.logo = logo;
  }

  public Integration status(StatusEnum status) {
    this.status = status;
    return this;
  }

   /**
   * Get status
   * @return status
  **/
  @Schema(description = "")
  public StatusEnum getStatus() {
    return status;
  }

  public void setStatus(StatusEnum status) {
    this.status = status;
  }

  public Integration credentialsProduction(Object credentialsProduction) {
    this.credentialsProduction = credentialsProduction;
    return this;
  }

   /**
   * Production Credentials
   * @return credentialsProduction
  **/
  @Schema(description = "Production Credentials")
  public Object getCredentialsProduction() {
    return credentialsProduction;
  }

  public void setCredentialsProduction(Object credentialsProduction) {
    this.credentialsProduction = credentialsProduction;
  }

  public Integration credentialsSandbox(Object credentialsSandbox) {
    this.credentialsSandbox = credentialsSandbox;
    return this;
  }

   /**
   * Sandbox Credentials
   * @return credentialsSandbox
  **/
  @Schema(description = "Sandbox Credentials")
  public Object getCredentialsSandbox() {
    return credentialsSandbox;
  }

  public void setCredentialsSandbox(Object credentialsSandbox) {
    this.credentialsSandbox = credentialsSandbox;
  }

  public Integration envProduction(EnvProductionEnum envProduction) {
    this.envProduction = envProduction;
    return this;
  }

   /**
   * Get envProduction
   * @return envProduction
  **/
  @Schema(description = "")
  public EnvProductionEnum getEnvProduction() {
    return envProduction;
  }

  public void setEnvProduction(EnvProductionEnum envProduction) {
    this.envProduction = envProduction;
  }

  public Integration envSandbox(EnvSandboxEnum envSandbox) {
    this.envSandbox = envSandbox;
    return this;
  }

   /**
   * Get envSandbox
   * @return envSandbox
  **/
  @Schema(description = "")
  public EnvSandboxEnum getEnvSandbox() {
    return envSandbox;
  }

  public void setEnvSandbox(EnvSandboxEnum envSandbox) {
    this.envSandbox = envSandbox;
  }

  public Integration settingsProduction(Object settingsProduction) {
    this.settingsProduction = settingsProduction;
    return this;
  }

   /**
   * Production Settings
   * @return settingsProduction
  **/
  @Schema(description = "Production Settings")
  public Object getSettingsProduction() {
    return settingsProduction;
  }

  public void setSettingsProduction(Object settingsProduction) {
    this.settingsProduction = settingsProduction;
  }

  public Integration settingsSandbox(Object settingsSandbox) {
    this.settingsSandbox = settingsSandbox;
    return this;
  }

   /**
   * Sandbox Settings
   * @return settingsSandbox
  **/
  @Schema(description = "Sandbox Settings")
  public Object getSettingsSandbox() {
    return settingsSandbox;
  }

  public void setSettingsSandbox(Object settingsSandbox) {
    this.settingsSandbox = settingsSandbox;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Integration integration = (Integration) o;
    return Objects.equals(this.id, integration.id) &&
        Objects.equals(this.tenantId, integration.tenantId) &&
        Objects.equals(this.categoryId, integration.categoryId) &&
        Objects.equals(this.name, integration.name) &&
        Objects.equals(this.slug, integration.slug) &&
        Objects.equals(this.logo, integration.logo) &&
        Objects.equals(this.status, integration.status) &&
        Objects.equals(this.credentialsProduction, integration.credentialsProduction) &&
        Objects.equals(this.credentialsSandbox, integration.credentialsSandbox) &&
        Objects.equals(this.envProduction, integration.envProduction) &&
        Objects.equals(this.envSandbox, integration.envSandbox) &&
        Objects.equals(this.settingsProduction, integration.settingsProduction) &&
        Objects.equals(this.settingsSandbox, integration.settingsSandbox);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, tenantId, categoryId, name, slug, logo, status, credentialsProduction, credentialsSandbox, envProduction, envSandbox, settingsProduction, settingsSandbox);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Integration {\n");
    
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    tenantId: ").append(toIndentedString(tenantId)).append("\n");
    sb.append("    categoryId: ").append(toIndentedString(categoryId)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    slug: ").append(toIndentedString(slug)).append("\n");
    sb.append("    logo: ").append(toIndentedString(logo)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
    sb.append("    credentialsProduction: ").append(toIndentedString(credentialsProduction)).append("\n");
    sb.append("    credentialsSandbox: ").append(toIndentedString(credentialsSandbox)).append("\n");
    sb.append("    envProduction: ").append(toIndentedString(envProduction)).append("\n");
    sb.append("    envSandbox: ").append(toIndentedString(envSandbox)).append("\n");
    sb.append("    settingsProduction: ").append(toIndentedString(settingsProduction)).append("\n");
    sb.append("    settingsSandbox: ").append(toIndentedString(settingsSandbox)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
