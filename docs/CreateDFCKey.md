# akeyless.Model.CreateDFCKey
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alg** | **string** | DFCKey type; options: [AES128GCM, AES256GCM, AES128SIV, AES256SIV, RSA1024, RSA2048, RSA3072, RSA4096] | 
**CustomerFrgId** | **string** | The customer fragment ID that will be used to create the DFC key (if empty, the key will be created independently of a customer fragment) | [optional] 
**Metadata** | **string** | Metadata about the DFC key | [optional] 
**Name** | **string** | DFCKey name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**SplitLevel** | **long** | The number of fragments that the item will be split into (not includes customer fragment) | [optional] [default to 2]
**Tag** | **List&lt;string&gt;** | List of the tags attached to this DFC key | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

