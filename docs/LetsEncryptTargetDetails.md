# akeyless.Model.LetsEncryptTargetDetails
LetsEncryptTargetDetails defines configuration for Let's Encrypt ACME target

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountKeyPem** | **string** | ACME Account Private Key (PEM-encoded) Supports ECDSA (P-256, P-384, P-521), RSA (2048+), and Ed25519 Auto-generated as ECDSA P-256 on first certificate issuance if not provided Stored encrypted, required for certificate operations and revocation | [optional] 
**AccountUrl** | **string** | ACME Account URL (returned after registration with Let&#39;s Encrypt) Used to retrieve existing account instead of re-registering | [optional] 
**AcmeEnvironment** | **string** | ACMEEnvironment defines Let&#39;s Encrypt ACME directory environment | [optional] 
**ChallengeType** | **string** | ACMEChallengeType defines ACME challenge type for Let&#39;s Encrypt | [optional] 
**DnsTargetName** | **string** | Name of DNS target (transient field - not stored in DB) Used by CLI to pass DNS target name to SDK for creating target_object_assoc Retrieved from target_object_assoc when reading target Required when ChallengeType is \&quot;dns\&quot; | [optional] 
**DnsTargetType** | **string** |  | [optional] 
**Email** | **string** | Email address for ACME account registration Required | [optional] 
**GcpProject** | **string** | GCP Cloud DNS: Project ID Optional - can be derived from service account | [optional] 
**HostedZone** | **string** | AWS Route53: Hosted zone ID Required when DNSTargetType is AWS | [optional] 
**ResourceGroup** | **string** | Azure DNS: Resource group name Required when DNSTargetType is Azure | [optional] 
**Timeout** | **long** | A Duration represents the elapsed time between two instants as an int64 nanosecond count. The representation limits the largest representable duration to approximately 290 years. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

