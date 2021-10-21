# akeyless.Model.K8SAuth
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmTokenExpiration** | **long** | AuthMethodTokenExpiration is time in seconds of expiration of the Akeyless Kube Auth Method token | [optional] 
**AuthMethodAccessId** | **string** | AuthMethodAccessId of the Kubernetes auth method | [optional] 
**AuthMethodPrvKeyPem** | **string** | AuthMethodSigningKey is the private key (in base64 of the PEM format) associated with the public key defined in the Kubernetes auth method, that used to sign the internal token for the Akeyless Kubernetes Auth Method | [optional] 
**DisableIssValidation** | **bool** | DisableISSValidation is optional parameter to disable ISS validation | [optional] 
**Id** | **string** |  | [optional] 
**K8sCaCert** | **string** | K8SCACert is the CA Cert to use to call into the kubernetes API | [optional] 
**K8sHost** | **string** | K8SHost is the url string for the kubernetes API | [optional] 
**K8sIssuer** | **string** | K8SIssuer is the claim that specifies who issued the Kubernetes token | [optional] 
**K8sPubKeysPem** | **List&lt;string&gt;** | K8SPublicKeysPEM is the list of public key in PEM format | [optional] 
**K8sTokenReviewerJwt** | **string** | K8STokenReviewerJW\&quot;K8S Auth config %v successfully created\\n\&quot;, clictx.Color().Bold(c.K8SAuthConfigName)T is the bearer to use during the TokenReview API call | [optional] 
**Name** | **string** |  | [optional] 
**ProtectionKey** | **string** |  | [optional] 
**UseLocalCaJwt** | **bool** | UseLocalCAJwt is an optional parameter to set defaulting to using the local CA cert and service account jwt when running in a Kubernetes pod | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

