# akeyless.Model.ExportClassicKey
ExportClassicKey is a command that returns the classic key material

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IgnoreCache** | **string** | Retrieve the Secret value without checking the Gateway&#39;s cache [true/false]. This flag is only relevant when using the RestAPI | [optional] [default to "false"]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | ClassicKey name | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**_Version** | **int** | Classic key version | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

