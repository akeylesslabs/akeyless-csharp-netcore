# akeyless.Model.UpdateSecretVal

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accessibility** | **string** | for personal password manager | [optional] [default to "regular"]
**CustomField** | **Dictionary&lt;string, string&gt;** | For Password Management use, additional fields | [optional] 
**InjectUrl** | **List&lt;string&gt;** | For Password Management use, reflect the website context | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Key** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**LastVersion** | **int** | The last version number before the update | [optional] 
**Multiline** | **bool** | The provided value is a multiline value (separated by &#39;\\n&#39;) | [optional] 
**Name** | **string** | Secret name | 
**NewVersion** | **bool** | Deprecated | [optional] 
**Password** | **string** | For Password Management use, additional fields | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | For Password Management use | [optional] 
**Value** | **string** | The secret value (only relevant for type &#39;generic&#39;) | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

