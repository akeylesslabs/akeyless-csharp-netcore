# akeyless.Model.DynamicSecretCreateGithub
dynamicSecretCreateGithub is a command that creates github dynamic secret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteProtection** | **string** | Protection from accidental deletion of this item [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**GithubAppId** | **long** | Github app id | [optional] 
**GithubAppPrivateKey** | **string** | App private key | [optional] 
**GithubBaseUrl** | **string** | Base URL | [optional] [default to "https://api.github.com/"]
**InstallationId** | **long** | Github app installation id | [optional] 
**InstallationOrganization** | **string** | Optional, instead of installation id, set a GitHub organization name | [optional] 
**InstallationRepository** | **string** | Optional, instead of installation id, set a GitHub repository &#39;&lt;owner&gt;/&lt;repo-name&gt; | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**TokenPermissions** | **List&lt;string&gt;** | Optional - installation token&#39;s allowed permissions | [optional] 
**TokenRepositories** | **List&lt;string&gt;** | Optional - installation token&#39;s allowed repositories | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

