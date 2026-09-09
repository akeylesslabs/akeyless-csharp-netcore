# akeyless.Model.CustomerFragmentConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** |  | [optional] 
**FragmentType** | **string** |  | [optional] 
**Id** | **string** |  | [optional] 
**KeyLabel** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**Value** | **string** |  | [optional] 
**WrapAlg** | **string** | WrapAlg selects the HSM wrap algorithm for hsm_wrap_encrypt (e.g. rsa-oaep-sha256, aes-gcm, aes-cbc, aes-cbc-pad). RSA uses only WrapAlg; AES modes may require WrapIV and/or WrapTag. | [optional] 
**WrapIv** | **string** | WrapIV is the base64 IV for AES modes that require it (GCM/CBC). Empty for RSA and modes without IV metadata. | [optional] 
**WrapTag** | **string** | WrapTag is the base64 auth tag for AES-GCM only. Empty for RSA and other modes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

