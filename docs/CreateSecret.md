# akeyless.Model.CreateSecret
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Metadata** | **string** | Metadata about the secret | [optional] 
**MultilineValue** | **bool** | The provided value is a multiline value (separated by &#39;\\n&#39;) | [optional] 
**Name** | **string** | Secret name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**ProtectionKey** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**SecureAccessBastionIssuer** | **string** |  | [optional] 
**SecureAccessEnable** | **string** |  | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** |  | [optional] 
**SecureAccessSshCreds** | **string** |  | [optional] 
**SecureAccessUrl** | **string** |  | [optional] 
**SecureAccessWebBrowsing** | **bool** |  | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 
**Value** | **string** | The secret value | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

