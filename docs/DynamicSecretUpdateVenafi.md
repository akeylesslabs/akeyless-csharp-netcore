# akeyless.Model.DynamicSecretUpdateVenafi
dynamicSecretUpdateVenafi is a command that updates a Venafi dynamic secret to dynamically update certificates generated by Venafi or have Akeyless generated certificates using PKI be monitored by Venafi

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminRotationIntervalDays** | **long** | Admin credentials rotation interval (days) | [optional] [default to 0]
**AllowSubdomains** | **bool** | Allow subdomains | [optional] 
**AllowedDomains** | **List&lt;string&gt;** | Allowed domains | [optional] 
**AutoGeneratedFolder** | **string** | Auto generated folder | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**EnableAdminRotation** | **bool** | Automatic admin credentials rotation | [optional] [default to false]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**NewName** | **string** | Dynamic secret name | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**RootFirstInChain** | **bool** | Root first in chain | [optional] 
**SignUsingAkeylessPki** | **bool** | Use Akeyless PKI issuer or Venafi issuer | [optional] 
**SignerKeyName** | **string** | Signer key name | [optional] 
**StorePrivateKey** | **bool** | Store private key | [optional] 
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL in time.Duration format (2160h / 129600m / etc...). When using sign-using-akeyless-pki certificates created will have this validity period, otherwise the user-ttl is taken from the Validity Period field of the Zone&#39;s&#39; Issuing Template. When using cert-manager it is advised to have a TTL of above 60 days (1440h). For more information - https://cert-manager.io/docs/usage/certificate/ | [optional] [default to "2160h"]
**VenafiAccessToken** | **string** | Venafi Access Token to use to access the TPP environment (Relevant when using TPP) | [optional] 
**VenafiApiKey** | **string** | Venafi API key | [optional] 
**VenafiBaseurl** | **string** | Venafi Baseurl | [optional] 
**VenafiClientId** | **string** | Venafi Client ID that was used when the access token was generated | [optional] [default to "akeyless"]
**VenafiRefreshToken** | **string** | Venafi Refresh Token to use when the Access Token is expired (Relevant when using TPP) | [optional] 
**VenafiUseTpp** | **bool** | Venafi using TPP | [optional] 
**VenafiZone** | **string** | Venafi Zone | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

