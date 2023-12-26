# akeyless.Model.UscGet
uscGet is a command that gets the value and internal details of a secret from a Universal Secrets Connector

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**SecretId** | **string** | The secret id (or name, for AWS, Azure or K8s targets) to get from the Universal Secrets Connector | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UscName** | **string** | Name of the Universal Secrets Connector item | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

