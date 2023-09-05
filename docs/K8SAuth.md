# akeyless.Model.K8SAuth

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmTokenExpiration** | **long** | AuthMethodTokenExpiration is time in seconds of expiration of the Akeyless Kube Auth Method token | [optional] 
**AuthMethodAccessId** | **string** | AuthMethodAccessId of the Kubernetes auth method | [optional] 
**AuthMethodPrvKeyPem** | **string** | AuthMethodSigningKey is the private key (in base64 of the PEM format) associated with the public key defined in the Kubernetes auth method, that used to sign the internal token for the Akeyless Kubernetes Auth Method | [optional] 
**ClusterApiType** | **string** | ClusterApiType defines types of API access to cluster | [optional] 
**DisableIssValidation** | **bool** | DisableISSValidation is optional parameter to disable ISS validation | [optional] 
**Id** | **string** |  | [optional] 
**K8sAuthType** | **string** |  | [optional] 
**K8sCaCert** | **string** | K8SCACert is the CA Cert to use to call into the kubernetes API | [optional] 
**K8sClientCertData** | **string** | K8sClientCertData is the client certificate for k8s client certificate authentication | [optional] 
**K8sClientKeyData** | **string** | K8sClientKeyData is the client key for k8s client certificate authentication | [optional] 
**K8sHost** | **string** | K8SHost is the url string for the kubernetes API | [optional] 
**K8sIssuer** | **string** | K8SIssuer is the claim that specifies who issued the Kubernetes token | [optional] 
**K8sPubKeysPem** | **List&lt;string&gt;** | K8SPublicKeysPEM is the list of public key in PEM format | [optional] 
**K8sTokenReviewerJwt** | **string** | K8STokenReviewerJWT is the bearer for clusterApiTypeK8s, used during TokenReview API call | [optional] 
**Name** | **string** |  | [optional] 
**ProtectionKey** | **string** |  | [optional] 
**RancherApiKey** | **string** | RancherApiKey the bear token for clusterApiTypeRancher | [optional] 
**RancherClusterId** | **string** | RancherClusterId cluster id as define in rancher (in case of clusterApiTypeRancher) | [optional] 
**UseLocalCaJwt** | **bool** | UseLocalCAJwt is an optional parameter to set defaulting to using the local service account when running in a Kubernetes pod | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

