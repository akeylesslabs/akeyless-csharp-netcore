# akeyless.Model.GenerateCsr

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alg** | **string** |  | [optional] 
**AltNames** | **string** | The DNS Alternative Names to be included in the CSR certificate (in a comma-separated list) | [optional] 
**CertificateType** | **string** | The certificateType to be included in the CSR certificate (ssl-client/ssl-server/certificate-signing) | [optional] 
**City** | **string** | The city to be included in the CSR certificate | [optional] 
**CommonName** | **string** | The commonName to be included in the CSR certificate | 
**Country** | **string** | The country to be included in the CSR certificate | [optional] 
**Critical** | **bool** | Add critical to the key usage extension (will be false if not added) | [optional] 
**Dep** | **string** | The department to be included in the CSR certificate | [optional] 
**Description** | **string** | Description of the object | [optional] 
**EmailAddresses** | **string** | The email addresses Alternative Names to be included in the CSR certificate (in a comma-separated list) | [optional] 
**GenerateKey** | **bool** | Generate a new csr key | [optional] 
**IpAddresses** | **string** | The ip addresses Alternative Names to be included in the CSR certificate (in a comma-separated list) | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Metadata** | **string** | Deprecated - use description | [optional] 
**Name** | **string** | Key name in akeyless | 
**Org** | **string** | The organization to be included in the CSR certificate | [optional] 
**State** | **string** | The state to be included in the CSR certificate | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UriSans** | **string** | The URI Subject Alternative Names to be included in the CSR certificate (in a comma-separated list) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

