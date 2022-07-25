# akeyless.Model.UpdateSecretVal

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accessibility** | **string** | for personal password manager | [optional] 
**KeepPrevVersion** | **string** |  | [optional] 
**Key** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Multiline** | **bool** | The provided value is a multiline value (separated by &#39;\\n&#39;) | [optional] 
**Name** | **string** | Secret name | 
**NewVersion** | **bool** | Deprecated | [optional] 
**PasswordManagerCustomField** | **Dictionary&lt;string, string&gt;** | For Password Management use, additional fields | [optional] 
**PasswordManagerInjectUrl** | **string** | For Password Management use, reflect the website context | [optional] 
**PasswordManagerPassword** | **string** | For Password Management use, additional fields | [optional] 
**PasswordManagerUsername** | **string** | For Password Management use | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Value** | **string** | The new secret value | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

