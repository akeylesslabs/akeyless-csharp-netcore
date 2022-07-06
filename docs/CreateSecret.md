# akeyless.Model.CreateSecret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomFields** | **Dictionary&lt;string, string&gt;** | For Password Management use, additional fields | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this item | [optional] 
**ItemAccessibility** | **string** | for personal password manager | [optional] 
**Metadata** | **string** | Metadata about the secret | [optional] 
**MultilineValue** | **bool** | The provided value is a multiline value (separated by &#39;\\n&#39;) | [optional] 
**Name** | **string** | Secret name | 
**PasswordLength** | **long** | For PasswordPolicy use | [optional] 
**ProtectionKey** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**SecureAccessBastionIssuer** | **string** |  | [optional] 
**SecureAccessEnable** | **string** |  | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** |  | [optional] 
**SecureAccessSshCreds** | **string** |  | [optional] 
**SecureAccessSshUser** | **string** |  | [optional] 
**SecureAccessUrl** | **string** |  | [optional] 
**SecureAccessWebBrowsing** | **bool** |  | [optional] 
**SecureAccessWebProxy** | **bool** |  | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Type** | **string** | For Password Management use, reflect the website context | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UseLowerLetters** | **string** | For PasswordPolicy use | [optional] 
**UseNumbers** | **string** | For PasswordPolicy use | [optional] 
**UseSpecialCharacters** | **string** | For PasswordPolicy use | [optional] 
**UseCapitalLetters** | **string** | For PasswordPolicy use | [optional] 
**Username** | **string** | For Password Management use | [optional] 
**Value** | **string** | The secret value | 
**Website** | **string** | For Password Management use, reflect the website context | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

