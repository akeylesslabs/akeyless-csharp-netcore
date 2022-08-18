# akeyless.Model.KubernetesAccessRules

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alg** | **string** |  | [optional] 
**Audience** | **string** | Audience is an optional Kubernetes jwt claim to verify | [optional] 
**BoundNamespaces** | **List&lt;string&gt;** | A list of namespaces that the authentication is restricted to. | [optional] 
**BoundPodNames** | **List&lt;string&gt;** | A list of pods names that the authentication is restricted to. | [optional] 
**BoundServiceAccountNames** | **List&lt;string&gt;** | A list of service account names that the authentication is restricted to. | [optional] 
**GenKeyPair** | **string** | Generate public/private key (the private key is required for the K8S Auth Config in the Akeyless Gateway) | [optional] 
**PubKey** | **string** | The public key value of the Kubernetes auth method configuration in the Akeyless Gateway. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

