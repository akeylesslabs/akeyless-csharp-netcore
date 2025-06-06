# akeyless.Model.TargetCreateGke

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Description of the object | [optional] 
**GkeAccountKey** | **string** | GKE Service Account key file path | [optional] 
**GkeClusterCert** | **string** | GKE cluster CA certificate | [optional] 
**GkeClusterEndpoint** | **string** | GKE cluster URL endpoint | [optional] 
**GkeClusterName** | **string** | GKE cluster name | [optional] 
**GkeServiceAccountEmail** | **string** | GKE service account email | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Target name | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UseGwCloudIdentity** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

