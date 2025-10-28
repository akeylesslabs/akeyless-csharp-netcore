# akeyless.Model.GatewayCreateProducerAzure
gatewayCreateProducerAzure is a command that creates azure dynamic secret [Deprecated: Use dynamic-secret-create-azure command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppObjId** | **string** | Azure App Object Id | [optional] 
**AzureAdministrativeUnit** | **string** | Azure AD administrative unit (relevant only when azure-user-portal-access&#x3D;true) | [optional] 
**AzureClientId** | **string** | Azure Client ID | [optional] 
**AzureClientSecret** | **string** | Azure Client Secret | [optional] 
**AzureTenantId** | **string** | Azure Tenant ID | [optional] 
**CustomUsernameTemplate** | **string** | Customize how temporary usernames are generated using go template | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**FixedUserClaimKeyname** | **string** | FixedUserClaimKeyname | [optional] [default to "false"]
**FixedUserOnly** | **bool** | Fixed user | [optional] [default to false]
**ItemCustomFields** | **Dictionary&lt;string, string&gt;** | Additional custom fields to associate with the item | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic secret encryption key | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessUrl** | **string** | Destination URL to inject secrets | [optional] 
**SecureAccessWeb** | **bool** | Enable Web Secure Remote Access | [optional] [default to true]
**SecureAccessWebBrowsing** | **bool** | Secure browser via Akeyless&#39;s Secure Remote Access (SRA) | [optional] [default to false]
**SecureAccessWebProxy** | **bool** | Web-Proxy via Akeyless&#39;s Secure Remote Access (SRA) | [optional] [default to false]
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserGroupObjId** | **string** | User Group Object Id | [optional] 
**UserPortalAccess** | **bool** | Azure User portal access | [optional] [default to false]
**UserPrincipalName** | **string** | User Principal Name | [optional] 
**UserProgrammaticAccess** | **bool** | Azure User programmatic access | [optional] [default to false]
**UserRoleTemplateId** | **string** | User Role Template Id | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

