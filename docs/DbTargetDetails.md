# akeyless.Model.DbTargetDetails
DbTargetDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CloudServiceProvider** | **string** |  | [optional] 
**ClusterMode** | **bool** |  | [optional] 
**ConnectionType** | **string** |  | [optional] 
**DbClientId** | **string** |  | [optional] 
**DbClientSecret** | **string** |  | [optional] 
**DbHostName** | **string** |  | [optional] 
**DbName** | **string** |  | [optional] 
**DbPort** | **string** |  | [optional] 
**DbPrivateKey** | **string** | (Optional) Private Key in PEM format | [optional] 
**DbPrivateKeyPassphrase** | **string** |  | [optional] 
**DbPwd** | **string** |  | [optional] 
**DbServerCertificates** | **string** | (Optional) DBServerCertificates defines the set of root certificate authorities that clients use when verifying server certificates. If DBServerCertificates is empty, TLS uses the host&#39;s root CA set. | [optional] 
**DbServerName** | **string** | (Optional) ServerName is used to verify the hostname on the returned certificates unless InsecureSkipVerify is given. It is also included in the client&#39;s handshake to support virtual hosting unless it is an IP address. | [optional] 
**DbTenantId** | **string** |  | [optional] 
**DbUserName** | **string** |  | [optional] 
**OracleWalletDetails** | [**WalletDetails**](WalletDetails.md) |  | [optional] 
**SfAccount** | **string** |  | [optional] 
**SslConnectionCertificate** | **string** | (Optional) SSLConnectionCertificate defines the certificate for SSL connection. Must be base64 certificate loaded by UI using file loader field | [optional] 
**SslConnectionMode** | **bool** | (Optional) SSLConnectionMode defines if SSL mode will be used to connect to DB | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

