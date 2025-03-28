# akeyless.Model.ExportClassicKey
ExportClassicKey is a command that returns the classic key material

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accessibility** | **string** | for personal password manager | [optional] [default to "regular"]
**ExportPublicKey** | **bool** | Use this option to output only public key | [optional] [default to false]
**IgnoreCache** | **string** | Retrieve the Secret value without checking the Gateway&#39;s cache [true/false]. This flag is only relevant when using the RestAPI | [optional] [default to "false"]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | ClassicKey name | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**VarVersion** | **int** | Classic key version | [optional] 
**WrappingKeyName** | **string** | Classic key name to wrap the key material with | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

