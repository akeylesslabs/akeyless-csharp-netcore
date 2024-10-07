# akeyless.Model.UpdateItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProviderType** | **string** |  | [optional] 
**Accessibility** | **string** | for personal password manager | [optional] [default to "regular"]
**AddTag** | **List&lt;string&gt;** | List of the new tags that will be attached to this item | [optional] 
**CertFileData** | **string** | PEM Certificate in a Base64 format. Used for updating RSA keys&#39; certificates. | [optional] 
**CertificateFormat** | **string** |  | [optional] 
**ChangeEvent** | **string** | Trigger an event when a secret value changed [true/false] (Relevant only for Static Secret) | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] [default to "default_metadata"]
**ExpirationEventIn** | **List&lt;string&gt;** | How many days before the expiration of the certificate would you like to be notified. | [optional] 
**HostProvider** | **string** | Host provider type [explicit/target], Default Host provider is explicit, Relevant only for Secure Remote Access of ssh cert issuer, ldap rotated secret and ldap dynamic secret | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Current item name | 
**NewMetadata** | **string** | Deprecated - use description | [optional] [default to "default_metadata"]
**NewName** | **string** | New item name | [optional] 
**RmTag** | **List&lt;string&gt;** | List of the existent tags that will be removed from this item | [optional] 
**RotateAfterDisconnect** | **string** | Rotate the value of the secret after SRA session ends [true/false] | [optional] [default to "false"]
**SecureAccessAddHost** | **List&lt;string&gt;** | List of the new hosts that will be attached to SRA servers host | [optional] 
**SecureAccessAllowExternalUser** | **string** | Allow providing external user for a domain users [true/false] | [optional] 
**SecureAccessAllowPortForwading** | **bool** | Enable Port forwarding while using CLI access (relevant only for EKS/GKE/K8s Dynamic-Secret) | [optional] 
**SecureAccessAwsAccountId** | **string** | The AWS account id (relevant only for aws) | [optional] 
**SecureAccessAwsNativeCli** | **bool** | The AWS native cli (relevant only for aws) | [optional] 
**SecureAccessAwsRegion** | **string** | The AWS region (relevant only for aws) | [optional] 
**SecureAccessBastionApi** | **string** | Bastion&#39;s SSH control API endpoint. E.g. https://my.bastion:9900 (relevant only for ssh cert issuer) | [optional] 
**SecureAccessBastionIssuer** | **string** | Path to the SSH Certificate Issuer for your Akeyless Bastion | [optional] 
**SecureAccessBastionSsh** | **string** | Bastion&#39;s SSH server. E.g. my.bastion:22 (relevant only for ssh cert issuer) | [optional] 
**SecureAccessClusterEndpoint** | **string** | The K8s cluster endpoint URL (relevant only for EKS/GKE/K8s Dynamic-Secret) | [optional] 
**SecureAccessDashboardUrl** | **string** | The K8s dashboard url (relevant only for k8s) | [optional] 
**SecureAccessDbName** | **string** | The DB name (relevant only for DB Dynamic-Secret) | [optional] 
**SecureAccessDbSchema** | **string** | The DB schema (relevant only for DB Dynamic-Secret) | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** | Target servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts - Relevant only for Dynamic Secrets/producers) | [optional] 
**SecureAccessRdGatewayServer** | **string** | RD Gateway server (relevant only for rdp) | [optional] 
**SecureAccessRdpDomain** | **string** | Required when the Dynamic Secret is used for a domain user (relevant only for RDP Dynamic-Secret) | [optional] 
**SecureAccessRdpUser** | **string** | Override the RDP Domain username | [optional] 
**SecureAccessRmHost** | **List&lt;string&gt;** | List of the existent hosts that will be removed from SRA servers host | [optional] 
**SecureAccessSshCreds** | **string** | Secret values contains SSH Credentials, either Private Key or Password [password/private-key] (relevant only for Static-Secret or Rotated-secret) | [optional] 
**SecureAccessSshCredsUser** | **string** | SSH username to connect to target server, must be in &#39;Allowed Users&#39; list (relevant only for ssh cert issuer) | [optional] 
**SecureAccessUrl** | **string** | Destination URL to inject secrets | [optional] 
**SecureAccessUseInternalBastion** | **bool** | Use internal SSH Bastion | [optional] 
**SecureAccessWebBrowsing** | **bool** | Secure browser via Akeyless Web Access Bastion | [optional] [default to false]
**SecureAccessWebProxy** | **bool** | Web-Proxy via Akeyless Web Access Bastion | [optional] [default to false]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

