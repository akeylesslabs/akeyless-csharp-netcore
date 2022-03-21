# akeyless.Model.OIDCAccessRules
OIDCAccessRules contains access rules specific to Open Id Connect authentication method.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedRedirectURIs** | **List&lt;string&gt;** | Allowed redirect URIs after the authentication | [optional] 
**BoundClaims** | [**List&lt;OIDCCustomClaim&gt;**](OIDCCustomClaim.md) | The claims that login is restricted to. | [optional] 
**ClientId** | **string** | Client ID | [optional] 
**ClientSecret** | **string** | Client Secret | [optional] 
**IsInternal** | **bool** | IsInternal indicates whether this is an internal Auth Method where the client has no control over it, or it was created by the client e.g - Sign In with Google will create an OIDC Auth Method with IsInternal&#x3D;true | [optional] 
**Issuer** | **string** | Issuer URL | [optional] 
**UniqueIdentifier** | **string** | A unique identifier to distinguish different users | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

