# akeyless.Model.RegexpTokenizerInfo
RegexpTokenizerInfo represents a general Regexp tokenization template

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alphabet** | **string** | The Alphabet used for the tokenization | [optional] 
**DecodingTemplate** | **string** | Transformation to perform on the decrypted data | [optional] 
**EncodingTemplate** | **string** | Transformation to perform on the encrypted data, if the required output template doesn&#39;t match the input string The output Should still be valid for the Pattern, otherwise the secret would be able to be decrypted. | [optional] 
**Pattern** | **string** | Regexp pattern to extract and deposit the text/encdata | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

