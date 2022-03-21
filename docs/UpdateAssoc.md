# akeyless.Model.UpdateAssoc
updateAssoc is a command that updates the sub-claims of an association between role and auth method.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssocId** | **string** | The association id to be updated | 
**CaseSensitive** | **string** |  | [optional] 
**SubClaims** | **Dictionary&lt;string, string&gt;** | key/val of sub claims, e.g group&#x3D;admins,developers | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

