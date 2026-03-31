# akeyless.Model.UscDelete
uscDelete is a command that deletes a secret from a Universal Secrets Connector

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ForceDelete** | **bool** | Force delete objects that are soft deleted by default (relavent only for Azure target) | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Namespace** | **string** | The namespace (relevant for Hashi vault target) | [optional] 
**ObjectType** | **string** |  | [optional] 
**SecretId** | **string** | The universal secrets id (or name, for AWS, Azure, K8s or Hashi vault targets) to delete | 
**SelectedRepositories** | **string** | GitHub selected repositories. For repository scope: repo name. For repository-environment scope: repo/env (format: repo-name/env-name). Required when multiple repos/envs configured. | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UscName** | **string** | Name of the Universal Secrets Connector item | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

