# akeyless.Model.CreateAuthMethodLDAP
createAuthMethodLDAP is a command that creates a new auth method that will be able to authenticate using LDAP.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessExpires** | **long** | Access expiration date in Unix timestamp (select 0 for access without expiry date) | [optional] [default to 0]
**BoundIps** | **List&lt;string&gt;** | A CIDR whitelist of the IPs that the access is restricted to | [optional] 
**Name** | **string** | Auth Method name | 
**PublicKeyFilePath** | **string** | A public key generated for LDAP authentication method on Akeyless [RSA2048] | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

