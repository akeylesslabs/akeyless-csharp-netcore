# akeyless.Model.CreateClassicKey
CreateClassicKey is a command that creates classic key

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alg** | **string** | Classic Key type; options: [AES128GCM, AES256GCM, AES128SIV, AES256SIV, RSA1024, RSA2048, RSA3072, RSA4096, EC256, EC384, GPG] | 
**AutoRotate** | **string** | Whether to automatically rotate every rotation_interval days, or disable existing automatic rotation [true/false] | [optional] 
**CertFileData** | **string** | Certificate in a PEM format. | [optional] 
**CertificateCommonName** | **string** | Common name for the generated certificate. Relevant only for generate-self-signed-certificate. | [optional] 
**CertificateCountry** | **string** | Country name for the generated certificate. Relevant only for generate-self-signed-certificate. | [optional] 
**CertificateDigestAlgo** | **string** | Digest algorithm to be used for the certificate key signing. Currently, we support only \&quot;sha256\&quot; so we hide this option for CLI. | [optional] 
**CertificateFormat** | **string** |  | [optional] 
**CertificateLocality** | **string** | Locality for the generated certificate. Relevant only for generate-self-signed-certificate. | [optional] 
**CertificateOrganization** | **string** | Organization name for the generated certificate. Relevant only for generate-self-signed-certificate. | [optional] 
**CertificateProvince** | **string** | Province name for the generated certificate. Relevant only for generate-self-signed-certificate. | [optional] 
**CertificateTtl** | **long** | TTL in days for the generated certificate. Required only for generate-self-signed-certificate. | [optional] 
**ConfFileData** | **string** | The csr config data in base64 encoding | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**ExpirationEventIn** | **List&lt;string&gt;** | How many days before the expiration of the certificate would you like to be notified. | [optional] 
**GenerateSelfSignedCertificate** | **bool** | Whether to generate a self signed certificate with the key. If set, - -certificate-ttl must be provided. | [optional] 
**GpgAlg** | **string** | gpg alg: Relevant only if GPG key type selected; options: [RSA1024, RSA2048, RSA3072, RSA4096, Ed25519] | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeyData** | **string** | Base64-encoded classic key value | [optional] 
**Metadata** | **string** | Deprecated - use description | [optional] 
**Name** | **string** | ClassicKey name | 
**ProtectionKeyName** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**RotationEventIn** | **List&lt;string&gt;** | How many days before the rotation of the item would you like to be notified | [optional] 
**RotationInterval** | **string** | The number of days to wait between every automatic rotation (1-365) | [optional] 
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

