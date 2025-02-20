# akeyless.Model.VerifyPKCS1

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayId** | **string** | The display id of the key to use in the verification process | [optional] 
**HashFunction** | **string** | HashFunction defines the hash function (e.g. sha-256) | [optional] 
**InputFormat** | **string** | Select default assumed format for the plaintext message. Currently supported options: [base64] | [optional] 
**ItemId** | **long** | The item id of the key to use in the verification process | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeyName** | **string** | The name of the RSA key to use in the verification process | 
**Message** | **string** | The message to be verified | 
**Prehashed** | **bool** | Markes that the message is already hashed | [optional] 
**Signature** | **string** | The message&#39;s signature | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**VarVersion** | **int** | The version of the key to use for verification | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

