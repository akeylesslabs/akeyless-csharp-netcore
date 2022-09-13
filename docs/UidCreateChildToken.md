# akeyless.Model.UidCreateChildToken
uidCreateChildToken is a command that creates a new child token using Akeyless Universal Identity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthMethodName** | **string** | The universal identity auth method name, required only when uid-token is not provided | [optional] 
**ChildDenyInheritance** | **bool** | Deny from new child to create their own children | [optional] 
**ChildDenyRotate** | **bool** | Deny from new child to rotate | [optional] 
**ChildTtl** | **int** | New child token ttl | [optional] 
**Comment** | **string** | New Token comment | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UidTokenId** | **string** | The ID of the uid-token, required only when uid-token is not provided | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

