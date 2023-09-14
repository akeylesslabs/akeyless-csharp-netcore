# akeyless.Model.CreateUserEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capabilities** | **List&lt;string&gt;** | List of the required capabilities options: [read, update, delete,sra_transparently_connect]. Relevant only for request-access event types | [optional] 
**Comment** | **string** | Deprecated - use description | [optional] 
**Description** | **string** | Description of the object | [optional] 
**EventSource** | **string** |  | [optional] 
**EventType** | **string** |  | 
**ItemName** | **string** | EventItemName Event item name | 
**ItemType** | **string** | EventItemType Event item type | 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**RequestAccessTtl** | **long** | For how long to grant the requested access, in minutes | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

