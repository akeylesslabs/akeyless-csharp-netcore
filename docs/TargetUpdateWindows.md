# akeyless.Model.TargetUpdateWindows
GatewayUpdateProducerWindowsCmd is a command that updates an existing windows target

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Certificate** | **string** | SSL CA certificate in base64 encoding generated from a trusted Certificate Authority (CA) | [optional] 
**ConnectionType** | **string** | Type of connection to Windows Server [credentials/parent-target] | [optional] [default to "credentials"]
**Description** | **string** | Description of the object | [optional] 
**Domain** | **string** | User domain name | [optional] 
**Hostname** | **string** | Server hostname | 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Target name | 
**NewName** | **string** | New target name | [optional] 
**ParentTargetName** | **string** | Name of the parent target, relevant only when connection-type is parent-target | [optional] 
**Password** | **string** | Privileged user password | [default to "dummy_value"]
**Port** | **string** | Server WinRM port | [optional] [default to "5986"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UseTls** | **string** | Enable/Disable TLS for WinRM over HTTPS [true/false] | [optional] [default to "true"]
**Username** | **string** | Privileged username | [default to "dummy_value"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

