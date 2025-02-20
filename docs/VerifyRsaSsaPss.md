# akeyless.Model.VerifyRsaSsaPss
verifyRsaSsaPss is a command that Verifies an rsassa-pss signature

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayId** | **string** | The display id of the RSA key to use in the verification process | [optional] 
**HashFunction** | **string** | HashFunction defines the hash function (e.g. sha-256) | [optional] 
**ItemId** | **long** | The item id of the RSA key to use in the verification process | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeyName** | **string** | The name of the RSA key to use in the verification process | [optional] 
**Message** | **string** | The input message to verify in a base64 format | 
**Prehashed** | **bool** | Markes that the message is already hashed | [optional] 
**Signature** | **string** | The message&#39;s signature | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**VarVersion** | **int** | The version of the key to use for verification | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

