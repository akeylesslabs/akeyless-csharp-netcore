# akeyless.Model.GenerateCA
GenerateCA is a command that creates a new PKI CA and Intermediate issuers

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alg** | **string** |  | [optional] 
**AllowedDomains** | **string** | A list of the allowed domains that clients can request to be included in the certificate (in a comma-delimited list) | 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**ExtendedKeyUsage** | **string** | A comma sepereted list of extended key usage for the intermediate (serverauth / clientauth / codesigning) | [optional] [default to "serverauth,clientauth"]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeyType** | **string** |  | [optional] 
**MaxPathLen** | **long** | The maximum number of intermediate certificates that can appear in a certification path | [optional] [default to 1]
**PkiChainName** | **string** | PKI chain name | 
**ProtectionKeyName** | **string** | The name of a key that used to encrypt the secrets values (if empty, the account default protectionKey key will be used) | [optional] 
**SplitLevel** | **long** | The number of fragments that the item will be split into | [optional] [default to 3]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Ttl** | **string** | The maximum requested Time To Live for issued certificate by default in seconds, supported formats are s,m,h,d | 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

