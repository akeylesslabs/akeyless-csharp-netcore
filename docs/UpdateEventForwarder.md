# akeyless.Model.UpdateEventForwarder
updateEventForwarder is a command that updates an event forwarder [Deprecated - please use event-forwarder-update-* command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminName** | **string** | Workstation Admin Name | [optional] 
**AuthType** | **string** | The authentication type to use when connecting to ServiceNow (user-pass / jwt) | [optional] [default to "user-pass"]
**ClientId** | **string** | The client ID to use when connecting to ServiceNow with jwt authentication | [optional] 
**Description** | **string** | Description of the object | [optional] [default to "default_comment"]
**EmailTo** | **string** | A comma seperated list of email addresses to send event to (relevant only for \&quot;email\&quot; Event Forwarder) | [optional] 
**Enable** | **string** | Enable/Disable Event Forwarder [true/false] | [optional] [default to "true"]
**EventSourceLocations** | **List&lt;string&gt;** | Event sources | [optional] 
**EventTypes** | **List&lt;string&gt;** | Event types | [optional] 
**Host** | **string** | Workstation Host | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | EventForwarder name | 
**NewComment** | **string** | Deprecated - use description | [optional] [default to "default_comment"]
**NewName** | **string** | New EventForwarder name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserEmail** | **string** | The user email to use when connecting to ServiceNow with jwt authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

