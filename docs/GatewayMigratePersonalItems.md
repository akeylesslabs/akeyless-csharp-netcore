# akeyless.Model.GatewayMigratePersonalItems
gatewayMigratePersonalItems is a command that migrate personal items from external vault

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Var1passwordEmail** | **string** | 1Password user email to connect to the API | [optional] 
**Var1passwordPassword** | **string** | 1Password user password to connect to the API | [optional] 
**Var1passwordSecretKey** | **string** | 1Password user secret key to connect to the API | [optional] 
**Var1passwordUrl** | **string** | 1Password api container url | [optional] 
**Var1passwordVaults** | **List&lt;string&gt;** | 1Password list of vault to get the items from | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**ProtectionKey** | **string** | The name of a key that used to encrypt the secret value | [optional] 
**TargetLocation** | **string** | Target location in your Akeyless personal folder for migrated secrets | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Type** | **string** | Migration type for now only 1password. | [optional] [default to "1password"]
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

