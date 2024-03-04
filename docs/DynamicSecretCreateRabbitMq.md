# akeyless.Model.DynamicSecretCreateRabbitMq
dynamicSecretCreateRabbitMq is a command that creates rabbitmq dynamic secret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteProtection** | **string** | Protection from accidental deletion of this item [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**RabbitmqAdminPwd** | **string** | RabbitMQ Admin password | [optional] 
**RabbitmqAdminUser** | **string** | RabbitMQ Admin User | [optional] 
**RabbitmqServerUri** | **string** | Server URI | [optional] 
**RabbitmqUserConfPermission** | **string** | User configuration permission | [optional] 
**RabbitmqUserReadPermission** | **string** | User read permission | [optional] 
**RabbitmqUserTags** | **string** | User Tags | [optional] 
**RabbitmqUserVhost** | **string** | User Virtual Host | [optional] 
**RabbitmqUserWritePermission** | **string** | User write permission | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessUrl** | **string** | Destination URL to inject secrets | [optional] 
**SecureAccessWeb** | **bool** | Enable Web Secure Remote Access | [optional] [default to true]
**SecureAccessWebBrowsing** | **bool** | Secure browser via Akeyless Web Access Bastion | [optional] [default to false]
**SecureAccessWebProxy** | **bool** | Web-Proxy via Akeyless Web Access Bastion | [optional] [default to false]
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

