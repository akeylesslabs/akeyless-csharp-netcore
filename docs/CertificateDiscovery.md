# akeyless.Model.CertificateDiscovery
CertificateDiscovery is a command that discovery certificates

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Debug** | **bool** | Debug mode | [optional] [default to false]
**ExpirationEventIn** | **List&lt;string&gt;** | How many days before the expiration of the certificate would you like to be notified. | [optional] 
**Hosts** | **string** | A comma separated list of IPs, CIDR ranges, or DNS names to discovery | 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**PortRanges** | **string** | A comma separated list of port ranges Examples: \&quot;80,443\&quot; or \&quot;80,443,8080-8090\&quot; or \&quot;443\&quot; | [optional] [default to "443"]
**ProtectionKey** | **string** | The name of the key that protects the certificate value | [optional] 
**TargetLocation** | **string** | The folder where the results will be saved | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

