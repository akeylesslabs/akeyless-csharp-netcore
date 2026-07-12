# akeyless.Model.UpdateMcpSecretOAuthAuthCode

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accessibility** | **string** | for personal password manager | [optional] [default to "regular"]
**InputRule** | **List&lt;string&gt;** | Agentic input rule in name&#x3D;...,rule&#x3D;... format (e.g. name&#x3D;rule1,rule&#x3D;Sanitize input) | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Key** | **string** |  | [optional] 
**LastVersion** | **int** |  | [optional] 
**Name** | **string** | Secret name | 
**OauthClientId** | **string** | OAuth client ID | [optional] 
**OauthClientSecret** | **string** | OAuth client secret | [optional] 
**OauthRedirectUri** | **string** | OAuth redirect URI | [optional] 
**OauthRefreshToken** | **string** | OAuth refresh token | [optional] 
**OauthScopes** | **List&lt;string&gt;** | OAuth scopes | [optional] 
**OauthTokenUrl** | **string** | OAuth token URL | [optional] 
**OutputRule** | **List&lt;string&gt;** | Agentic output rule in name&#x3D;...,rule&#x3D;... format (e.g. name&#x3D;rule1,rule&#x3D;Mask secrets) | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Url** | **string** | URL of the service | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

