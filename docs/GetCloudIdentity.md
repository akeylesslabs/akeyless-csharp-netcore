# akeyless.Model.GetCloudIdentity
getCloudIdentity is a command that gets Cloud Identity Token (relevant only for access-type=azure_ad, aws_iam, gcp).
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AzureAdObjectId** | **string** | Azure Active Directory ObjectId (relevant only for access-type&#x3D;azure_ad) | [optional] 
**GcpAudience** | **string** | GCP JWT audience | [optional] 
**UrlSafe** | **bool** | Escapes the token so it can be safely placed inside a URL query | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

