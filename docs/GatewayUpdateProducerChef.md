# akeyless.Model.GatewayUpdateProducerChef
gatewayUpdateProducerChef is a command that updates chef producer [Deprecated: Use dynamic-secret-update-chef command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChefOrgs** | **string** | Organizations | [optional] 
**ChefServerKey** | **string** | Server key | [optional] 
**ChefServerUrl** | **string** | Server URL | [optional] 
**ChefServerUsername** | **string** | Server username | [optional] 
**CustomUsernameTemplate** | **string** | Customize how temporary usernames are generated using go template | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**ItemCustomFields** | **Dictionary&lt;string, string&gt;** | Additional custom fields to associate with the item | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**NewName** | **string** | Dynamic secret name | [optional] 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**SkipSsl** | **bool** | Skip SSL | [optional] [default to true]
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

