# akeyless.Model.GatewayCreateProducerRabbitMQ
gatewayCreateProducerRabbitMQ is a command that creates rabbitmq producer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Producer name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**RabbitmqAdminPwd** | **string** | RabbitMQ Admin password | [optional] 
**RabbitmqAdminUser** | **string** | RabbitMQ Admin User | [optional] 
**RabbitmqServerUri** | **string** | Server URI | [optional] 
**RabbitmqUserConfPermission** | **string** | User configuration permission | [optional] 
**RabbitmqUserReadPermission** | **string** | User read permission | [optional] 
**RabbitmqUserTags** | **string** | User Tags | [optional] 
**RabbitmqUserVhost** | **string** | User Virtual Host | [optional] 
**RabbitmqUserWritePermission** | **string** | User write permission | [optional] 
**SecureAccessEnable** | **string** |  | [optional] 
**SecureAccessUrl** | **string** |  | [optional] 
**SecureAccessWebBrowsing** | **bool** |  | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

