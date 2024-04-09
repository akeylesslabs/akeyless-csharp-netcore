# akeyless.Model.RevokeCertificate
RevokeCertificate is a command that revokes a certificate and adds it to the crl

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemId** | **long** | The item id of the certificate to revoke | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Certificate item name to revoke | [optional] 
**SerialNumber** | **string** | The serial number of the certificate to revoke | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**_Version** | **int** | Certificate version to revoke. Required if item-id or name are used. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

