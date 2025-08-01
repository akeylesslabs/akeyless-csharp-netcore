# akeyless.Model.GatewayCreateProducerCassandra
gatewayCreateProducerCassandra is a command that creates a Cassandra producer [Deprecated: Use dynamic-secret-create-cassandra command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CassandraCreationStatements** | **string** | Cassandra creation statements | [optional] 
**CassandraHosts** | **string** | Cassandra hosts IP or addresses, comma separated | [optional] 
**CassandraPassword** | **string** | Cassandra superuser password | [optional] 
**CassandraPort** | **string** | Cassandra port | [optional] [default to "9042"]
**CassandraUsername** | **string** | Cassandra superuser username | [optional] 
**CustomUsernameTemplate** | **string** | Customize how temporary usernames are generated using go template | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**Ssl** | **bool** | Enable/Disable SSL [true/false] | [optional] [default to false]
**SslCertificate** | **string** | SSL CA certificate in base64 encoding generated from a trusted Certificate Authority (CA) | [optional] 
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

