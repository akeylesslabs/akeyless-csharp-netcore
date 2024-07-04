# akeyless.Model.CreatePingTarget
createPingTarget is a command that creates a new target. [Deprecated: Use target-create-ping command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdministrativePort** | **string** | Ping Federate administrative port | [optional] [default to "9999"]
**AuthorizationPort** | **string** | Ping Federate authorization port | [optional] [default to "9031"]
**Comment** | **string** | Deprecated - use description | [optional] 
**Description** | **string** | Description of the object | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Target name | 
**Password** | **string** | Ping Federate privileged user password | [optional] 
**PingUrl** | **string** | Ping URL | [optional] 
**PrivilegedUser** | **string** | Ping Federate privileged user | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

