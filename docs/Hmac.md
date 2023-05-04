# akeyless.Model.Hmac

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayId** | **string** | The display id of the key to use in the encryption process | [optional] 
**HashFunction** | **string** | Hash function [sha-256,sha-512] | [optional] [default to "sha-256"]
**InputFormat** | **string** | Select default assumed format for any plaintext input. Currently supported options: [base64] | [optional] 
**ItemId** | **long** | The item id of the key to use in the encryption process | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeyName** | **string** | The name of the key to use in the encryption process | 
**Plaintext** | **string** | Data to perform hmac on | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

