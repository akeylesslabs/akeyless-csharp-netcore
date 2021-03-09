# akeyless.Model.GatewayCreateProducerGke
gatewayCreateProducerGke is a command that creates gke producer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GatewayUrl** | **string** | Gateway url | [optional] [default to "http://localhost:8000"]
**GkeClusterCert** | **string** | GKE cluster CA certificate | 
**GkeClusterEndpoint** | **string** | GKE cluster URL endpoint | 
**GkeClusterName** | **string** | GKE cluster name | 
**GkeServiceAccountEmail** | **string** | GKE service account email | 
**GkeServiceAccountKeyFilePath** | **string** | GKE Service Account key faile path | 
**Name** | **string** | Producer name | 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

