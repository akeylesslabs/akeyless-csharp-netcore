# akeyless.Model.CreateKey
createKey is a command that creates a new key. [Deprecated: Use command create-dfc-key]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alg** | **string** | Key type; options: [AES128GCM, AES256GCM, AES128SIV, AES256SIV, AES128CBC, AES256CBC, RSA1024, RSA2048, RSA3072, RSA4096] | 
**CustomerFrgId** | **string** | The customer fragment ID that will be used to create the key (if empty, the key will be created independently of a customer fragment) | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this item [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Metadata** | **string** | Deprecated - use description | [optional] 
**Name** | **string** | Key name | 
**SplitLevel** | **long** | The number of fragments that the item will be split into (not includes customer fragment) | [optional] [default to 2]
**Tag** | **List&lt;string&gt;** | List of the tags attached to this key | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

