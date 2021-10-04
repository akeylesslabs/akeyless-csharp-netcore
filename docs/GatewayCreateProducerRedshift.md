# akeyless.Model.GatewayCreateProducerRedshift
gatewayCreateProducerRedshift is a command that creates redshift producer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreationStatements** | **string** | Redshift Creation statements | [optional] 
**Name** | **string** | Producer name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**ProducerEncryptionKey** | **string** | Dynamic producer encryption key | [optional] 
**RedshiftDbName** | **string** | Redshift DB Name | [optional] 
**RedshiftHost** | **string** | Redshift Host | [optional] [default to "127.0.0.1"]
**RedshiftPassword** | **string** | Redshift Password | [optional] 
**RedshiftPort** | **string** | Redshift Port | [optional] [default to "5439"]
**RedshiftUsername** | **string** | Redshift Username | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

