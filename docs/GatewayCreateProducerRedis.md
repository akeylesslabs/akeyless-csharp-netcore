# akeyless.Model.GatewayCreateProducerRedis
gatewayCreateProducerRedis is a command that creates Redis producer [Deprecated: Use dynamic-secret-create-redis command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AclRules** | **string** | A JSON array list of redis ACL rules to attach to the created user. For available rules see the ACL CAT command https://redis.io/commands/acl-cat By default the user will have permissions to read all keys &#39;[\&quot;~*\&quot;, \&quot;+@read\&quot;]&#39; | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Host** | **string** | Redis Host | [optional] [default to "127.0.0.1"]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**Password** | **string** | Redis Password | [optional] 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**Port** | **string** | Redis Port | [optional] [default to "6379"]
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**Ssl** | **bool** | Enable/Disable SSL [true/false] | [optional] [default to false]
**SslCertificate** | **string** | SSL CA certificate in base64 encoding generated from a trusted Certificate Authority (CA) | [optional] 
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]
**Username** | **string** | Redis Username | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

