# akeyless.Model.AzureADAccessRules
AzureADAccessRules contains access rules specific to Azure Active Directory authentication.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdEndpoint** | **string** | The audience in the JWT. | [optional] 
**BoundGroupIds** | **List&lt;string&gt;** | The list of group ids that login is restricted to. | [optional] 
**BoundResourceGroups** | **List&lt;string&gt;** | The list of resource groups that login is restricted to. | [optional] 
**BoundResourceIds** | **List&lt;string&gt;** | The list of full resource ids that the login is restricted to. | [optional] 
**BoundResourceNames** | **List&lt;string&gt;** | The list of resource names that the login is restricted to (e.g, a virtual machine name, scale set name, etc). | [optional] 
**BoundResourceProviders** | **List&lt;string&gt;** | The list of resource providers that login is restricted to (e.g, Microsoft.Compute, Microsoft.ManagedIdentity, etc). | [optional] 
**BoundResourceTypes** | **List&lt;string&gt;** | The list of resource types that login is restricted to  (e.g, virtualMachines, userAssignedIdentities, etc). | [optional] 
**BoundServicePrincipalIds** | **List&lt;string&gt;** | The list of service principal IDs that login is restricted to. | [optional] 
**BoundSubscriptionIds** | **List&lt;string&gt;** | The list of subscription IDs that login is restricted to. | [optional] 
**BoundTenantId** | **string** | The tenants id for the Azure Active Directory organization. | [optional] 
**Issuer** | **string** | Issuer URL | [optional] 
**JwksUri** | **string** | The URL to the JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server. | [optional] 
**UniqueIdentifier** | **string** | A unique identifier to distinguish different users | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

