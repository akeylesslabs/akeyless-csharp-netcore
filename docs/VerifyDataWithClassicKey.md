# akeyless.Model.VerifyDataWithClassicKey

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | **string** | Data | 
**DisplayId** | **string** | The display id of the key to use in the verification process | [optional] 
**Hashed** | **bool** | Defines whether the data should be hashed as part of the signing. If true, the data will not be hashed | [optional] [default to false]
**HashingMethod** | **string** | HashingMethod | [optional] [default to "SHA256"]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeyName** | **string** | The name of the key to use in the verification process | 
**Signature** | **string** | The data&#39;s signature in a Base64 format. | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**_Version** | **int** | classic key version | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

