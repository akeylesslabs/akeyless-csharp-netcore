# akeyless.Model.TargetCreateDigiCert
targetCreateDigiCert is a command that creates a new DigiCert target

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcmeChallenge** | **string** | ACME challenge type. Options: [dns] | [optional] [default to "dns"]
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**DigicertUrl** | **string** | DigiCert ACME endpoint selector. Options: [us-production/eu-production/us-demo/eu-demo] | [optional] [default to "us-production"]
**DnsTargetCreds** | **string** | Name of existing cloud target for DNS credentials. Required when challenge type is dns. Supported providers: AWS, Azure, GCP | [optional] 
**EabHmacKey** | **string** | External Account Binding HMAC key (required for ACME account bootstrap on create) | [optional] 
**EabKeyId** | **string** | External Account Binding key identifier (required for ACME account bootstrap on create) | [optional] 
**Email** | **string** | Email address for ACME account registration | 
**GcpProject** | **string** | GCP Cloud DNS project ID. Optional and can be derived from service account | [optional] 
**HostedZone** | **string** | AWS Route53 hosted zone ID. Required when DNS credentials target is AWS | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Target name | 
**ResourceGroup** | **string** | Azure resource group name. Required when DNS credentials target is Azure | [optional] 
**Timeout** | **string** | Timeout for challenge validation | [optional] [default to "5m"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

