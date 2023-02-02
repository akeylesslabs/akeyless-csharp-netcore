# akeyless.Model.UpdateItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accessibility** | **string** | for personal password manager | [optional] [default to "regular"]
**AddTag** | **List&lt;string&gt;** | List of the new tags that will be attached to this item | [optional] 
**CertFileData** | **string** | PEM Certificate in a Base64 format. Used for updating RSA keys&#39; certificates. | [optional] 
**DeleteProtection** | **string** |  | [optional] 
**Description** | **string** | Description of the object | [optional] [default to "default_metadata"]
**Json** | **bool** | Set output format to JSON | [optional] 
**Name** | **string** | Current item name | 
**NewMetadata** | **string** | Deprecated - use description | [optional] [default to "default_metadata"]
**NewName** | **string** | New item name | [optional] 
**RmTag** | **List&lt;string&gt;** | List of the existent tags that will be removed from this item | [optional] 
**RotateAfterDisconnect** | **string** | Rotate the value of the secret after SRA session ends | [optional] [default to "false"]
**SecureAccessAddHost** | **List&lt;string&gt;** |  | [optional] 
**SecureAccessAllowExternalUser** | **string** |  | [optional] 
**SecureAccessAllowPortForwading** | **bool** |  | [optional] 
**SecureAccessAwsAccountId** | **string** |  | [optional] 
**SecureAccessAwsNativeCli** | **bool** |  | [optional] 
**SecureAccessAwsRegion** | **string** |  | [optional] 
**SecureAccessBastionApi** | **string** |  | [optional] 
**SecureAccessBastionIssuer** | **string** |  | [optional] 
**SecureAccessBastionSsh** | **string** |  | [optional] 
**SecureAccessClusterEndpoint** | **string** |  | [optional] 
**SecureAccessDashboardUrl** | **string** |  | [optional] 
**SecureAccessDbName** | **string** |  | [optional] 
**SecureAccessDbSchema** | **string** |  | [optional] 
**SecureAccessEnable** | **string** |  | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** |  | [optional] 
**SecureAccessRdpDomain** | **string** |  | [optional] 
**SecureAccessRdpUser** | **string** |  | [optional] 
**SecureAccessRmHost** | **List&lt;string&gt;** |  | [optional] 
**SecureAccessSshCreds** | **string** |  | [optional] 
**SecureAccessSshCredsUser** | **string** |  | [optional] 
**SecureAccessUrl** | **string** |  | [optional] 
**SecureAccessUseInternalBastion** | **bool** |  | [optional] 
**SecureAccessWebBrowsing** | **bool** |  | [optional] 
**SecureAccessWebProxy** | **bool** |  | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

