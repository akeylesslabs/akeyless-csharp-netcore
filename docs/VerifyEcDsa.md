# akeyless.Model.VerifyEcDsa
verifyEcDsa is a command that verifies an ECDSA signature using a sha hash algorithm matching the key size

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayId** | **string** | The display id of the EC key to use for the verification process | [optional] 
**ItemId** | **long** | The item id of the EC key to use for the verification process | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeyName** | **string** | The name of the EC key to use for the verification process | [optional] 
**Message** | **string** | The message to be verified in a base64 format | 
**Signature** | **string** | The message&#39;s signature | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

