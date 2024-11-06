# akeyless.Model.SignEcDsa
signEcDsa Calculates the signature of a given message using ECDSA and a sha hash algorithm matching the key size

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accessibility** | **string** | for personal password manager | [optional] [default to "regular"]
**DisplayId** | **string** | The display id of the EC key to use for the signing process | [optional] 
**ItemId** | **long** | The item id of the EC key to use for the signing process | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeyName** | **string** | The name of the EC key to use for the signing process | [optional] 
**Message** | **string** | The input message to sign in a base64 format | 
**Prehashed** | **bool** | Markes that the message is already hashed | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**_Version** | **int** | The version of the key to use for signing | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

