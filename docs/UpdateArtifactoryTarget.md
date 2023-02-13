# akeyless.Model.UpdateArtifactoryTarget

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArtifactoryAdminName** | **string** | Artifactory Admin Name | 
**ArtifactoryAdminPwd** | **string** | Artifactory Admin password | 
**BaseUrl** | **string** | Base URL | 
**Comment** | **string** | Deprecated - use description | [optional] 
**Description** | **string** | Description of the object | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Name** | **string** | Target name | 
**NewName** | **string** | New target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UpdateVersion** | **bool** | Deprecated | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

