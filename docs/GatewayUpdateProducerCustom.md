# akeyless.Model.GatewayUpdateProducerCustom
gatewayUpdateProducerCustom is a command that updates a custom producer. [Deprecated: Use dynamic-secret-update-custom command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminRotationIntervalDays** | **long** | Define rotation interval in days | [optional] 
**CreateSyncUrl** | **string** | URL of an endpoint that implements /sync/create method, for example https://webhook.example.com/sync/create | 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**EnableAdminRotation** | **bool** | Should admin credentials be rotated | [optional] [default to false]
**ItemCustomFields** | **Dictionary&lt;string, string&gt;** | Additional custom fields to associate with the item | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**NewName** | **string** | Dynamic secret name | [optional] 
**Payload** | **string** | Secret payload to be sent with each create/revoke webhook request | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**RevokeSyncUrl** | **string** | URL of an endpoint that implements /sync/revoke method, for example https://webhook.example.com/sync/revoke | 
**RotateSyncUrl** | **string** | URL of an endpoint that implements /sync/rotate method, for example https://webhook.example.com/sync/rotate | [optional] 
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TimeoutSec** | **long** | Maximum allowed time in seconds for the webhook to return the results | [optional] [default to 60]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

