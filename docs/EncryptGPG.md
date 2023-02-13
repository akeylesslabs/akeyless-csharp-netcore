# akeyless.Model.EncryptGPG

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayId** | **string** | The display id of the key to use in the encryption process | [optional] 
**InputFormat** | **string** | If specified, the plaintext input is assumed to be formatted accordingly. Current supported options: [base64] | [optional] 
**ItemId** | **long** | The item id of the key to use in the encryption process | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeyName** | **string** | The name of the key to use in the encryption process | 
**Plaintext** | **string** | Data to be encrypted | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

