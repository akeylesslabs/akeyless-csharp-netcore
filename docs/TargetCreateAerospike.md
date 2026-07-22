# akeyless.Model.TargetCreateAerospike

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminUsername** | **string** | Username of an account with the user-admin role | [optional] 
**AerospikeClientId** | **string** | Client ID for Aerospike Cloud authentication (relevant only for Aerospike Cloud) | [optional] 
**AerospikeClientSecret** | **string** | Client secret for Aerospike Cloud authentication (relevant only for Aerospike Cloud) | [optional] 
**AerospikeCloud** | **bool** | Set to &#39;true&#39; for Aerospike Cloud deployments | [optional] 
**AerospikeClusterId** | **string** | Cloud cluster ID (relevant only for Aerospike Cloud) | [optional] 
**ClientCertificate** | **string** | Client certificate for mTLS (mTLS only) | [optional] 
**ClientPrivateKey** | **string** | Client private key for mTLS (mTLS only) | [optional] 
**DbServerName** | **string** | TLS server name used to verify the certificate hostname. If empty, the Aerospike hostname is used. | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**EnableMtls** | **bool** | Enable mutual TLS authentication - requires - -ssl&#x3D;true (true/false) | [optional] 
**Hostname** | **string** | Aerospike host address and port (e.g. url.to.aerospike.db) | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Target name | 
**Namespace** | **string** | Namespace name (relevant only for Aerospike db) | [optional] 
**Password** | **string** | Password for the admin user | [optional] 
**Port** | **string** | Database connection port | [optional] 
**SkipServerNameValidation** | **string** | Skip server name verification while still validating the certificate chain (true/false). Empty means do not skip. | [optional] 
**Ssl** | **bool** | Enable SSL encryption (true/false) | [optional] 
**SslCertificate** | **string** | Base64-encoded SSL CA certificate from a trusted Certificate Authority (CA) | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

