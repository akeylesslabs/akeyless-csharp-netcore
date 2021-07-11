# akeyless.Model.SignPKICertWithClassicKey
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CommonName** | **string** | The common name to be included in the PKI certificate | [optional] 
**Country** | **string** | A comma-separated list of the country that will be set in the issued certificate | [optional] 
**DisplayId** | **string** | The name of the key to use in the sign PKI Cert process | 
**DnsNames** | **string** | DNS Names to be included in the PKI certificate (in a comma-delimited list) | [optional] 
**KeyUsage** | **string** | key-usage | [optional] [default to "DigitalSignature,KeyAgreement,KeyEncipherment"]
**Locality** | **string** | A comma-separated list of the locality that will be set in the issued certificate | [optional] 
**OrganizationalUnits** | **string** | A comma-separated list of organizational units (OU) that will be set in the issued certificate | [optional] 
**Organizations** | **string** | A comma-separated list of organizations (O) that will be set in the issued certificate | [optional] 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**PostalCode** | **string** | A comma-separated list of the postal code that will be set in the issued certificate | [optional] 
**Province** | **string** | A comma-separated list of the province that will be set in the issued certificate | [optional] 
**PublicKeyPemData** | **string** | PublicKey using for signing in a PEM format. | [optional] 
**SigningMethod** | **string** | SigningMethod | 
**StreetAddress** | **string** | A comma-separated list of the street address that will be set in the issued certificate | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Ttl** | **long** | The requested Time To Live for the certificate, use second units | 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UriSans** | **string** | The URI Subject Alternative Names to be included in the PKI certificate (in a comma-delimited list) | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 
**Version** | **int** | classic key version | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

