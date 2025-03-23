# akeyless.Model.UpdateAzureTarget
updateAzureTarget is a command that updates an existing target. [Deprecated: Use target-update-azure command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | Azure client/application id | [optional] 
**ClientSecret** | **string** | Azure client secret | [optional] 
**Comment** | **string** | Deprecated - use description | [optional] 
**ConnectionType** | **string** | Type of connection [credentials/cloud-identity] | [optional] [default to "credentials"]
**Description** | **string** | Description of the object | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Target name | 
**NewName** | **string** | New target name | [optional] 
**ResourceGroupName** | **string** | The Resource Group name in your Azure subscription | [optional] 
**ResourceName** | **string** | The name of the relevant Resource | [optional] 
**SubscriptionId** | **string** | Azure Subscription Id | [optional] 
**TenantId** | **string** | Azure tenant id | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UpdateVersion** | **bool** | Deprecated | [optional] 
**UseGwCloudIdentity** | **bool** | Use the GW&#39;s Cloud IAM [Deprecated: Use connection-type&#x3D;cloud-identity] | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

