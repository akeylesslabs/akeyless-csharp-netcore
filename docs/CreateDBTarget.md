# akeyless.Model.CreateDBTarget

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Comment** | **string** | Comment about the target | [optional] 
**DbName** | **string** |  | [optional] 
**DbServerCertificates** | **string** | (Optional) DB server certificates | [optional] 
**DbServerName** | **string** | (Optional) Server name for certificate verification | [optional] 
**DbType** | **string** |  | 
**Host** | **string** |  | [optional] 
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**MongodbAtlas** | **bool** |  | [optional] 
**MongodbAtlasApiPrivateKey** | **string** | MongoDB Atlas private key | [optional] 
**MongodbAtlasApiPublicKey** | **string** | MongoDB Atlas public key | [optional] 
**MongodbAtlasProjectId** | **string** | MongoDB Atlas project ID | [optional] 
**MongodbDefaultAuthDb** | **string** | MongoDB server default authentication database | [optional] 
**MongodbUriOptions** | **string** | MongoDB server URI options | [optional] 
**Name** | **string** | Target name | 
**OracleServiceName** | **string** |  | [optional] 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**Port** | **string** |  | [optional] 
**Pwd** | **string** |  | [optional] 
**SnowflakeAccount** | **string** |  | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserName** | **string** |  | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

