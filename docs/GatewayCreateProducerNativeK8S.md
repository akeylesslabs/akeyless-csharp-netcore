# akeyless.Model.GatewayCreateProducerNativeK8S
gatewayCreateProducerNativeK8S is a command that creates k8s producer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**K8sClusterCaCert** | **string** | K8S cluster CA certificate | [optional] 
**K8sClusterEndpoint** | **string** | K8S cluster URL endpoint | [optional] 
**K8sClusterToken** | **string** | K8S cluster Bearer token | [optional] 
**K8sNamespace** | **string** | K8S namespace | [optional] 
**K8sServiceAccount** | **string** | K8S service account | [optional] 
**Name** | **string** | Producer name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**SecureAccessAllowPortForwading** | **bool** |  | [optional] 
**SecureAccessBastionIssuer** | **string** |  | [optional] 
**SecureAccessClusterEndpoint** | **string** |  | [optional] 
**SecureAccessDashboardUrl** | **string** |  | [optional] 
**SecureAccessEnable** | **string** |  | [optional] 
**SecureAccessWeb** | **bool** |  | [optional] 
**SecureAccessWebBrowsing** | **bool** |  | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

