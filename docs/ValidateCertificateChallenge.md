# akeyless.Model.ValidateCertificateChallenge
ValidateCertificateChallenge validates HTTP-01 challenge and finalizes certificate issuance (Phase 2)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Result** | [**ValidateCertificateChallengeOutput**](ValidateCertificateChallengeOutput.md) |  | [optional] 
**CertDisplayId** | **string** | Certificate display ID from Phase 1 | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Certificate name (alternative to cert-display-id) | [optional] 
**Timeout** | **long** | Validation timeout in seconds | [optional] [default to 120]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

