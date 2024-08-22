# akeyless.Model.TargetUpdateSectigo
targetUpdateSectigo is a command that updates an existing Sectigo target

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CertificateProfileId** | **long** | Certificate Profile ID in Sectigo account | 
**CustomerUri** | **string** | Customer Uri of the Sectigo account | 
**Description** | **string** | Description of the object | [optional] 
**ExternalRequester** | **string** | External Requester - a comma separated list of emails | 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Target name | 
**NewName** | **string** | New target name | [optional] 
**OrganizationId** | **long** | Organization ID in Sectigo account | 
**Password** | **string** | Password of the Sectigo account user | 
**Timeout** | **string** | Timeout waiting for certificate validation in Duration format (1h - 1 Hour, 20m - 20 Minutes, 33m3s - 33 Minutes and 3 Seconds), maximum 1h. | [optional] [default to "5m"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | Username of the Sectigo account | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

