# akeyless.Model.GetPKICertificate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AltNames** | **string** | The Subject Alternative Names to be included in the PKI certificate (in a comma-separated list) (if CSR is supplied this flag is ignored and any DNS.* names are taken from it) | [optional] 
**CertIssuerName** | **string** | The name of the PKI certificate issuer | 
**CommonName** | **string** | The common name to be included in the PKI certificate (if CSR is supplied this flag is ignored and the CSR subject CN is taken) | [optional] 
**CsrDataBase64** | **string** | Certificate Signing Request contents encoded in base64 to generate the certificate with | [optional] 
**ExtendedKeyUsage** | **string** | A comma-separated list of extended key usage requests which will be used for certificate issuance. Supported values: &#39;clientauth&#39;, &#39;serverauth&#39;. If critical is present the extension will be marked as critical | [optional] 
**ExtraExtensions** | **string** | A json string that defines the requested extra extensions for the certificate | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeyDataBase64** | **string** | PKI key file contents. If this option is used, the certificate will be printed to stdout | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Ttl** | **string** | Updated certificate lifetime in seconds (must be less than the Certificate Issuer default TTL) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UriSans** | **string** | The URI Subject Alternative Names to be included in the PKI certificate (in a comma-separated list) (if CSR is supplied this flag is ignored and any URI.* names are taken from it) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

