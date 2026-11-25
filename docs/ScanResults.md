# akeyless.Model.ScanResults
ScanResults contains detailed results from a certificate scan

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CountExisting** | **long** |  | [optional] 
**CountFailed** | **long** |  | [optional] 
**CountHosts** | **long** |  | [optional] 
**CountNew** | **long** |  | [optional] 
**CountSubdomains** | **long** |  | [optional] 
**DomainCoverage** | [**List&lt;DomainCoverage&gt;**](DomainCoverage.md) | DomainCoverage says, per public domain, how much of it subdomain discovery managed to cover. Clients that predate it ignore it, and a scan with no public domain omits it. | [optional] 
**Error** | **string** |  | [optional] 
**FailedTargets** | [**List&lt;TargetError&gt;**](TargetError.md) |  | [optional] 
**ItemNames** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

