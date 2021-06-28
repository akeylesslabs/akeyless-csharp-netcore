# akeyless.Model.GatewayCreateProducerNativeK8S
gatewayCreateProducerNativeK8S is a command that creates k8s producer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**K8sClusterCaCert** | **string** | K8S cluster CA certificate | 
**K8sClusterEndpoint** | **string** | K8S cluster URL endpoint | 
**K8sClusterToken** | **string** | K8S cluster Bearer token | 
**K8sNamespace** | **string** | K8S namespace | [optional] 
**K8sServiceAccount** | **string** | K8S service account | 
**Name** | **string** | Producer name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

