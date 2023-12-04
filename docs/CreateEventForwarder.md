# akeyless.Model.CreateEventForwarder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminName** | **string** | Workstation Admin Name | [optional] 
**AdminPwd** | **string** | Workstation Admin password | [optional] 
**AppPrivateKeyBase64** | **string** | The RSA Private Key PEM formatted in base64 to use when connecting to ServiceNow with jwt authentication | [optional] 
**AuthType** | **string** | The authentication type to use when connecting to ServiceNow (user-pass / jwt) | [optional] [default to "user-pass"]
**ClientId** | **string** | The client ID to use when connecting to ServiceNow with jwt authentication | [optional] 
**ClientSecret** | **string** | The client secret to use when connecting to ServiceNow with jwt authentication | [optional] 
**Comment** | **string** | Deprecated - use description | [optional] 
**Description** | **string** | Description of the object | [optional] 
**EmailTo** | **string** | A comma seperated list of email addresses to send event to (relevant only for \&quot;email\&quot; Event Forwarder) | [optional] 
**EventSourceLocations** | **List&lt;string&gt;** | Event sources | 
**EventSourceType** | **string** | Event Source type [item, target, auth_method] | [optional] [default to "item"]
**EventTypes** | **List&lt;string&gt;** | List of event types to notify about [request-access, certificate-pending-expiration, certificate-expired, auth-method-pending-expiration, auth-method-expired, rotated-secret-success, rotated-secret-failure, dynamic-secret-failure, multi-auth-failure, uid-rotation-failure] | [optional] 
**Every** | **string** | Rate of periodic runner repetition in hours | [optional] 
**ForwarderType** | **string** |  | 
**Host** | **string** | Workstation Host | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of a key that used to encrypt the EventForwarder secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Name** | **string** | EventForwarder name | 
**RunnerType** | **string** |  | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserEmail** | **string** | The user email to use when connecting to ServiceNow with jwt authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

