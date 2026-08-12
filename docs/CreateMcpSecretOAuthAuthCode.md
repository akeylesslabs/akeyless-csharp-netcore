# akeyless.Model.CreateMcpSecretOAuthAuthCode

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accessibility** | **string** | for personal password manager | [optional] [default to "regular"]
**AraEnabled** | **bool** | Enable or disable Agentic Runtime Authority rule enforcement for this item. When false, user-defined input/output rules are stored but not enforced; the base security validation still runs.  AraEnabled is tri-state (nil/true/false), not a plain bool: it self-encodes its wire value (see akl.OptionalBool) so an explicit false survives the curl-proxy relay instead of being dropped like a default-false bool flag. | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**InputRule** | **List&lt;string&gt;** | Agentic input rule in name&#x3D;...,rule&#x3D;... format (e.g. name&#x3D;rule1,rule&#x3D;Sanitize input) | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Metadata** | **string** | Deprecated - use description | [optional] 
**Name** | **string** | Secret name | 
**OauthClientId** | **string** | OAuth client ID | [optional] 
**OauthClientSecret** | **string** | OAuth client secret | [optional] 
**OauthRedirectUri** | **string** | OAuth redirect URI | [optional] 
**OauthRefreshToken** | **string** | OAuth refresh token | [optional] 
**OauthScopes** | **List&lt;string&gt;** | OAuth scopes | [optional] 
**OauthTokenUrl** | **string** | OAuth token URL | [optional] 
**OutputRule** | **List&lt;string&gt;** | Agentic output rule in name&#x3D;...,rule&#x3D;... format (e.g. name&#x3D;rule1,rule&#x3D;Mask secrets) | [optional] 
**ProtectionKey** | **string** |  | [optional] 
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Url** | **string** | URL of the service | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

