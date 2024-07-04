# akeyless.Model.AuthMethodCreateK8s
authMethodCreateK8s is a command that creates a new auth method that will be able to authenticate using K8S.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessExpires** | **long** | Access expiration date in Unix timestamp (select 0 for access without expiry date) | [optional] [default to 0]
**Audience** | **string** | The audience in the Kubernetes JWT that the access is restricted to | [optional] 
**AuditLogsClaims** | **List&lt;string&gt;** | Subclaims to include in audit logs, e.g \&quot;- -audit-logs-claims email - -audit-logs-claims username\&quot; | [optional] 
**BoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the IPs that the access is restricted to | [optional] 
**BoundNamespaces** | **List&lt;string&gt;** | A list of namespaces that the access is restricted to | [optional] 
**BoundPodNames** | **List&lt;string&gt;** | A list of pod names that the access is restricted to | [optional] 
**BoundSaNames** | **List&lt;string&gt;** | A list of service account names that the access is restricted to | [optional] 
**Description** | **string** | Auth Method description | [optional] 
**ForceSubClaims** | **bool** | if true: enforce role-association must include sub claims | [optional] 
**GenKey** | **string** | Automatically generate key-pair for K8S configuration. If set to false, a public key needs to be provided [true/false] | [optional] [default to "true"]
**GwBoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the GW IPs that the access is restricted to | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**JwtTtl** | **long** | Jwt TTL | [optional] [default to 0]
**Name** | **string** | Auth Method name | 
**ProductType** | **List&lt;string&gt;** | Choose the relevant product type for the auth method [sm, sra, pm, dp, ca] | [optional] 
**PublicKey** | **string** | Base64-encoded or PEM formatted public key data for K8S authentication method is required [RSA2048] | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

