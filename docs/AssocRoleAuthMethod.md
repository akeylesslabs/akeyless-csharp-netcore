# akeyless.Model.AssocRoleAuthMethod
assocRoleAuthMethod is a command that creates an association between role and auth method.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmName** | **string** | The auth method to associate | 
**CaseSensitive** | **string** |  | [optional] 
**RoleName** | **string** | The role to associate | 
**SubClaims** | **Dictionary&lt;string, string&gt;** | key/val of sub claims, e.g group&#x3D;admins,developers | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

