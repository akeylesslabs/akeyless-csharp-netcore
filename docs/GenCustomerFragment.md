# akeyless.Model.GenCustomerFragment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Description of the object | [optional] 
**HsmKeyLabel** | **string** | The label of the hsm key to use for customer fragment operations (relevant for hsm wrap customer fragments) | [optional] 
**HsmProvider** | **string** | The HSM provider to use for hsm wrap customer fragments | [optional] [default to "pkcs11"]
**HsmWrapAlg** | **string** | The HSM wrap algorithm to use for hsm_wrap_encrypt  default for hsm_wrap_encrypt: rsa-oaep-sha256 | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Metadata** | **string** | Deprecated - use description | [optional] 
**Name** | **string** | Customer fragment name | [optional] 
**Type** | **string** | Customer fragment type [standard/hsm_wrap_hmac/hsm_wrap_encrypt/hsm_secured] | [optional] [default to "standard"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

