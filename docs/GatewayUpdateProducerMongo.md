# akeyless.Model.GatewayUpdateProducerMongo
gatewayUpdateProducerMongo is a command that updates either mongodb  producer or mongodb atlas producer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteProtection** | **string** | Protection from accidental deletion of this item [true/false] | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**MongodbAtlasApiPrivateKey** | **string** | MongoDB Atlas private key | [optional] 
**MongodbAtlasApiPublicKey** | **string** | MongoDB Atlas public key | [optional] 
**MongodbAtlasProjectId** | **string** | MongoDB Atlas project ID | [optional] 
**MongodbCustomData** | **string** | MongoDB custom data | [optional] 
**MongodbDefaultAuthDb** | **string** | MongoDB server default authentication database | [optional] 
**MongodbHostPort** | **string** | MongoDB server host and port | [optional] 
**MongodbName** | **string** | MongoDB Name | [optional] 
**MongodbPassword** | **string** | MongoDB server password. You will prompted to provide a password if it will not appear in CLI parameters | [optional] 
**MongodbRoles** | **string** | MongoDB Roles | [optional] [default to "[]"]
**MongodbServerUri** | **string** | MongoDB server URI | [optional] 
**MongodbUriOptions** | **string** | MongoDB server URI options | [optional] 
**MongodbUsername** | **string** | MongoDB server username | [optional] 
**Name** | **string** | Producer name | 
**NewName** | **string** | Producer name | [optional] 
**ProducerEncryptionKeyName** | **string** | Encrypt producer with following key | [optional] 
**SecureAccessBastionIssuer** | **string** | Path to the SSH Certificate Issuer for your Akeyless Bastion | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** | Target DB servers for connections | [optional] 
**SecureAccessWeb** | **bool** | Enable Web Secure Remote Access | [optional] [default to false]
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

