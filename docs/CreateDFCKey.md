# akeyless.Model.CreateDFCKey

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alg** | **string** | DFCKey type; options: [AES128GCM, AES256GCM, AES128SIV, AES256SIV, AES128CBC, AES256CBC, RSA1024, RSA2048, RSA3072, RSA4096] | 
**CertificateCommonName** | **string** | Common name for the generated certificate. Relevant only for generate-self-signed-certificate. | [optional] 
**CertificateCountry** | **string** | Country name for the generated certificate. Relevant only for generate-self-signed-certificate. | [optional] 
**CertificateDigestAlgo** | **string** | Digest algorithm to be used for the certificate key signing. Currently, we support only \&quot;sha256\&quot; so we hide this option for CLI. | [optional] 
**CertificateLocality** | **string** | Locality for the generated certificate. Relevant only for generate-self-signed-certificate. | [optional] 
**CertificateOrganization** | **string** | Organization name for the generated certificate. Relevant only for generate-self-signed-certificate. | [optional] 
**CertificateProvince** | **string** | Province name for the generated certificate. Relevant only for generate-self-signed-certificate. | [optional] 
**CertificateTtl** | **long** | TTL in days for the generated certificate. Required only for generate-self-signed-certificate. | [optional] 
**ConfFileData** | **string** | The csr config data in base64 encoding | [optional] 
**CustomerFrgId** | **string** | The customer fragment ID that will be used to create the DFC key (if empty, the key will be created independently of a customer fragment) | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this item [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**GenerateSelfSignedCertificate** | **bool** | Whether to generate a self signed certificate with the key. If set, - -certificate-ttl must be provided. | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Metadata** | **string** | Deprecated - use description | [optional] 
**Name** | **string** | DFCKey name | 
**SplitLevel** | **long** | The number of fragments that the item will be split into (not includes customer fragment) | [optional] [default to 3]
**Tag** | **List&lt;string&gt;** | List of the tags attached to this DFC key | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

