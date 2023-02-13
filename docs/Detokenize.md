# akeyless.Model.Detokenize
detokenize is a command that decrypts text with a tokenizer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ciphertext** | **string** | Data to be decrypted | 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**TokenizerName** | **string** | The name of the tokenizer to use in the decryption process | 
**Tweak** | **string** | Base64 encoded tweak for vaultless encryption | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

