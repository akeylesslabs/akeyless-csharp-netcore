# akeyless.Model.DynamicSecretCreateGoogleWorkspace
dynamicSecretCreateGoogleWorkspace is a command that creates Google Workspace dynamic secret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessMode** | **string** |  | 
**AdminEmail** | **string** | Admin user email | 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**GcpKey** | **string** | Base64-encoded service account private key text | [optional] 
**GroupEmail** | **string** | A group email, relevant only for group access-mode | [optional] 
**GroupRole** | **string** |  | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**RoleName** | **string** | Name of the admin role to assign to the user, relevant only for role access-mode | [optional] 
**RoleScope** | **string** |  | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessUrl** | **string** | Destination URL to inject secrets | [optional] 
**SecureAccessWeb** | **bool** | Enable Web Secure Remote Access | [optional] [default to true]
**SecureAccessWebBrowsing** | **bool** | Secure browser via Akeyless Web Access Bastion | [optional] [default to false]
**SecureAccessWebProxy** | **bool** | Web-Proxy via Akeyless Web Access Bastion | [optional] [default to false]
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Name of existing target to use in dynamic secret creation | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

