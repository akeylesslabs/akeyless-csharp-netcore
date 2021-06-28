# akeyless.Model.GatewayCreateProducerSnowflake
gatewayCreateProducerSnowflakeCmd is a command that creates a Snowflake producer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | **string** | Account name | 
**DbName** | **string** | Database name | 
**Name** | **string** | Producer name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**Role** | **string** | User role | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "24h"]
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 
**Warehouse** | **string** | Warehouse name | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

