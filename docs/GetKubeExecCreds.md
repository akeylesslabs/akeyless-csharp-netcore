# akeyless.Model.GetKubeExecCreds
getKubeExecCreds is a command that gets credentials for authentication with Kubernetes cluster based on a PKI cert issuer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AltNames** | **string** | The Subject Alternative Names to be included in the PKI certificate (in a comma-delimited list) | [optional] 
**CertIssuerName** | **string** | The name of the PKI certificate issuer | 
**CommonName** | **string** | The common name to be included in the PKI certificate | [optional] 
**ExtendedKeyUsage** | **string** | A comma-separated list of extended key usage requests which will be used for certificate issuance. Supported values: &#39;clientauth&#39;, &#39;serverauth&#39;. | [optional] 
**KeyDataBase64** | **string** | PKI key file contents. If this option is used, the certificate will be printed to stdout | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Ttl** | **long** | Updated certificate lifetime in seconds (must be less than the Certificate Issuer default TTL) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UriSans** | **string** | The URI Subject Alternative Names to be included in the PKI certificate (in a comma-delimited list) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

