# akeyless.Model.GatewayCreateK8SAuthConfig
gatewayCreateK8SAuth is a command that creates k8s auth config

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessId** | **string** | The access ID of the Kubernetes auth method | 
**ConfigEncryptionKeyName** | **string** | Config encryption key | [optional] 
**K8sCaCert** | **string** | The CA Cert (in PEM format) to use to call into the kubernetes API server | [optional] 
**K8sHost** | **string** | The URL of the kubernetes API server | 
**K8sIssuer** | **string** | The Kubernetes JWT issuer name. If not set, kubernetes/serviceaccount will use as an issuer. | [optional] 
**Name** | **string** | K8S Auth config name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**SigningKey** | **string** | The private key (in base64 encoded of the PEM format) associated with the public key defined in the Kubernetes auth | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**TokenExp** | **long** | Time in seconds of expiration of the Akeyless Kube Auth Method token | [optional] 
**TokenReviewerJwt** | **string** | A Kubernetes service account JWT used to access the TokenReview API to validate other JWTs. If not set, the JWT submitted in the authentication process will be used to access the Kubernetes TokenReview API. | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

