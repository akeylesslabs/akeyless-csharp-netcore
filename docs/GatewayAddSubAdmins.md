# akeyless.Model.GatewayAddSubAdmins
gatewayAddSubAdmins is a command that adds sub-admins
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowGwApi** | **bool** |  | [optional] 
**AllowGwLogin** | **bool** |  | [optional] 
**GatewayUrl** | **string** | Gateway url | [optional] [default to "http://localhost:8000"]
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**SubAdminAccessId** | **string** | SubAdmins to add | 
**SubClaims** | **Dictionary&lt;string, string&gt;** | key/val of sub claims, e.g group&#x3D;admins,developers | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

