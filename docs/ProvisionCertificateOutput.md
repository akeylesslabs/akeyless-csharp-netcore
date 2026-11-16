# akeyless.Model.ProvisionCertificateOutput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FailMessage** | **string** |  | [optional] 
**SuccessMessage** | **string** |  | [optional] 
**AssociationId** | **string** | AssociationID and TargetName identify the row of a Results entry. | [optional] 
**HostNames** | **List&lt;string&gt;** |  | [optional] 
**ProvisionedAt** | **DateTime** |  | [optional] 
**Results** | [**List&lt;ProvisionCertificateOutput&gt;**](ProvisionCertificateOutput.md) | Results holds one entry per row. It is set only when several rows were handled; the top-level fields then summarize them. | [optional] 
**TargetName** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

