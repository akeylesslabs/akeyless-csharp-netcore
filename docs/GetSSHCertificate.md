# akeyless.Model.GetSSHCertificate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CertIssuerName** | **string** | The name of the SSH certificate issuer | 
**CertUsername** | **string** | The username to sign in the SSH certificate | [default to "-"]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**LegacySigningAlgName** | **bool** | Set this option to output legacy (&#39;ssh-rsa-cert-v01@openssh.com&#39;) signing algorithm name in the certificate. | [optional] [default to false]
**PublicKeyData** | **string** | SSH public key file contents. If this option is used, the certificate will be printed to stdout | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Ttl** | **long** | Updated certificate lifetime in seconds (must be less than the Certificate Issuer default TTL) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

