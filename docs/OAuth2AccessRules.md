# akeyless.Model.OAuth2AccessRules
OAuth2AccessRules contains access rules specific to OAuth2 authentication method.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Audience** | **string** | The audience in the JWT. | [optional] 
**BoundClaims** | [**List&lt;OAuth2CustomClaim&gt;**](OAuth2CustomClaim.md) | The claims that login is restricted to. | [optional] 
**BoundClientsId** | **List&lt;string&gt;** | The clients ids that login is restricted to. | [optional] 
**Issuer** | **string** | Issuer URL | [optional] 
**JwksJsonData** | **string** | The JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server. base64 encoded string | [optional] 
**JwksUri** | **string** | The URL to the JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server. | [optional] 
**UniqueIdentifier** | **string** | A unique identifier to distinguish different users | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

