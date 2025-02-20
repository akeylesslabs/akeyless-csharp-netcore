# akeyless.Model.DynamicSecretCreateRdp
dynamicSecretCreateRdp is a command that creates rdp dynamic secret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowUserExtendSession** | **long** | AllowUserExtendSession | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**FixedUserClaimKeyname** | **string** | For externally provided users, denotes the key-name of IdP claim to extract the username from (relevant only for fixed-user-only&#x3D;true) | [optional] [default to "ext_username"]
**FixedUserOnly** | **string** | Allow access using externally (IdP) provided username [true/false] | [optional] [default to "false"]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**RdpAdminName** | **string** | RDP Admin Name | [optional] 
**RdpAdminPwd** | **string** | RDP Admin password | [optional] 
**RdpHostName** | **string** | Hostname | [optional] 
**RdpHostPort** | **string** | Port | [optional] [default to "22"]
**RdpUserGroups** | **string** | Groups | [optional] 
**SecureAccessAllowExternalUser** | **bool** | Allow providing external user for a domain users | [optional] [default to false]
**SecureAccessDelay** | **long** | The delay duration, in seconds, to wait after generating just-in-time credentials. Accepted range: 0-120 seconds | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** | Target servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts - Relevant only for Dynamic Secrets/producers) | [optional] 
**SecureAccessRdGatewayServer** | **string** | RD Gateway server | [optional] 
**SecureAccessRdpDomain** | **string** | Required when the Dynamic Secret is used for a domain user | [optional] 
**SecureAccessRdpUser** | **string** | Override the RDP Domain username | [optional] 
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]
**WarnUserBeforeExpiration** | **long** | WarnBeforeUserExpiration | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

