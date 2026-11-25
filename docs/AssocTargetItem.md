# akeyless.Model.AssocTargetItem
assocTargetItem is a command that creates an association between target and item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BindSslProfiles** | **List&lt;string&gt;** | Bind the provisioned certificate to an existing client-ssl/server-ssl profile, in the format &lt;type&gt;:&lt;partition&gt;:&lt;name&gt; (relevant only for F5 BIG-IP certificate provisioning). Leave the partition empty to use the certificate&#39;s partition. For a profile in a folder, add the folder to the partition, for example client-ssl:Common/Shared:my-profile. Repeat the parameter to bind several profiles. | [optional] 
**CertificateArn** | **string** | The ARN of an existing imported ACM certificate to re-import into, which replaces its certificate and key; if empty, a new ACM certificate is created on every provisioning, including after renewal (relevant only for AWS certificate provisioning) | [optional] 
**CertificateFormat** | **string** | The format the certificate will be provisioned with, available options: pem,pfx,jks (jks uses - -jks-password); pfx requires gateway version 5.5.0 or higher, and jks and pfx for Azure Key Vault require 5.8.0 or higher, or the association is rejected (relevant only for certificate provisioning) | [optional] [default to "pem"]
**CertificateName** | **string** | The name of the certificate object in the cloud provider (relevant only for AWS, Azure, and GCP certificate provisioning) | [optional] 
**CertificatePath** | **string** | A path on the target to store the certificate pem file (relevant only for certificate provisioning) | [optional] 
**ChainPath** | **string** | A path on the target to store the full chain pem file (relevant only for certificate provisioning) | [optional] 
**DisablePreviousKeyVersion** | **bool** | Automatically disable previous key version (required for azure targets) | [optional] [default to false]
**ExternalKeyName** | **string** | The external key name to associate with the classic key (Relevant only for Classic Key AWS/Azure/GCP targets) | [optional] 
**F5SaveConfig** | **bool** | Save the F5 running configuration after each successful provisioning, so the certificate survives a reboot. This also saves any other unsaved change on the device (relevant only for F5 BIG-IP certificate provisioning) | [optional] [default to false]
**F5SyncDeviceGroup** | **string** | Sync the F5 configuration to this device group after each successful provisioning, so the HA peer serves the same certificate. This overwrites unsynced changes on the other members of the group. Implies f5-save-config (relevant only for F5 BIG-IP certificate provisioning) | [optional] 
**IisBindingHostname** | **string** | The optional host name of the IIS binding, which enables SNI for a binding that is created (requires gateway version 5.8.0 or higher, or the association is rejected; relevant only for Windows certificate provisioning, requires - -certificate-format pfx and a - -certificate-path of the form Cert:\\LocalMachine\\&lt;store&gt;, for example Cert:\\LocalMachine\\My) | [optional] 
**IisBindingIpAddress** | **string** | Comma-separated IP addresses of the IIS bindings to update (or create with - -iis-create-binding), one binding per address, or * for all unassigned addresses; required with - -iis-website-name (requires gateway version 5.8.0 or higher, or the association is rejected; relevant only for Windows certificate provisioning, requires - -certificate-format pfx and a - -certificate-path of the form Cert:\\LocalMachine\\&lt;store&gt;, for example Cert:\\LocalMachine\\My) | [optional] 
**IisBindingPort** | **long** | The port of the IIS binding, 443 when omitted (requires gateway version 5.8.0 or higher, or the association is rejected; relevant only for Windows certificate provisioning, requires - -certificate-format pfx and a - -certificate-path of the form Cert:\\LocalMachine\\&lt;store&gt;, for example Cert:\\LocalMachine\\My) | [optional] 
**IisCreateBinding** | **bool** | Create the IIS https binding if the website has none matching the given IP addresses, port and host name; without it the run fails when such a binding does not exist (requires gateway version 5.8.0 or higher, or the association is rejected; relevant only for Windows certificate provisioning, requires - -certificate-format pfx and a - -certificate-path of the form Cert:\\LocalMachine\\&lt;store&gt;, for example Cert:\\LocalMachine\\My) | [optional] [default to false]
**IisRestartWebsite** | **bool** | Restart the IIS website after the certificate is bound (requires gateway version 5.8.0 or higher, or the association is rejected; relevant only for Windows certificate provisioning, requires - -certificate-format pfx and a - -certificate-path of the form Cert:\\LocalMachine\\&lt;store&gt;, for example Cert:\\LocalMachine\\My) | [optional] [default to false]
**IisWebsiteName** | **string** | The IIS website to bind the provisioned certificate to (requires gateway version 5.8.0 or higher, or the association is rejected; relevant only for Windows certificate provisioning, requires - -certificate-format pfx and a - -certificate-path of the form Cert:\\LocalMachine\\&lt;store&gt;, for example Cert:\\LocalMachine\\My) | [optional] 
**JksPassword** | **string** | JKS file password; required when certificate-format is jks (relevant only for certificate provisioning) | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeyAlias** | **string** | Alias the entry is stored under in the JKS file, default certificate (max 128 characters). Only relevant when - -certificate-format&#x3D;jks | [optional] 
**KeyOperations** | **List&lt;string&gt;** | A list of allowed operations for the key (required for azure targets) | [optional] 
**KeyVault** | **string** | The Azure Key Vault name to provision the certificate to (relevant only for Azure certificate provisioning) | [optional] 
**KeyringName** | **string** | Keyring name of the GCP KMS (required for gcp targets) | [optional] 
**KmsAlgorithm** | **string** | Algorithm of the key in GCP KMS (required for gcp targets) | [optional] 
**LocationId** | **string** | Location id of the GCP KMS (required for gcp targets) | [optional] 
**LocationScope** | **string** | The GCP Certificate Manager location to provision the certificate to: global or a region such as us-central1 (relevant only for GCP certificate provisioning) | [optional] 
**MultiRegion** | **string** | Set to &#39;true&#39; to create a multi-region managed key. (Relevant only for Classic Key AWS targets) | [optional] [default to "false"]
**Name** | **string** | The item to associate | 
**PfxPassword** | **string** | PFX file password; required when certificate-format is pfx (relevant only for certificate provisioning) | [optional] 
**PostProvisionCommand** | **string** | A custom command to run on the remote target after successful provisioning (relevant only for SSH and Windows certificate provisioning, not supported for F5 BIG-IP) | [optional] 
**PrivateKeyPath** | **string** | A path on the target to store the private key (relevant only for certificate provisioning) | [optional] 
**ProjectId** | **string** | Project id of the GCP KMS (required for gcp targets) | [optional] 
**ProtectionLevel** | **string** | Protection level of the key [software/hardware] (relevant for gcp targets) | [optional] [default to "software"]
**ProvisioningScheduleDays** | **string** | Comma-separated UTC weekdays (sun,mon,tue,wed,thu,fri,sat) on which the certificate is provisioned after a renewal, together with provisioning-schedule-time. Provisioning is not run when the association is created. Without a schedule, provisioning runs right away (relevant only for certificate provisioning) | [optional] 
**ProvisioningScheduleTime** | **string** | The UTC time of day, as HH:MM, at which the certificate is provisioned on the scheduled days. A renewed certificate waits for the first such time (relevant only for certificate provisioning) | [optional] 
**Purpose** | **string** | Purpose of the key in GCP KMS (required for gcp targets) | [optional] 
**Regions** | **List&lt;string&gt;** | The list of regions to create a copy of the key in (relevant for aws targets) | [optional] 
**SraAssociation** | **bool** | Is the target to associate is for sra, relevant only for linked target association for ldap rotated secret | [optional] [default to false]
**TargetName** | **string** | The target to associate | 
**TenantSecretType** | **string** | The tenant secret type [Data/SearchIndex/Analytics] (required for salesforce targets) | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**VaultName** | **string** | Name of the vault used (required for azure targets) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

