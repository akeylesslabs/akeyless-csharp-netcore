# akeyless.Model.GatewayCreateProducerGke
gatewayCreateProducerGke is a command that creates gke producer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GkeAccountKey** | **string** | GKE Service Account key file path | [optional] 
**GkeClusterCert** | **string** | GKE cluster CA certificate | [optional] 
**GkeClusterEndpoint** | **string** | GKE cluster URL endpoint | [optional] 
**GkeClusterName** | **string** | GKE cluster name | [optional] 
**GkeServiceAccountEmail** | **string** | GKE service account email | [optional] 
**Name** | **string** | Producer name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**SecureAccessAllowPortForwading** | **bool** |  | [optional] 
**SecureAccessBastionIssuer** | **string** |  | [optional] 
**SecureAccessClusterEndpoint** | **string** |  | [optional] 
**SecureAccessEnable** | **string** |  | [optional] 
**SecureAccessWeb** | **bool** |  | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

