# akeyless.Model.UscList
uscList is a command that lists the secrets of a Universal Secrets Connector

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GcpProjectId** | **string** | The GCP project to list secrets from (GCP only). Required when the connector spans multiple projects or uses folder/organization scope. | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**ObjectType** | **string** |  | [optional] 
**PageSize** | **long** | Optional: number of items requested per response. When set, response may include next_token | [optional] 
**PageToken** | **string** | Optional: continuation token returned by a previous usc list - -page-size call | [optional] 
**Search** | **string** | Search query used to match secret names and paths. | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UscName** | **string** | Name of the Universal Secrets Connector item | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

