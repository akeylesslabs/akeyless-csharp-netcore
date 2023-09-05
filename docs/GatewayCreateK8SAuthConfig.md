# akeyless.Model.GatewayCreateK8SAuthConfig
gatewayCreateK8SAuth is a command that creates k8s auth config

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessId** | **string** | The access ID of the Kubernetes auth method | 
**ClusterApiType** | **string** | Cluster access type. options: [native_k8s, rancher] | [optional] [default to "native_k8s"]
**ConfigEncryptionKeyName** | **string** | Config encryption key | [optional] 
**DisableIssuerValidation** | **string** | Disable issuer validation [true/false] | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**K8sAuthType** | **string** | K8S auth type [token/certificate]. (relevant for \&quot;native_k8s\&quot; only) | [optional] [default to "token"]
**K8sCaCert** | **string** | The CA Certificate (base64 encoded) to use to call into the kubernetes API server | [optional] 
**K8sClientCertificate** | **string** | Content of the k8 client certificate (PEM format) in a Base64 format (relevant for \&quot;native_k8s\&quot; only) | [optional] 
**K8sClientKey** | **string** | Content of the k8 client private key (PEM format) in a Base64 format (relevant for \&quot;native_k8s\&quot; only) | [optional] 
**K8sHost** | **string** | The URL of the kubernetes API server | 
**K8sIssuer** | **string** | The Kubernetes JWT issuer name. K8SIssuer is the claim that specifies who issued the Kubernetes token | [optional] [default to "kubernetes/serviceaccount"]
**Name** | **string** | K8S Auth config name | 
**RancherApiKey** | **string** | The api key used to access the TokenReview API to validate other JWTs (relevant for \&quot;rancher\&quot; only) | [optional] 
**RancherClusterId** | **string** | The cluster id as define in rancher (relevant for \&quot;rancher\&quot; only) | [optional] 
**SigningKey** | **string** | The private key (base64 encoded) associated with the public key defined in the Kubernetes auth | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**TokenExp** | **long** | Time in seconds of expiration of the Akeyless Kube Auth Method token | [optional] [default to 300]
**TokenReviewerJwt** | **string** | A Kubernetes service account JWT used to access the TokenReview API to validate other JWTs (relevant for \&quot;native_k8s\&quot; only). If not set, the JWT submitted in the authentication process will be used to access the Kubernetes TokenReview API. | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UseGwServiceAccount** | **bool** | Use the GW&#39;s service account | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

