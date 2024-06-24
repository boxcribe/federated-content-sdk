/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type ApikeysIdBody struct {
	TenantId string `json:"tenant_id,omitempty"`
	Name string `json:"name,omitempty"`
	Status string `json:"status,omitempty"`
	UsageLimit float64 `json:"usage_limit,omitempty"`
	EnvName string `json:"env_name,omitempty"`
}