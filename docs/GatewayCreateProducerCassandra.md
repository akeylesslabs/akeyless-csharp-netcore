# akeyless.Model.GatewayCreateProducerCassandra
gatewayCreateProducerCassandra is a command that creates a Cassandra producer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CassandraCreationStatements** | **string** | Cassandra creation statements | [optional] 
**CassandraHosts** | **string** | Cassandra hosts IP or addresses, comma separated | [optional] 
**CassandraPassword** | **string** | Cassandra superuser password | [optional] 
**CassandraPort** | **string** | Cassandra port | [optional] [default to "9042"]
**CassandraUsername** | **string** | Cassandra superuser username | [optional] 
**Name** | **string** | Producer name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

