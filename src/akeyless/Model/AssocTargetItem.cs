/*
 * Akeyless API
 *
 * The purpose of this application is to provide access to Akeyless API.
 *
 * The version of the OpenAPI document: 3.0
 * Contact: support@akeyless.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = akeyless.Client.OpenAPIDateConverter;

namespace akeyless.Model
{
    /// <summary>
    /// assocTargetItem is a command that creates an association between target and item.
    /// </summary>
    [DataContract(Name = "assocTargetItem")]
    public partial class AssocTargetItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssocTargetItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssocTargetItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssocTargetItem" /> class.
        /// </summary>
        /// <param name="certificatePath">A path on the target to store the certificate pem file (relevant only for certificate provisioning).</param>
        /// <param name="chainPath">A path on the target to store the full chain pem file (relevant only for certificate provisioning).</param>
        /// <param name="disablePreviousKeyVersion">Automatically disable previous key version (required for azure targets) (default to false).</param>
        /// <param name="externalKeyName">The external key name to associate with the classic key (Relevant only for Classic Key AWS/Azure/GCP targets).</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="keyOperations">A list of allowed operations for the key (required for azure targets).</param>
        /// <param name="keyringName">Keyring name of the GCP KMS (required for gcp targets).</param>
        /// <param name="kmsAlgorithm">Algorithm of the key in GCP KMS (required for gcp targets).</param>
        /// <param name="locationId">Location id of the GCP KMS (required for gcp targets).</param>
        /// <param name="multiRegion">Set to &#39;true&#39; to create a multi-region managed key. (Relevant only for Classic Key AWS targets) (default to &quot;false&quot;).</param>
        /// <param name="name">The item to associate (required).</param>
        /// <param name="postProvisionCommand">A custom command to run on the remote target after successful provisioning (relevant only for certificate provisioning).</param>
        /// <param name="privateKeyPath">A path on the target to store the private key (relevant only for certificate provisioning).</param>
        /// <param name="projectId">Project id of the GCP KMS (required for gcp targets).</param>
        /// <param name="protectionLevel">Protection level of the key [software/hardware] (relevant for gcp targets) (default to &quot;software&quot;).</param>
        /// <param name="purpose">Purpose of the key in GCP KMS (required for gcp targets).</param>
        /// <param name="regions">The list of regions to create a copy of the key in (relevant for aws targets).</param>
        /// <param name="sraAssociation">Is the target to associate is for sra, relevant only for linked target association for ldap rotated secret (default to false).</param>
        /// <param name="targetName">The target to associate (required).</param>
        /// <param name="tenantSecretType">The tenant secret type [Data/SearchIndex/Analytics] (required for salesforce targets).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="vaultName">Name of the vault used (required for azure targets).</param>
        public AssocTargetItem(string certificatePath = default(string), string chainPath = default(string), bool disablePreviousKeyVersion = false, string externalKeyName = default(string), bool json = false, List<string> keyOperations = default(List<string>), string keyringName = default(string), string kmsAlgorithm = default(string), string locationId = default(string), string multiRegion = @"false", string name = default(string), string postProvisionCommand = default(string), string privateKeyPath = default(string), string projectId = default(string), string protectionLevel = @"software", string purpose = default(string), List<string> regions = default(List<string>), bool sraAssociation = false, string targetName = default(string), string tenantSecretType = default(string), string token = default(string), string uidToken = default(string), string vaultName = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AssocTargetItem and cannot be null");
            }
            this.Name = name;
            // to ensure "targetName" is required (not null)
            if (targetName == null)
            {
                throw new ArgumentNullException("targetName is a required property for AssocTargetItem and cannot be null");
            }
            this.TargetName = targetName;
            this.CertificatePath = certificatePath;
            this.ChainPath = chainPath;
            this.DisablePreviousKeyVersion = disablePreviousKeyVersion;
            this.ExternalKeyName = externalKeyName;
            this.Json = json;
            this.KeyOperations = keyOperations;
            this.KeyringName = keyringName;
            this.KmsAlgorithm = kmsAlgorithm;
            this.LocationId = locationId;
            // use default value if no "multiRegion" provided
            this.MultiRegion = multiRegion ?? @"false";
            this.PostProvisionCommand = postProvisionCommand;
            this.PrivateKeyPath = privateKeyPath;
            this.ProjectId = projectId;
            // use default value if no "protectionLevel" provided
            this.ProtectionLevel = protectionLevel ?? @"software";
            this.Purpose = purpose;
            this.Regions = regions;
            this.SraAssociation = sraAssociation;
            this.TenantSecretType = tenantSecretType;
            this.Token = token;
            this.UidToken = uidToken;
            this.VaultName = vaultName;
        }

        /// <summary>
        /// A path on the target to store the certificate pem file (relevant only for certificate provisioning)
        /// </summary>
        /// <value>A path on the target to store the certificate pem file (relevant only for certificate provisioning)</value>
        [DataMember(Name = "certificate-path", EmitDefaultValue = false)]
        public string CertificatePath { get; set; }

        /// <summary>
        /// A path on the target to store the full chain pem file (relevant only for certificate provisioning)
        /// </summary>
        /// <value>A path on the target to store the full chain pem file (relevant only for certificate provisioning)</value>
        [DataMember(Name = "chain-path", EmitDefaultValue = false)]
        public string ChainPath { get; set; }

        /// <summary>
        /// Automatically disable previous key version (required for azure targets)
        /// </summary>
        /// <value>Automatically disable previous key version (required for azure targets)</value>
        [DataMember(Name = "disable-previous-key-version", EmitDefaultValue = true)]
        public bool DisablePreviousKeyVersion { get; set; }

        /// <summary>
        /// The external key name to associate with the classic key (Relevant only for Classic Key AWS/Azure/GCP targets)
        /// </summary>
        /// <value>The external key name to associate with the classic key (Relevant only for Classic Key AWS/Azure/GCP targets)</value>
        [DataMember(Name = "external-key-name", EmitDefaultValue = false)]
        public string ExternalKeyName { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// A list of allowed operations for the key (required for azure targets)
        /// </summary>
        /// <value>A list of allowed operations for the key (required for azure targets)</value>
        [DataMember(Name = "key-operations", EmitDefaultValue = false)]
        public List<string> KeyOperations { get; set; }

        /// <summary>
        /// Keyring name of the GCP KMS (required for gcp targets)
        /// </summary>
        /// <value>Keyring name of the GCP KMS (required for gcp targets)</value>
        [DataMember(Name = "keyring-name", EmitDefaultValue = false)]
        public string KeyringName { get; set; }

        /// <summary>
        /// Algorithm of the key in GCP KMS (required for gcp targets)
        /// </summary>
        /// <value>Algorithm of the key in GCP KMS (required for gcp targets)</value>
        [DataMember(Name = "kms-algorithm", EmitDefaultValue = false)]
        public string KmsAlgorithm { get; set; }

        /// <summary>
        /// Location id of the GCP KMS (required for gcp targets)
        /// </summary>
        /// <value>Location id of the GCP KMS (required for gcp targets)</value>
        [DataMember(Name = "location-id", EmitDefaultValue = false)]
        public string LocationId { get; set; }

        /// <summary>
        /// Set to &#39;true&#39; to create a multi-region managed key. (Relevant only for Classic Key AWS targets)
        /// </summary>
        /// <value>Set to &#39;true&#39; to create a multi-region managed key. (Relevant only for Classic Key AWS targets)</value>
        [DataMember(Name = "multi-region", EmitDefaultValue = false)]
        public string MultiRegion { get; set; }

        /// <summary>
        /// The item to associate
        /// </summary>
        /// <value>The item to associate</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// A custom command to run on the remote target after successful provisioning (relevant only for certificate provisioning)
        /// </summary>
        /// <value>A custom command to run on the remote target after successful provisioning (relevant only for certificate provisioning)</value>
        [DataMember(Name = "post-provision-command", EmitDefaultValue = false)]
        public string PostProvisionCommand { get; set; }

        /// <summary>
        /// A path on the target to store the private key (relevant only for certificate provisioning)
        /// </summary>
        /// <value>A path on the target to store the private key (relevant only for certificate provisioning)</value>
        [DataMember(Name = "private-key-path", EmitDefaultValue = false)]
        public string PrivateKeyPath { get; set; }

        /// <summary>
        /// Project id of the GCP KMS (required for gcp targets)
        /// </summary>
        /// <value>Project id of the GCP KMS (required for gcp targets)</value>
        [DataMember(Name = "project-id", EmitDefaultValue = false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Protection level of the key [software/hardware] (relevant for gcp targets)
        /// </summary>
        /// <value>Protection level of the key [software/hardware] (relevant for gcp targets)</value>
        [DataMember(Name = "protection-level", EmitDefaultValue = false)]
        public string ProtectionLevel { get; set; }

        /// <summary>
        /// Purpose of the key in GCP KMS (required for gcp targets)
        /// </summary>
        /// <value>Purpose of the key in GCP KMS (required for gcp targets)</value>
        [DataMember(Name = "purpose", EmitDefaultValue = false)]
        public string Purpose { get; set; }

        /// <summary>
        /// The list of regions to create a copy of the key in (relevant for aws targets)
        /// </summary>
        /// <value>The list of regions to create a copy of the key in (relevant for aws targets)</value>
        [DataMember(Name = "regions", EmitDefaultValue = false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// Is the target to associate is for sra, relevant only for linked target association for ldap rotated secret
        /// </summary>
        /// <value>Is the target to associate is for sra, relevant only for linked target association for ldap rotated secret</value>
        [DataMember(Name = "sra-association", EmitDefaultValue = true)]
        public bool SraAssociation { get; set; }

        /// <summary>
        /// The target to associate
        /// </summary>
        /// <value>The target to associate</value>
        [DataMember(Name = "target-name", IsRequired = true, EmitDefaultValue = true)]
        public string TargetName { get; set; }

        /// <summary>
        /// The tenant secret type [Data/SearchIndex/Analytics] (required for salesforce targets)
        /// </summary>
        /// <value>The tenant secret type [Data/SearchIndex/Analytics] (required for salesforce targets)</value>
        [DataMember(Name = "tenant-secret-type", EmitDefaultValue = false)]
        public string TenantSecretType { get; set; }

        /// <summary>
        /// Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)
        /// </summary>
        /// <value>Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// The universal identity token, Required only for universal_identity authentication
        /// </summary>
        /// <value>The universal identity token, Required only for universal_identity authentication</value>
        [DataMember(Name = "uid-token", EmitDefaultValue = false)]
        public string UidToken { get; set; }

        /// <summary>
        /// Name of the vault used (required for azure targets)
        /// </summary>
        /// <value>Name of the vault used (required for azure targets)</value>
        [DataMember(Name = "vault-name", EmitDefaultValue = false)]
        public string VaultName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssocTargetItem {\n");
            sb.Append("  CertificatePath: ").Append(CertificatePath).Append("\n");
            sb.Append("  ChainPath: ").Append(ChainPath).Append("\n");
            sb.Append("  DisablePreviousKeyVersion: ").Append(DisablePreviousKeyVersion).Append("\n");
            sb.Append("  ExternalKeyName: ").Append(ExternalKeyName).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  KeyOperations: ").Append(KeyOperations).Append("\n");
            sb.Append("  KeyringName: ").Append(KeyringName).Append("\n");
            sb.Append("  KmsAlgorithm: ").Append(KmsAlgorithm).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  MultiRegion: ").Append(MultiRegion).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PostProvisionCommand: ").Append(PostProvisionCommand).Append("\n");
            sb.Append("  PrivateKeyPath: ").Append(PrivateKeyPath).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ProtectionLevel: ").Append(ProtectionLevel).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  Regions: ").Append(Regions).Append("\n");
            sb.Append("  SraAssociation: ").Append(SraAssociation).Append("\n");
            sb.Append("  TargetName: ").Append(TargetName).Append("\n");
            sb.Append("  TenantSecretType: ").Append(TenantSecretType).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  VaultName: ").Append(VaultName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
