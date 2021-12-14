# akeyless.Model.GatewayUpdateProducerChef
gatewayUpdateProducerChef is a command that updates chef producer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChefOrgs** | **string** | Organizations | [optional] 
**ChefServerKey** | **string** | Server key | [optional] 
**ChefServerUrl** | **string** | Server URL | [optional] 
**ChefServerUsername** | **string** | Server username | [optional] 
**Name** | **string** | Producer name | 
**NewName** | **string** | Producer name | [optional] 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**SkipSsl** | **bool** | Skip SSL | [optional] [default to true]
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

