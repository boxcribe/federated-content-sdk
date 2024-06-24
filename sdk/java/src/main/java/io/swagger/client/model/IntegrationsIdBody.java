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
import io.swagger.client.model.IntegrationsCredentialsProduction;
import io.swagger.client.model.IntegrationsSettingsProduction;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * IntegrationsIdBody
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class IntegrationsIdBody {
  @SerializedName("tenant_id")
  private String tenantId = null;

  @SerializedName("category_id")
  private String categoryId = null;

  @SerializedName("name")
  private String name = null;

  @SerializedName("type")
  private String type = null;

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
  private StatusEnum status = null;

  @SerializedName("credentials_production")
  private IntegrationsCredentialsProduction credentialsProduction = null;

  @SerializedName("credentials_sandbox")
  private IntegrationsCredentialsProduction credentialsSandbox = null;

  @SerializedName("env_production")
  private String envProduction = null;

  @SerializedName("env_sandbox")
  private String envSandbox = null;

  @SerializedName("settings_production")
  private IntegrationsSettingsProduction settingsProduction = null;

  @SerializedName("settings_sandbox")
  private IntegrationsSettingsProduction settingsSandbox = null;

  public IntegrationsIdBody tenantId(String tenantId) {
    this.tenantId = tenantId;
    return this;
  }

   /**
   * Get tenantId
   * @return tenantId
  **/
  @Schema(description = "")
  public String getTenantId() {
    return tenantId;
  }

  public void setTenantId(String tenantId) {
    this.tenantId = tenantId;
  }

  public IntegrationsIdBody categoryId(String categoryId) {
    this.categoryId = categoryId;
    return this;
  }

   /**
   * Get categoryId
   * @return categoryId
  **/
  @Schema(description = "")
  public String getCategoryId() {
    return categoryId;
  }

  public void setCategoryId(String categoryId) {
    this.categoryId = categoryId;
  }

  public IntegrationsIdBody name(String name) {
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

  public IntegrationsIdBody type(String type) {
    this.type = type;
    return this;
  }

   /**
   * Get type
   * @return type
  **/
  @Schema(description = "")
  public String getType() {
    return type;
  }

  public void setType(String type) {
    this.type = type;
  }

  public IntegrationsIdBody slug(String slug) {
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

  public IntegrationsIdBody logo(String logo) {
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

  public IntegrationsIdBody status(StatusEnum status) {
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

  public IntegrationsIdBody credentialsProduction(IntegrationsCredentialsProduction credentialsProduction) {
    this.credentialsProduction = credentialsProduction;
    return this;
  }

   /**
   * Get credentialsProduction
   * @return credentialsProduction
  **/
  @Schema(description = "")
  public IntegrationsCredentialsProduction getCredentialsProduction() {
    return credentialsProduction;
  }

  public void setCredentialsProduction(IntegrationsCredentialsProduction credentialsProduction) {
    this.credentialsProduction = credentialsProduction;
  }

  public IntegrationsIdBody credentialsSandbox(IntegrationsCredentialsProduction credentialsSandbox) {
    this.credentialsSandbox = credentialsSandbox;
    return this;
  }

   /**
   * Get credentialsSandbox
   * @return credentialsSandbox
  **/
  @Schema(description = "")
  public IntegrationsCredentialsProduction getCredentialsSandbox() {
    return credentialsSandbox;
  }

  public void setCredentialsSandbox(IntegrationsCredentialsProduction credentialsSandbox) {
    this.credentialsSandbox = credentialsSandbox;
  }

  public IntegrationsIdBody envProduction(String envProduction) {
    this.envProduction = envProduction;
    return this;
  }

   /**
   * Get envProduction
   * @return envProduction
  **/
  @Schema(description = "")
  public String getEnvProduction() {
    return envProduction;
  }

  public void setEnvProduction(String envProduction) {
    this.envProduction = envProduction;
  }

  public IntegrationsIdBody envSandbox(String envSandbox) {
    this.envSandbox = envSandbox;
    return this;
  }

   /**
   * Get envSandbox
   * @return envSandbox
  **/
  @Schema(description = "")
  public String getEnvSandbox() {
    return envSandbox;
  }

  public void setEnvSandbox(String envSandbox) {
    this.envSandbox = envSandbox;
  }

  public IntegrationsIdBody settingsProduction(IntegrationsSettingsProduction settingsProduction) {
    this.settingsProduction = settingsProduction;
    return this;
  }

   /**
   * Get settingsProduction
   * @return settingsProduction
  **/
  @Schema(description = "")
  public IntegrationsSettingsProduction getSettingsProduction() {
    return settingsProduction;
  }

  public void setSettingsProduction(IntegrationsSettingsProduction settingsProduction) {
    this.settingsProduction = settingsProduction;
  }

  public IntegrationsIdBody settingsSandbox(IntegrationsSettingsProduction settingsSandbox) {
    this.settingsSandbox = settingsSandbox;
    return this;
  }

   /**
   * Get settingsSandbox
   * @return settingsSandbox
  **/
  @Schema(description = "")
  public IntegrationsSettingsProduction getSettingsSandbox() {
    return settingsSandbox;
  }

  public void setSettingsSandbox(IntegrationsSettingsProduction settingsSandbox) {
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
    IntegrationsIdBody integrationsIdBody = (IntegrationsIdBody) o;
    return Objects.equals(this.tenantId, integrationsIdBody.tenantId) &&
        Objects.equals(this.categoryId, integrationsIdBody.categoryId) &&
        Objects.equals(this.name, integrationsIdBody.name) &&
        Objects.equals(this.type, integrationsIdBody.type) &&
        Objects.equals(this.slug, integrationsIdBody.slug) &&
        Objects.equals(this.logo, integrationsIdBody.logo) &&
        Objects.equals(this.status, integrationsIdBody.status) &&
        Objects.equals(this.credentialsProduction, integrationsIdBody.credentialsProduction) &&
        Objects.equals(this.credentialsSandbox, integrationsIdBody.credentialsSandbox) &&
        Objects.equals(this.envProduction, integrationsIdBody.envProduction) &&
        Objects.equals(this.envSandbox, integrationsIdBody.envSandbox) &&
        Objects.equals(this.settingsProduction, integrationsIdBody.settingsProduction) &&
        Objects.equals(this.settingsSandbox, integrationsIdBody.settingsSandbox);
  }

  @Override
  public int hashCode() {
    return Objects.hash(tenantId, categoryId, name, type, slug, logo, status, credentialsProduction, credentialsSandbox, envProduction, envSandbox, settingsProduction, settingsSandbox);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class IntegrationsIdBody {\n");
    
    sb.append("    tenantId: ").append(toIndentedString(tenantId)).append("\n");
    sb.append("    categoryId: ").append(toIndentedString(categoryId)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
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