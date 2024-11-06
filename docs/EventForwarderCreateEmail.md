# akeyless.Model.EventForwarderCreateEmail
eventForwarderCreateEmail is a command that creates email event forwarder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthMethodsEventSourceLocations** | **List&lt;string&gt;** | Auth Method Event sources | [optional] 
**Description** | **string** | Description of the object | [optional] 
**EmailTo** | **string** | A comma seperated list of email addresses to send event to | [optional] 
**EventTypes** | **List&lt;string&gt;** | List of event types to notify about [request-access, certificate-pending-expiration, certificate-expired, certificate-provisioning-success, certificate-provisioning-failure, auth-method-pending-expiration, auth-method-expired, next-automatic-rotation, rotated-secret-success, rotated-secret-failure, dynamic-secret-failure, multi-auth-failure, uid-rotation-failure, apply-justification, email-auth-method-approved, usage, rotation-usage, gateway-inactive, static-secret-updated, rate-limiting, usage-report] | [optional] 
**Every** | **string** | Rate of periodic runner repetition in hours | [optional] 
**GatewaysEventSourceLocations** | **List&lt;string&gt;** | Event sources | 
**IncludeError** | **string** | Set this option to include event errors details [true/false] | [optional] 
**ItemsEventSourceLocations** | **List&lt;string&gt;** | Items Event sources | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of a key that used to encrypt the EventForwarder secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Name** | **string** | EventForwarder name | 
**OverrideUrl** | **string** | Override Akeyless default URL with your Gateway url (port 18888) | [optional] 
**RunnerType** | **string** |  | 
**TargetsEventSourceLocations** | **List&lt;string&gt;** | Targets Event sources | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

