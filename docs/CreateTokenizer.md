# akeyless.Model.CreateTokenizer
createTokenizer is a command that creates a tokenizer item

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alphabet** | **string** | Alphabet to use in regexp vaultless tokenization | [optional] 
**DecodingTemplate** | **string** | The Decoding output template to use in regexp vaultless tokenization | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**EncodingTemplate** | **string** | The Encoding output template to use in regexp vaultless tokenization | [optional] 
**EncryptionKeyName** | **string** | AES key name to use in vaultless tokenization | [optional] 
**ItemCustomFields** | **Dictionary&lt;string, string&gt;** | Additional custom fields to associate with the item | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Metadata** | **string** | Deprecated - use description | [optional] 
**Name** | **string** | Tokenizer name | 
**Pattern** | **string** | Pattern to use in regexp vaultless tokenization | [optional] 
**Tag** | **List&lt;string&gt;** | List of the tags attached to this key | [optional] 
**TemplateType** | **string** | Which template type this tokenizer is used for [SSN,CreditCard,USPhoneNumber,Email,Regexp] | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**TokenizerType** | **string** | Tokenizer type | [default to "vaultless"]
**TweakType** | **string** | The tweak type to use in vaultless tokenization [Supplied, Generated, Internal, Masking] | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

