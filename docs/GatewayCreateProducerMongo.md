# akeyless.Model.GatewayCreateProducerMongo
gatewayCreateProducerMongo is a command that creates either mongodb  producer or mongodb atlas producer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteProtection** | **string** | Protection from accidental deletion of this item | [optional] 
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
**ProducerEncryptionKeyName** | **string** | Encrypt producer with following key | [optional] 
**SecureAccessBastionIssuer** | **string** |  | [optional] 
**SecureAccessEnable** | **string** |  | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** |  | [optional] 
**SecureAccessWeb** | **bool** |  | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

