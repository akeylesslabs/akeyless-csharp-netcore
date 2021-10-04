# akeyless.Model.GatewayCreateProducerAzure
gatewayCreateProducerAzure is a command that creates azure producer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppObjId** | **string** | Azure App Object Id | [optional] 
**AzureClientId** | **string** | Azure Client ID | [optional] 
**AzureClientSecret** | **string** | Azure Client Secret | [optional] 
**AzureTenantId** | **string** | Azure Tenant ID | [optional] 
**Name** | **string** | Producer name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**SecureAccessEnable** | **string** |  | [optional] 
**SecureAccessWeb** | **bool** |  | [optional] 
**SecureAccessWebBrowsing** | **bool** |  | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserGroupObjId** | **string** | User Group Object Id | [optional] 
**UserPortalAccess** | **bool** | Azure User portal access | [optional] [default to false]
**UserPrincipalName** | **string** | User Principal Name | [optional] 
**UserProgrammaticAccess** | **bool** | Azure User programmatic access | [optional] [default to true]
**UserRoleTemplateId** | **string** | User Role Template Id | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

