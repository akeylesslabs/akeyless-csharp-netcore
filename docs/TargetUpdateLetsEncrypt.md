# akeyless.Model.TargetUpdateLetsEncrypt
targetUpdateLetsEncrypt is a command that updates an existing Let's Encrypt target

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcmeChallenge** | **string** |  | [optional] [default to "http"]
**Description** | **string** | Description of the object | [optional] 
**DnsTargetCreds** | **string** | Name of existing cloud target for DNS credentials. Required when acme-challenge&#x3D;dns. Supported: AWS, Azure, GCP targets | [optional] 
**Email** | **string** | Email address for ACME account registration | 
**GcpProject** | **string** | GCP Cloud DNS: Project ID. Optional - can be derived from service account | [optional] 
**HostedZone** | **string** | AWS Route53 hosted zone ID. Required when dns-target-creds points to AWS target | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**LetsEncryptUrl** | **string** |  | [optional] [default to "production"]
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Target name | 
**NewName** | **string** | New target name | [optional] 
**ResourceGroup** | **string** | Azure resource group name. Required when dns-target-creds points to Azure target | [optional] 
**Timeout** | **string** |  | [optional] [default to "5m"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

