# akeyless.Model.StaticSecretDeleteSync

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteFromUsc** | **bool** | Delete the secret from the remote target USC as well | [optional] [default to false]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Static secret name | 
**RemoteSecretName** | **string** | Remote Secret Name to disambiguate when multiple syncs exist under the same USC | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UscName** | **string** | Universal Secret Connector name | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

