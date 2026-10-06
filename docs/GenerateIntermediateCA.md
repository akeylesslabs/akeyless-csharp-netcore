# akeyless.Model.GenerateIntermediateCA

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alg** | **string** |  | [optional] 
**AllowedDomains** | **string** | Allowed domains for future leaf issuance, not inherited into the SCEP subordinate CA certificate | [optional] 
**CommonName** | **string** | Optional Common Name for the intermediate CA certificate | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**DestinationPath** | **string** | Destination path for SCEP-issued leaf certificates. Not derived from the CA certificate item path. | [optional] 
**EnableScep** | **bool** | Enable the fixed SCEP Stage 1 profile | [optional] 
**ExtendedKeyUsage** | **string** | Extended key usage for future leaf issuance (serverauth / clientauth / codesigning) | [optional] [default to "serverauth,clientauth"]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**MaxPathLen** | **long** | The maximum path length of the generated intermediate CA certificate | [optional] [default to 0]
**Name** | **string** | Base path for derived intermediate CA resources | 
**ParentCaName** | **string** | Parent PKI certificate issuer name | [optional] 
**ScepPassword** | **string** | SCEP static challenge password. Request-only; never returned | [optional] 
**SplitLevel** | **long** | The number of fragments that the DFC key will be split into | [optional] [default to 3]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Ttl** | **string** | Maximum TTL for certificates issued by the new intermediate issuer, supported formats are s,m,h,d | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

