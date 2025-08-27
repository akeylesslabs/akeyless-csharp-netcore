# akeyless.Model.GenerateCsr

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alg** | **string** |  | [optional] 
**AltNames** | **string** | A comma-separated list of dns alternative names | [optional] 
**CertificateType** | **string** | The certificate type to be included in the CSR certificate (ssl-client/ssl-server/certificate-signing) | [optional] 
**City** | **string** | The city to be included in the CSR certificate | [optional] 
**CommonName** | **string** | The common name to be included in the CSR certificate | 
**Country** | **string** | The country to be included in the CSR certificate | [optional] 
**Critical** | **bool** | Add critical to the key usage extension (will be false if not added) | [optional] 
**Dep** | **string** | The department to be included in the CSR certificate | [optional] 
**EmailAddresses** | **string** | A comma-separated list of email addresses alternative names | [optional] 
**ExportPrivateKey** | **bool** | The flag to indicate if the private key should be exported | [optional] [default to false]
**GenerateKey** | **bool** | Generate a new classic key for the csr | [optional] 
**HashAlgorithm** | **string** | Specifies the hash algorithm used for the encryption key&#39;s operations, available options: SHA256, SHA384, SHA512 | [optional] [default to "SHA256"]
**IpAddresses** | **string** | A comma-separated list of ip addresses alternative names | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeyType** | **string** | The type of the key to generate (classic-key/dfc) | [default to "classic-key"]
**Name** | **string** | The key name | 
**Org** | **string** | The organization to be included in the CSR certificate | [optional] 
**SplitLevel** | **long** | The number of fragments that the item will be split into (not includes customer fragment) | [optional] [default to 3]
**State** | **string** | The state to be included in the CSR certificate | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UriSans** | **string** | A comma-separated list of uri alternative names | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

