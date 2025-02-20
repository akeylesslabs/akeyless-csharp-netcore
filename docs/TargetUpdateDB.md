# akeyless.Model.TargetUpdateDB

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DBDefinedConnectionType** | **string** |  | [optional] 
**AzureClientId** | **string** | (Optional) Client id (relevant for \&quot;cloud-service-provider\&quot; only) | [optional] 
**AzureClientSecret** | **string** | (Optional) Client secret (relevant for \&quot;cloud-service-provider\&quot; only) | [optional] 
**AzureTenantId** | **string** | (Optional) Tenant id (relevant for \&quot;cloud-service-provider\&quot; only) | [optional] 
**CloudServiceProvider** | **string** | (Optional) Cloud service provider (currently only supports Azure) | [optional] 
**ClusterMode** | **bool** | Cluster Mode | [optional] 
**Comment** | **string** | Deprecated - use description | [optional] 
**ConnectionType** | **string** | Type of connection to mssql/oracle database [credentials/cloud-identity/wallet] | [default to "credentials"]
**DbName** | **string** |  | [optional] 
**DbServerCertificates** | **string** | (Optional) DB server certificates | [optional] 
**DbServerName** | **string** | (Optional) Server name for certificate verification | [optional] 
**DbType** | **string** |  | 
**Description** | **string** | Description of the object | [optional] 
**Host** | **string** |  | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**MongodbAtlas** | **bool** |  | [optional] 
**MongodbAtlasApiPrivateKey** | **string** | MongoDB Atlas private key | [optional] 
**MongodbAtlasApiPublicKey** | **string** | MongoDB Atlas public key | [optional] 
**MongodbAtlasProjectId** | **string** | MongoDB Atlas project ID | [optional] 
**MongodbDefaultAuthDb** | **string** | MongoDB server default authentication database | [optional] 
**MongodbUriOptions** | **string** | MongoDB server URI options | [optional] 
**Name** | **string** | Target name | 
**NewName** | **string** | New target name | [optional] 
**OracleServiceName** | **string** | Oracle db service name | [optional] 
**OracleWalletLoginType** | **string** | Oracle Wallet login type (password/mtls) | [optional] 
**OracleWalletP12FileData** | **string** | Oracle wallet p12 file data in base64 | [optional] 
**OracleWalletSsoFileData** | **string** | Oracle wallet sso file data in base64 | [optional] 
**Port** | **string** |  | [optional] 
**Pwd** | **string** |  | [optional] 
**SnowflakeAccount** | **string** |  | [optional] 
**SnowflakeApiPrivateKey** | **string** | RSA Private key (base64 encoded) | [optional] 
**SnowflakeApiPrivateKeyPassword** | **string** | The Private key passphrase | [optional] 
**Ssl** | **bool** | Enable/Disable SSL [true/false] | [optional] [default to false]
**SslCertificate** | **string** | SSL connection certificate | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserName** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

