# akeyless.Model.CreateAuthMethodK8S
createAuthMethodK8S is a command that creates a new auth method that will be able to authenticate using K8S.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessExpires** | **long** | Access expiration date in Unix timestamp (select 0 for access without expiry date) | [optional] [default to 0]
**Audience** | **string** | The audience in the Kubernetes JWT that the access is restricted to | [optional] 
**BoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the IPs that the access is restricted to | [optional] 
**BoundNamespaces** | **List&lt;string&gt;** | A list of namespaces that the access is restricted to | [optional] 
**BoundPodNames** | **List&lt;string&gt;** | A list of pod names that the access is restricted to | [optional] 
**BoundSaNames** | **List&lt;string&gt;** | A list of service account names that the access is restricted to | [optional] 
**ForceSubClaims** | **bool** | if true: enforce role-association must include sub claims | [optional] 
**GenKey** | **string** | Automatically generate key-pair for K8S configuration. If set to false, a public key needs to be provided | [optional] [default to "true"]
**GwBoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the GW IPs that the access is restricted to | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] 
**JwtTtl** | **long** | Jwt TTL | [optional] 
**Name** | **string** | Auth Method name | 
**PublicKey** | **string** | Base64-encoded or PEM formatted public key data for K8S authentication method is required [RSA2048] | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

