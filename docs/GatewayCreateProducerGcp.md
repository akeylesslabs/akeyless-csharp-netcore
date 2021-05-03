# akeyless.Model.GatewayCreateProducerGcp
gatewayCreateProducerGcp is a command that creates a GCP producer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GatewayUrl** | **string** | Gateway url | [optional] [default to "http://localhost:8000"]
**GcpCredType** | **string** |  | 
**GcpKey** | **string** | Base64-encoded service account private key text | [optional] 
**GcpKeyAlgo** | **string** | Service account key algorithm, e.g. KEY_ALG_RSA_1024 | [optional] 
**GcpSaEmail** | **string** | GCP service account email | 
**GcpTokenScopes** | **string** | Access token scopes list, e.g. scope1,scope2 | [optional] 
**Name** | **string** | Producer name | 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

