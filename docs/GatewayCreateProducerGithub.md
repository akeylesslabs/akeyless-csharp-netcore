# akeyless.Model.GatewayCreateProducerGithub
gatewayCreateProducerGithub is a command that creates github producer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GithubAppId** | **long** | Github app id | [optional] 
**GithubAppPrivateKey** | **string** | App private key | [optional] 
**GithubBaseUrl** | **string** | Base URL | [optional] 
**InstallationId** | **long** | Github app installation id | [optional] 
**InstallationRepository** | **string** | Repository that the app installation has access to | [optional] 
**Name** | **string** | Producer name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**TokenPermissions** | **List&lt;string&gt;** | Optional - installation token&#39;s allowed permissions | [optional] 
**TokenRepositories** | **List&lt;string&gt;** | Optional - installation token&#39;s allowed repositories | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

