# akeyless.Model.GatewayCreateProducerHanaDb
gatewayCreateProducerHanaDb is a command that creates hanadb producer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HanaDbname** | **string** | HanaDb Name | [optional] 
**HanadbCreateStatements** | **string** | HanaDb Creation statements | [optional] 
**HanadbHost** | **string** | HanaDb Host | [optional] [default to "127.0.0.1"]
**HanadbPassword** | **string** | HanaDb Password | [optional] 
**HanadbPort** | **string** | HanaDb Port | [optional] [default to "443"]
**HanadbRevocationStatements** | **string** | HanaDb Revocation statements | [optional] 
**HanadbUsername** | **string** | HanaDb Username | [optional] 
**Name** | **string** | Producer name | 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**SecureAccessBastionIssuer** | **string** |  | [optional] 
**SecureAccessDbSchema** | **string** |  | [optional] 
**SecureAccessEnable** | **string** |  | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** |  | [optional] 
**SecureAccessWeb** | **bool** |  | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

