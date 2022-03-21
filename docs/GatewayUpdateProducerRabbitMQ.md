# akeyless.Model.GatewayUpdateProducerRabbitMQ
gatewayUpdateProducerRabbitMQ is a command that updates rabbitmq producer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Producer name | 
**NewName** | **string** | Producer name | [optional] 
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
**SecureAccessWebProxy** | **bool** |  | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

