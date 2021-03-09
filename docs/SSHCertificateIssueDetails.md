# akeyless.Model.SSHCertificateIssueDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedDomains** | **List&lt;string&gt;** | Relevant for host certificate | [optional] 
**AllowedUserKeyLengths** | **Dictionary&lt;string, long&gt;** |  | [optional] 
**AllowedUsers** | **List&lt;string&gt;** | Relevant for user certificate | [optional] 
**CertType** | **int** |  | [optional] 
**CriticalOptions** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Extensions** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Principals** | **List&lt;string&gt;** |  | [optional] 
**StaticKeyId** | **string** | In case it is empty, the key ID will be combination of user identifiers and a random string | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

