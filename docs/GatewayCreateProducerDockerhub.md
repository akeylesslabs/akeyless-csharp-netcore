# akeyless.Model.GatewayCreateProducerDockerhub
gatewayCreateProducerDockerhub is a command that creates a DOCKERHUB producer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteProtection** | **string** | Protection from accidental deletion of this item [true/false] | [optional] 
**DockerhubPassword** | **string** | DockerhubPassword is either the user&#39;s password access token to manage the repository | [optional] 
**DockerhubTokenScopes** | **string** | Access token scopes list (comma-separated) to give the dynamic secret valid options are in \&quot;repo:admin\&quot;, \&quot;repo:write\&quot;, \&quot;repo:read\&quot;, \&quot;repo:public_read\&quot; | [optional] 
**DockerhubUsername** | **string** | DockerhubUsername is the name of the user in dockerhub | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Producer name | 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

