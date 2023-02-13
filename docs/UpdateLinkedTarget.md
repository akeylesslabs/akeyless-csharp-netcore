# akeyless.Model.UpdateLinkedTarget

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddHosts** | **string** | Comma separated list of new hosts that will be added to the Linked Target hosts. | [optional] 
**Comment** | **string** | Deprecated - use description | [optional] 
**Description** | **string** | Description of the object | [optional] 
**Hosts** | **string** | A comma seperated list of server hosts. | 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Name** | **string** | Linked Target name | 
**NewName** | **string** | New Linked Target name | [optional] 
**ParentTargetName** | **string** | The parent Target name | [optional] 
**RmHosts** | **string** | Comma separated list of existing hosts that will be removed from Linked Target hosts. | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

