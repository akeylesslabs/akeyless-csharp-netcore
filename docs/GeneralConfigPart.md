# akeyless.Model.GeneralConfigPart

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AkeylessUrl** | **string** | AkeylessUrl is here for BC only. Gator will still return it if it exists in the configuration, but new clients (&gt;&#x3D;2.34.0) will ignore it and override it with what exists in their local file. It will no longer be sent to Gator for update, so new clusters will only have the default value saved in the DB. | [optional] 
**ApiTokenTtl** | **string** |  | [optional] 
**DisplayName** | **string** |  | [optional] 
**EnableSniProxy** | **bool** |  | [optional] 
**EnableTls** | **bool** |  | [optional] 
**EnableTlsConfigure** | **bool** |  | [optional] 
**EnableTlsCurl** | **bool** |  | [optional] 
**EnableTlsHvp** | **bool** |  | [optional] 
**GwClusterUrl** | **string** |  | [optional] 
**NotifyOnStatusChange** | **bool** |  | [optional] 
**TcpPort** | **string** |  | [optional] 
**TlsCert** | **string** |  | [optional] 
**TlsKey** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

