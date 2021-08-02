# akeyless.Model.GatewayCreateProducerGke
gatewayCreateProducerGke is a command that creates gke producer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GkeAccountKey** | **string** | GKE Service Account key file path | [optional] 
**GkeClusterCert** | **string** | GKE cluster CA certificate | 
**GkeClusterEndpoint** | **string** | GKE cluster URL endpoint | 
**GkeClusterName** | **string** | GKE cluster name | 
**GkeServiceAccountEmail** | **string** | GKE service account email | 
**Name** | **string** | Producer name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**SecureAccessAllowPortForwading** | **bool** |  | [optional] 
**SecureAccessBastionIssuer** | **string** |  | [optional] 
**SecureAccessClusterEndpoint** | **string** |  | [optional] 
**SecureAccessEnable** | **string** |  | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

