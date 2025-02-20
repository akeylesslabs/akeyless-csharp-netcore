# akeyless.Model.EventForwarderUpdateWebhook
eventForwarderUpdateWebhook is a command that updates webhook event forwarder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthMethodsEventSourceLocations** | **List&lt;string&gt;** | Auth Method Event sources | [optional] 
**AuthToken** | **string** | Base64 encoded Token string for authentication type Token | [optional] 
**AuthType** | **string** | The Webhook authentication type [user-pass, bearer-token, certificate] | [optional] [default to "user-pass"]
**ClientCertData** | **string** | Base64 encoded PEM certificate, relevant for certificate auth-type | [optional] 
**Description** | **string** | Description of the object | [optional] 
**Enable** | **string** | Enable/Disable Event Forwarder [true/false] | [optional] [default to "true"]
**EventTypes** | **List&lt;string&gt;** | List of event types to notify about [request-access, certificate-pending-expiration, certificate-expired, certificate-provisioning-success, certificate-provisioning-failure, auth-method-pending-expiration, auth-method-expired, next-automatic-rotation, rotated-secret-success, rotated-secret-failure, dynamic-secret-failure, multi-auth-failure, uid-rotation-failure, apply-justification, email-auth-method-approved, usage, rotation-usage, gateway-inactive, static-secret-updated, rate-limiting, usage-report, secret-sync] | [optional] 
**GatewaysEventSourceLocations** | **List&lt;string&gt;** | Event sources | 
**ItemsEventSourceLocations** | **List&lt;string&gt;** | Items Event sources | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Key** | **string** | The name of a key that used to encrypt the EventForwarder secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Name** | **string** | EventForwarder name | 
**NewName** | **string** | New EventForwarder name | [optional] 
**Password** | **string** | Password for authentication relevant for user-pass auth-type | [optional] 
**PrivateKeyData** | **string** | Base64 encoded PEM RSA Private Key, relevant for certificate auth-type | [optional] 
**ServerCertificates** | **string** | Base64 encoded PEM certificate of the Webhook | [optional] 
**TargetsEventSourceLocations** | **List&lt;string&gt;** | Targets Event sources | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Url** | **string** | Webhook URL | [optional] 
**Username** | **string** | Username for authentication relevant for user-pass auth-type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

