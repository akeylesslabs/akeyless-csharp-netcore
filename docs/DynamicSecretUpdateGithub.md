# akeyless.Model.DynamicSecretUpdateGithub
dynamicSecretUpdateGithub is a command that updates github dynamic secret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**GithubAppId** | **long** | Github app id | [optional] 
**GithubAppPrivateKey** | **string** | App private key | [optional] 
**GithubBaseUrl** | **string** | Base URL | [optional] [default to "https://api.github.com/"]
**InstallationId** | **long** | GitHub application installation id | [optional] 
**InstallationOrganization** | **string** | Optional, mutually exclusive with installation id, GitHub organization name | [optional] 
**InstallationRepository** | **string** | Optional, mutually exclusive with installation id, GitHub repository &#39;&lt;owner&gt;/&lt;repo-name&gt;&#39; | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**NewName** | **string** | Dynamic secret name | [optional] 
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**TokenPermissions** | **List&lt;string&gt;** | Optional - installation token&#39;s allowed permissions | [optional] 
**TokenRepositories** | **List&lt;string&gt;** | Optional - installation token&#39;s allowed repositories | [optional] 
**TokenTtl** | **string** | Token TTL | [optional] [default to "60m"]
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

