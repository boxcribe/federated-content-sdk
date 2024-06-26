/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type ApiKey struct {
	Id string `json:"id,omitempty"`
	TenantId string `json:"tenant_id,omitempty"`
	Name string `json:"name,omitempty"`
	Status string `json:"status,omitempty"`
	PrivateKey string `json:"private_key,omitempty"`
	PublicKey string `json:"public_key,omitempty"`
	// Usage log
	Usage *interface{} `json:"usage,omitempty"`
	// Usage limit
	UsageLimit int32 `json:"usage_limit,omitempty"`
}
