# akeyless.Model.Connect
Connect is a command that performs secure remote access

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Helper** | **Object** |  | [optional] 
**RcFileOverride** | **string** | used to override .akeyless-connect.rc in tests | [optional] 
**BastionCtrlPath** | **string** | Deprecated. use bastion-ctrl-path | [optional] 
**BastionCtrlPort** | **string** | Deprecated. use sra-ctrl-port | [optional] 
**BastionCtrlProto** | **string** | Deprecated. use sra-ctrl-proto | [optional] 
**BastionCtrlSubdomain** | **string** | Deprecated. use sra-ctrl-subdomain | [optional] 
**CertIssuerName** | **string** | The Akeyless certificate issuer name | [optional] 
**GatewayUrl** | **string** | The Gateway URL (configuration management) address, e.g. http://localhost:8000 | [optional] 
**IdentityFile** | **string** | The file from which the identity (private key) for public key authentication is read | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Justification** | **string** |  | [optional] 
**Name** | **string** | The Secret name (for database and AWS producers - producer name) | [optional] 
**SraCtrlPath** | **string** | The Bastion API path | [optional] 
**SraCtrlPort** | **string** | The Bastion API Port | [optional] [default to "9900"]
**SraCtrlProto** | **string** | The SRA API protocol | [optional] [default to "http"]
**SraCtrlSubdomain** | **string** | The SRA API prefix | [optional] 
**SshCommand** | **string** | Path to SSH executable. e.g. /usr/bin/ssh | [optional] 
**SshExtraArgs** | **string** | Additional SSH arguments (except -i) | [optional] 
**SshLegacySigningAlg** | **bool** | Set this option to output legacy (&#39;ssh-rsa-cert-v01@openssh.com&#39;) signing algorithm name in the ssh certificate. | [optional] [default to false]
**Target** | **string** | The target | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UseSshAgent** | **bool** | Enable ssh-agent | [optional] 
**ViaBastion** | **string** | Deprecated. Use via-sra | [optional] 
**ViaSra** | **string** | The jump box server | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

