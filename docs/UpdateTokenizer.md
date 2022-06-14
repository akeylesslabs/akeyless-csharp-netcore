# akeyless.Model.UpdateTokenizer
updateTokenizer is a command that updates a tokenizer item

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddTag** | **List&lt;string&gt;** | List of the new tags that will be attached to this item | [optional] 
**Alphabet** | **string** | Alphabet to use in regexp vaultless tokenization | [optional] 
**DecryptionTemplate** | **string** | The Decryption output template to use in regexp vaultless tokenization | [optional] 
**DeleteProtection** | **string** |  | [optional] 
**EncryptionKeyName** | **string** | AES key name to use in vaultless tokenization | [optional] 
**EncryptionTemplate** | **string** | The Encryption output template to use in regexp vaultless tokenization | [optional] 
**Name** | **string** | Current item name | 
**NewMetadata** | **string** | New item metadata | [optional] [default to "default_metadata"]
**NewName** | **string** | New item name | [optional] 
**Pattern** | **string** | Pattern to use in regexp vaultless tokenization | [optional] 
**RmTag** | **List&lt;string&gt;** | List of the existent tags that will be removed from this item | [optional] 
**TemplateType** | **string** | Which template type this tokenizer is used for [SSN,CreditCard,USPhoneNumber,Email,Regexp] | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**TokenizerType** | **string** | Tokenizer type | 
**TweakType** | **string** | The tweak type to use in vaultless tokenization [Supplied, Generated, Internal, Masking] | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

