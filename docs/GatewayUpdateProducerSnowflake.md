# akeyless.Model.GatewayUpdateProducerSnowflake
GatewayUpdateProducerSnowflakeCmd is a command that updates a Snowflake producer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | **string** | Account name | [optional] 
**AccountPassword** | **string** | Database Password | [optional] 
**AccountUsername** | **string** | Database Username | [optional] 
**DbName** | **string** | Database name | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this item [true/false] | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Producer name | 
**NewName** | **string** | Producer name | [optional] 
**PrivateKey** | **string** | RSA Private key (base64 encoded) | [optional] 
**PrivateKeyPassphrase** | **string** | The Private key passphrase | [optional] 
**Role** | **string** | User role | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "24h"]
**Warehouse** | **string** | Warehouse name | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

