# akeyless.Model.GetSecretValue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accessibility** | **string** | for personal password manager | [optional] [default to "regular"]
**IgnoreCache** | **string** | Ignore Cache Retrieve the Secret value without checking the Gateway&#39;s cache [true/false]. This flag is only relevant when using the RestAPI | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] 
**Names** | **List&lt;string&gt;** | Secret name | 
**PrettyPrint** | **bool** | Print the secret value with json-pretty-print (not relevent to SDK) | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**_Version** | **int** | Secret version | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

