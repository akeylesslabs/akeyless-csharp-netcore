# akeyless.Model.UpdateLinkedTarget
updateLinkedTarget is a command that updates an existing target. [Deprecated: Use target-update-linked command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddHosts** | **string** | A comma seperated list of new server hosts and server descriptions joined by semicolon &#39;;&#39; that will be added to the Linked Target hosts. | [optional] 
**Description** | **string** | Description of the object | [optional] 
**Hosts** | **string** | A comma seperated list of server hosts and server descriptions joined by semicolon &#39;;&#39; (i.e. &#39;server-dev.com;My Dev server,server-prod.com;My Prod server description&#39;) | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Name** | **string** | Linked Target name | 
**NewName** | **string** | New Linked Target name | [optional] 
**ParentTargetName** | **string** | The parent Target name | [optional] 
**RmHosts** | **string** | Comma separated list of existing hosts that will be removed from Linked Target hosts. | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Type** | **string** | Specifies the hosts type, relevant only when working without parent target | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

