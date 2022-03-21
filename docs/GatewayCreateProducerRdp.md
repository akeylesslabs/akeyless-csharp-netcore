# akeyless.Model.GatewayCreateProducerRdp
gatewayCreateProducerRdp is a command that creates rdp producer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FixedUserOnly** | **string** | Fixed user | [optional] [default to "false"]
**Name** | **string** | Producer name | 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**RdpAdminName** | **string** | RDP Admin Name | [optional] 
**RdpAdminPwd** | **string** | RDP Admin password | [optional] 
**RdpHostName** | **string** | Hostname | [optional] 
**RdpHostPort** | **string** | Port | [optional] [default to "22"]
**RdpUserGroups** | **string** | Groups | [optional] 
**SecureAccessAllowExternalUser** | **bool** |  | [optional] 
**SecureAccessEnable** | **string** |  | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** |  | [optional] 
**SecureAccessRdpDomain** | **string** |  | [optional] 
**SecureAccessRdpUser** | **string** |  | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

