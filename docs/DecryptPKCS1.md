# akeyless.Model.DecryptPKCS1

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ciphertext** | **string** | Ciphertext to be decrypted in base64 encoded format | 
**DisplayId** | **string** | The display id of the key to use in the decryption process | [optional] 
**ItemId** | **long** | The item id of the key to use in the decryption process | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeyName** | **string** | The name of the key to use in the decryption process | 
**OutputFormat** | **string** | If specified, the output will be formatted accordingly. options: [base64] | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**_Version** | **int** | key version (relevant only for classic key) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

