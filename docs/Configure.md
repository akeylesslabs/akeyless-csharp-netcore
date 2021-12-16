# akeyless.Model.Configure
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessId** | **string** | Access ID | [optional] 
**AccessKey** | **string** | Access Key | [optional] 
**AccessType** | **string** | Access Type (access_key/password/azure_ad/saml/oidc/ldap/aws_iam/gcp/k8s) | [optional] [default to "access_key"]
**AdminEmail** | **string** | Email (relevant only for access-type&#x3D;password) | [optional] 
**AdminPassword** | **string** | Password (relevant only for access-type&#x3D;password) | [optional] 
**AzureAdObjectId** | **string** | Azure Active Directory ObjectId (relevant only for access-type&#x3D;azure_ad) | [optional] 
**GcpAudience** | **string** | GCP JWT audience | [optional] 
**K8sAuthConfigName** | **string** | The K8S Auth config name (relevant only for access-type&#x3D;k8s) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

