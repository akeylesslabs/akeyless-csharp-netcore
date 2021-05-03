# akeyless.Model.GatewayCreateProducerCustom
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreateSyncUrl** | **string** | URL of an endpoint that implements /sync/create method, for example https://webhook.example.com/sync/create | 
**GatewayUrl** | **string** | Gateway url | [optional] [default to "http://localhost:8000"]
**Name** | **string** | Producer name | 
**Payload** | **string** | Secret payload to be sent with each create/revoke webhook request | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**RevokeSyncUrl** | **string** | URL of an endpoint that implements /sync/revoke method, for example https://webhook.example.com/sync/revoke | 
**RotateSyncUrl** | **string** | URL of an endpoint that implements /sync/rotate method, for example https://webhook.example.com/sync/rotate | [optional] 
**TimeoutSec** | **long** | Maximum allowed time in seconds for the webhook to return the results | [optional] [default to 60]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

