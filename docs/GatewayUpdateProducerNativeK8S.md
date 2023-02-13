# akeyless.Model.GatewayUpdateProducerNativeK8S
gatewayUpdateProducerNativeK8S is a command that updates k8s producer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteProtection** | **string** | Protection from accidental deletion of this item [true/false] | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**K8sClusterCaCert** | **string** | K8S cluster CA certificate | [optional] 
**K8sClusterEndpoint** | **string** | K8S cluster URL endpoint | [optional] 
**K8sClusterToken** | **string** | K8S cluster Bearer token | [optional] 
**K8sNamespace** | **string** | K8S namespace | [optional] [default to "default"]
**K8sServiceAccount** | **string** | K8S service account | [optional] 
**Name** | **string** | Producer name | 
**NewName** | **string** | Producer name | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**SecureAccessAllowPortForwading** | **bool** | Enable Port forwarding while using CLI access | [optional] 
**SecureAccessBastionIssuer** | **string** | Path to the SSH Certificate Issuer for your Akeyless Bastion | [optional] 
**SecureAccessClusterEndpoint** | **string** | The K8s cluster endpoint URL | [optional] 
**SecureAccessDashboardUrl** | **string** | The K8s dashboard url | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessWeb** | **bool** | Enable Web Secure Remote Access | [optional] [default to false]
**SecureAccessWebBrowsing** | **bool** | Secure browser via Akeyless Web Access Bastion | [optional] [default to false]
**SecureAccessWebProxy** | **bool** | Web-Proxy via Akeyless Web Access Bastion | [optional] [default to false]
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

