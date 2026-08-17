# akeyless.Model.SAMLAccessRules

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedRedirectURIs** | **List&lt;string&gt;** | Allowed redirect URIs after the authentication | [optional] 
**AuthorizedGwClusterName** | **string** | AuthorizedGwClusterName binds the access method to a single GW cluster. When empty (or whitespace-only), GW-driven auth is disabled. | [optional] 
**BoundAttributes** | [**List&lt;SAMLAttribute&gt;**](SAMLAttribute.md) | The attributes that login is restricted to. | [optional] 
**IdpMetadataUrl** | **string** | IDP metadata url | [optional] 
**IdpMetadataXml** | **string** | IDP metadata XML | [optional] 
**UniqueIdentifier** | **string** | A unique identifier to distinguish different users | [optional] 
**UseDedicatedSamlUrls** | **bool** | When true, the login AuthnRequest is signed with this access method&#39;s dedicated SP identity (Entity ID https://&lt;sp&gt;/saml/sp/{access_id} and ACS https://&lt;sp&gt;/saml/acs/{access_id}) instead of the shared global identity. Default false keeps the legacy global identity for backward compatibility. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

