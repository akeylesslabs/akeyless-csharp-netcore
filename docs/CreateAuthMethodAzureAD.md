# akeyless.Model.CreateAuthMethodAzureAD
createAuthMethodAzureAD is a command that creates a new auth method that will be able to authenticate using Azure Active Directory credentials.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessExpires** | **long** | Access expiration date in Unix timestamp (select 0 for access without expiry date) | [optional] [default to 0]
**Audience** | **string** | The audience in the JWT | [optional] [default to "https://management.azure.com/"]
**BoundGroupId** | **List&lt;string&gt;** | A list of group ids that the access is restricted to | [optional] 
**BoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the IPs that the access is restricted to | [optional] 
**BoundProviders** | **List&lt;string&gt;** | A list of resource providers that the access is restricted to (e.g, Microsoft.Compute, Microsoft.ManagedIdentity, etc) | [optional] 
**BoundResourceId** | **List&lt;string&gt;** | A list of full resource ids that the access is restricted to | [optional] 
**BoundResourceNames** | **List&lt;string&gt;** | A list of resource names that the access is restricted to (e.g, a virtual machine name, scale set name, etc). | [optional] 
**BoundResourceTypes** | **List&lt;string&gt;** | A list of resource types that the access is restricted to (e.g, virtualMachines, userAssignedIdentities, etc) | [optional] 
**BoundRgId** | **List&lt;string&gt;** | A list of resource groups that the access is restricted to | [optional] 
**BoundSpid** | **List&lt;string&gt;** | A list of service principal IDs that the access is restricted to | [optional] 
**BoundSubId** | **List&lt;string&gt;** | A list of subscription ids that the access is restricted to | [optional] 
**BoundTenantId** | **string** | The Azure tenant id that the access is restricted to | 
**ForceSubClaims** | **bool** | if true: enforce role-association must include sub claims | [optional] 
**Issuer** | **string** | Issuer URL | [optional] [default to "https://sts.windows.net/---bound_tenant_id---"]
**JwksUri** | **string** | The URL to the JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server. | [optional] [default to "https://login.microsoftonline.com/common/discovery/keys"]
**Name** | **string** | Auth Method name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

