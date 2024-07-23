# akeyless.Model.DynamicSecretUpdateGitlab
dynamicSecretUpdateGitlab is a command that updates gitlab dynamic secret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**GitlabAccessToken** | **string** | Gitlab access token | [optional] 
**GitlabAccessType** | **string** | Gitlab access token type [project,group] | 
**GitlabCertificate** | **string** | Gitlab tls certificate (base64 encoded) | [optional] 
**GitlabRole** | **string** | Gitlab role | [optional] 
**GitlabTokenScopes** | **string** | Comma-separated list of access token scopes to grant | 
**GitlabUrl** | **string** | Gitlab base url | [optional] [default to "https://gitlab.com/"]
**GroupName** | **string** | Gitlab group name, required for access-type&#x3D;group | [optional] 
**InstallationOrganization** | **string** | Gitlab project name, required for access-type&#x3D;project | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**NewName** | **string** | Dynamic secret new name | [optional] 
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Ttl** | **string** | Access Token TTL | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

