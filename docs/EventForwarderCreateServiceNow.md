# akeyless.Model.EventForwarderCreateServiceNow
eventForwarderCreateServiceNow is a command that creates service-now event forwarder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminName** | **string** | Workstation Admin Name | [optional] 
**AdminPwd** | **string** | Workstation Admin Password | [optional] 
**AppPrivateKeyBase64** | **string** | The RSA Private Key to use when connecting with jwt authentication | [optional] 
**AuthMethodsEventSourceLocations** | **List&lt;string&gt;** | Auth Method Event sources | [optional] 
**AuthType** | **string** | The authentication type to use [user-pass/jwt] | [optional] [default to "user-pass"]
**ClientId** | **string** | The client ID to use when connecting with jwt authentication | [optional] 
**ClientSecret** | **string** | The client secret to use when connecting with jwt authentication | [optional] 
**Description** | **string** | Description of the object | [optional] 
**EventTypes** | **List&lt;string&gt;** | List of event types to notify about [request-access, certificate-pending-expiration, certificate-expired, certificate-provisioning-success, certificate-provisioning-failure, auth-method-pending-expiration, auth-method-expired, next-automatic-rotation, rotated-secret-success, rotated-secret-failure, dynamic-secret-failure, multi-auth-failure, uid-rotation-failure, apply-justification, email-auth-method-approved, usage, rotation-usage, gateway-inactive, static-secret-updated] | [optional] 
**Every** | **string** | Rate of periodic runner repetition in hours | [optional] 
**GatewaysEventSourceLocations** | **List&lt;string&gt;** | Event sources | 
**Host** | **string** | Workstation Host | [optional] 
**ItemsEventSourceLocations** | **List&lt;string&gt;** | Items Event sources | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of a key that used to encrypt the EventForwarder secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Name** | **string** | EventForwarder name | 
**RunnerType** | **string** |  | 
**TargetsEventSourceLocations** | **List&lt;string&gt;** | Targets Event sources | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserEmail** | **string** | The user email to identify with when connecting with jwt authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

