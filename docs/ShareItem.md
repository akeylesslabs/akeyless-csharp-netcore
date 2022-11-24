# akeyless.Model.ShareItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accessibility** | **string** | for personal password manager | [optional] [default to "regular"]
**Action** | **string** | Action to be performed on the item [start/stop/describe] | 
**Emails** | **List&lt;string&gt;** | For Password Management use, reflect the website context | [optional] 
**ItemName** | **string** | Item name | 
**Json** | **bool** | Set output format to JSON | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Ttl** | **int** | TTL of the Availability of the shared secret in seconds | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**ViewOnce** | **bool** | ViewOnlyOnce Shared secrets can only be viewed once [true/false] | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

