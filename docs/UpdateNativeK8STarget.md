# akeyless.Model.UpdateNativeK8STarget
updateNativeK8STarget is a command that updates an existing target. [Deprecated: Use target-update-k8s command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Comment** | **string** | Deprecated - use description | [optional] 
**Description** | **string** | Description of the object | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**K8sAuthType** | **string** | K8S auth type [token/certificate] | [optional] [default to "token"]
**K8sClientCertificate** | **string** | Content of the k8 client certificate (PEM format) in a Base64 format | [optional] 
**K8sClientKey** | **string** | Content of the k8 client private key (PEM format) in a Base64 format | [optional] 
**K8sClusterCaCert** | **string** | K8S cluster CA certificate | [optional] 
**K8sClusterEndpoint** | **string** | K8S cluster URL endpoint | [optional] 
**K8sClusterName** | **string** | K8S cluster name | [optional] 
**K8sClusterToken** | **string** | K8S cluster Bearer token | [optional] 
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Target name | 
**NewName** | **string** | New target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UpdateVersion** | **bool** | Deprecated | [optional] 
**UseGwServiceAccount** | **bool** | Use the GW&#39;s service account | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

