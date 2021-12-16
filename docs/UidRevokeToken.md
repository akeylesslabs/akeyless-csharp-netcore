# akeyless.Model.UidRevokeToken
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthMethodName** | **string** | The universal identity auth method name | [optional] 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**RevokeToken** | **string** | the universal identity token/token-id to revoke | 
**RevokeType** | **string** | revokeSelf/revokeAll (delete only this token/this token and his children) | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

