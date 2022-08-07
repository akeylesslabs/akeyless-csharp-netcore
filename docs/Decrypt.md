# akeyless.Model.Decrypt
decrypt is a command that decrypts ciphertext into plaintext by using an AES key.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ciphertext** | **string** | Ciphertext to be decrypted in base64 encoded format | [optional] 
**DisplayId** | **string** | The display id of the key to use in the decryption process | [optional] 
**EncryptionContext** | **Dictionary&lt;string, string&gt;** | The encryption context. If this was specified in the encrypt command, it must be specified here or the decryption operation will fail | [optional] 
**ItemId** | **long** | The item id of the key to use in the decryption process | [optional] 
**KeyName** | **string** | The name of the key to use in the decryption process | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

