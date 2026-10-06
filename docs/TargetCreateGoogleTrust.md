# akeyless.Model.TargetCreateGoogleTrust
targetCreateGoogleTrust is a command that creates a new Google Trust target

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcmeChallenge** | **string** | ACME challenge type. Options: [dns] | [optional] [default to "dns"]
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**DnsPropagationWait** | **string** | Fixed wait after TXT publish (e.g. 30s, 2m). If omitted with pre-check on, no extra sleep (polling only). If omitted with - -dns-skip-precheck, gateway uses 30s. DNS challenge only | [optional] 
**DnsResolvers** | **List&lt;string&gt;** | Custom DNS resolvers (ip:port) for DNS-01. Repeat for multiple. If omitted, Lego uses /etc/resolv.conf or Google Public DNS. DNS challenge only | [optional] 
**DnsSkipPrecheck** | **bool** | Skip DNS TXT pre-check before CA validation. If - -dns-propagation-wait is omitted and this flag is set, gateway waits 30s before CA validation. DNS challenge only | [optional] 
**DnsTargetCreds** | **string** | Name of existing cloud target for DNS credentials. Required when challenge type is dns. Supported providers: AWS, Azure, GCP, Cloudflare | [optional] 
**DnsTimeout** | **string** | Per-query DNS lookup timeout during pre-check (e.g. 10s), not total poll time. If omitted with pre-check on, Lego library default applies (10s per query on Linux). Ignored when - -dns-skip-precheck is set. DNS challenge only | [optional] 
**DnsZone** | **string** | Cloudflare DNS zone identifier. Required when DNS credentials target is Cloudflare | [optional] 
**EabHmacKey** | **string** | External Account Binding HMAC key (required for ACME account bootstrap on create) | [optional] 
**EabKeyId** | **string** | External Account Binding key identifier (required for ACME account bootstrap on create) | [optional] 
**Email** | **string** | Email address for ACME account registration | 
**GcpProject** | **string** | GCP Cloud DNS project ID. Optional and can be derived from service account | [optional] 
**GoogleTrustUrl** | **string** | Google Trust directory environment. Options: [production/staging] | [optional] [default to "production"]
**HostedZone** | **string** | AWS Route53 hosted zone ID. Required when DNS credentials target is AWS | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**LockOnRead** | **string** | Lock this secret after each successful value read | [optional] 
**LockTtl** | **string** | Lock TTL in minutes | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Target name | 
**ResourceGroup** | **string** | Azure resource group name. Required when DNS credentials target is Azure | [optional] 
**RotateOnUnlock** | **string** | Rotate this secret after it is unlocked | [optional] 
**Timeout** | **string** | Timeout for challenge validation | [optional] [default to "5m"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

