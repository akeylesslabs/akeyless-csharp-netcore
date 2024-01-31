# akeyless.Model.GatewayUpdateProducerCassandra
gatewayUpdateProducerCassandra is a command that updates a Cassandra producer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CassandraCreationStatements** | **string** | Cassandra creation statements | [optional] 
**CassandraHosts** | **string** | Cassandra hosts IP or addresses, comma separated | [optional] 
**CassandraPassword** | **string** | Cassandra superuser password | [optional] 
**CassandraPort** | **string** | Cassandra port | [optional] [default to "9042"]
**CassandraUsername** | **string** | Cassandra superuser username | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this item [true/false] | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Producer name | 
**NewName** | **string** | Producer name | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**Ssl** | **bool** | Enable/Disable SSL [true/false] | [optional] [default to false]
**SslCertificate** | **string** | SSL CA certificate in base64 encoding generated from a trusted Certificate Authority (CA) | [optional] 
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

