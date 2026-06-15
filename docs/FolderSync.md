# akeyless.Model.FolderSync

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accessibility** | **string** | for personal password manager | [optional] [default to "regular"]
**DeleteRemote** | **bool** | Delete the secret from the remote target as well | [optional] 
**EngineName** | **string** | Hashi Vault engine name prefix, must end with &#39;/&#39; | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Folder name | 
**Namespace** | **string** | Vault namespace, relevant only for Hashicorp Vault Target | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UscName** | **string** | Universal Secret Connector name, If not provided all attached USC&#39;s will be synced | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

