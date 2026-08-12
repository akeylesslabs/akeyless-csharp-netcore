# akeyless.Model.RotatedSecretSync

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteRemote** | **bool** | Delete the secret from remote secret manager (for association create/update) | [optional] 
**Environments** | **string** | GitHub environments to sync to. Relevant only for GitHub targets. Syncs to all environments defined on the selected USC by default, or to one or more specific repositories associated with that USC item when specified (e.g. - -environments repo1/env1,repo2/env2). | [optional] 
**FilterSecretValue** | **string** | JQ expression to filter or transform the secret value | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Rotated secret name | 
**Namespace** | **string** | Vault namespace, releavnt only for Hashicorp Vault Target | [optional] 
**RemoteSecretName** | **string** | Remote Secret Name that will be synced on the remote endpoint | [optional] 
**Repositories** | **string** | GitHub repositories to sync to. Relevant only for GitHub targets. Syncs to all repositories defined on the selected USC by default, or to one or more specific repositories associated with that USC item when specified (e.g. - -repositories repo1,repo2). | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UscName** | **string** | Universal Secret Connector name, If not provided all attached USC&#39;s will be synced | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

