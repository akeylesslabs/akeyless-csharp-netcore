# akeyless.Model.GatewayCreateProducerChef
gatewayCreateProducerChef is a command that creates chef producer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChefOrgs** | **string** | Organizations | 
**ChefServerKey** | **string** | Server key | 
**ChefServerUrl** | **string** | Server URL | 
**ChefServerUsername** | **string** | Server username | 
**GatewayUrl** | **string** | Gateway url | [optional] [default to "http://localhost:8000"]
**Name** | **string** | Producer name | 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**SkipSsl** | **bool** | Skip SSL | [optional] [default to true]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

