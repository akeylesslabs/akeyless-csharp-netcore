/*
 * Akeyless API
 *
 * The purpose of this application is to provide access to Akeyless API.
 *
 * The version of the OpenAPI document: 2.0
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
    /// dynamicSecretCreateEks is a command that creates eks dynamic secret
    /// </summary>
    [DataContract(Name = "dynamicSecretCreateEks")]
    public partial class DynamicSecretCreateEks : IEquatable<DynamicSecretCreateEks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicSecretCreateEks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DynamicSecretCreateEks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicSecretCreateEks" /> class.
        /// </summary>
        /// <param name="deleteProtection">Protection from accidental deletion of this object [true/false].</param>
        /// <param name="description">Description of the object.</param>
        /// <param name="eksAccessKeyId">Access Key ID.</param>
        /// <param name="eksAssumeRole">IAM assume role.</param>
        /// <param name="eksClusterCaCert">EKS cluster CA certificate.</param>
        /// <param name="eksClusterEndpoint">EKS cluster URL endpoint.</param>
        /// <param name="eksClusterName">EKS cluster name.</param>
        /// <param name="eksRegion">Region (default to &quot;us-east-2&quot;).</param>
        /// <param name="eksSecretAccessKey">Secret Access Key.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="name">Dynamic secret name (required).</param>
        /// <param name="producerEncryptionKeyName">Dynamic producer encryption key.</param>
        /// <param name="secureAccessAllowPortForwading">Enable Port forwarding while using CLI access.</param>
        /// <param name="secureAccessBastionIssuer">Path to the SSH Certificate Issuer for your Akeyless Bastion.</param>
        /// <param name="secureAccessClusterEndpoint">The K8s cluster endpoint URL.</param>
        /// <param name="secureAccessEnable">Enable/Disable secure remote access [true/false].</param>
        /// <param name="secureAccessWeb">Enable Web Secure Remote Access (default to false).</param>
        /// <param name="tags">Add tags attached to this object.</param>
        /// <param name="targetName">Target name.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="userTtl">User TTL (default to &quot;15m&quot;).</param>
        public DynamicSecretCreateEks(string deleteProtection = default(string), string description = default(string), string eksAccessKeyId = default(string), string eksAssumeRole = default(string), string eksClusterCaCert = default(string), string eksClusterEndpoint = default(string), string eksClusterName = default(string), string eksRegion = "us-east-2", string eksSecretAccessKey = default(string), bool json = false, string name = default(string), string producerEncryptionKeyName = default(string), bool secureAccessAllowPortForwading = default(bool), string secureAccessBastionIssuer = default(string), string secureAccessClusterEndpoint = default(string), string secureAccessEnable = default(string), bool secureAccessWeb = false, List<string> tags = default(List<string>), string targetName = default(string), string token = default(string), string uidToken = default(string), string userTtl = "15m")
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DynamicSecretCreateEks and cannot be null");
            }
            this.Name = name;
            this.DeleteProtection = deleteProtection;
            this.Description = description;
            this.EksAccessKeyId = eksAccessKeyId;
            this.EksAssumeRole = eksAssumeRole;
            this.EksClusterCaCert = eksClusterCaCert;
            this.EksClusterEndpoint = eksClusterEndpoint;
            this.EksClusterName = eksClusterName;
            // use default value if no "eksRegion" provided
            this.EksRegion = eksRegion ?? "us-east-2";
            this.EksSecretAccessKey = eksSecretAccessKey;
            this.Json = json;
            this.ProducerEncryptionKeyName = producerEncryptionKeyName;
            this.SecureAccessAllowPortForwading = secureAccessAllowPortForwading;
            this.SecureAccessBastionIssuer = secureAccessBastionIssuer;
            this.SecureAccessClusterEndpoint = secureAccessClusterEndpoint;
            this.SecureAccessEnable = secureAccessEnable;
            this.SecureAccessWeb = secureAccessWeb;
            this.Tags = tags;
            this.TargetName = targetName;
            this.Token = token;
            this.UidToken = uidToken;
            // use default value if no "userTtl" provided
            this.UserTtl = userTtl ?? "15m";
        }

        /// <summary>
        /// Protection from accidental deletion of this object [true/false]
        /// </summary>
        /// <value>Protection from accidental deletion of this object [true/false]</value>
        [DataMember(Name = "delete_protection", EmitDefaultValue = false)]
        public string DeleteProtection { get; set; }

        /// <summary>
        /// Description of the object
        /// </summary>
        /// <value>Description of the object</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Access Key ID
        /// </summary>
        /// <value>Access Key ID</value>
        [DataMember(Name = "eks-access-key-id", EmitDefaultValue = false)]
        public string EksAccessKeyId { get; set; }

        /// <summary>
        /// IAM assume role
        /// </summary>
        /// <value>IAM assume role</value>
        [DataMember(Name = "eks-assume-role", EmitDefaultValue = false)]
        public string EksAssumeRole { get; set; }

        /// <summary>
        /// EKS cluster CA certificate
        /// </summary>
        /// <value>EKS cluster CA certificate</value>
        [DataMember(Name = "eks-cluster-ca-cert", EmitDefaultValue = false)]
        public string EksClusterCaCert { get; set; }

        /// <summary>
        /// EKS cluster URL endpoint
        /// </summary>
        /// <value>EKS cluster URL endpoint</value>
        [DataMember(Name = "eks-cluster-endpoint", EmitDefaultValue = false)]
        public string EksClusterEndpoint { get; set; }

        /// <summary>
        /// EKS cluster name
        /// </summary>
        /// <value>EKS cluster name</value>
        [DataMember(Name = "eks-cluster-name", EmitDefaultValue = false)]
        public string EksClusterName { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        /// <value>Region</value>
        [DataMember(Name = "eks-region", EmitDefaultValue = false)]
        public string EksRegion { get; set; }

        /// <summary>
        /// Secret Access Key
        /// </summary>
        /// <value>Secret Access Key</value>
        [DataMember(Name = "eks-secret-access-key", EmitDefaultValue = false)]
        public string EksSecretAccessKey { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// Dynamic secret name
        /// </summary>
        /// <value>Dynamic secret name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Dynamic producer encryption key
        /// </summary>
        /// <value>Dynamic producer encryption key</value>
        [DataMember(Name = "producer-encryption-key-name", EmitDefaultValue = false)]
        public string ProducerEncryptionKeyName { get; set; }

        /// <summary>
        /// Enable Port forwarding while using CLI access
        /// </summary>
        /// <value>Enable Port forwarding while using CLI access</value>
        [DataMember(Name = "secure-access-allow-port-forwading", EmitDefaultValue = true)]
        public bool SecureAccessAllowPortForwading { get; set; }

        /// <summary>
        /// Path to the SSH Certificate Issuer for your Akeyless Bastion
        /// </summary>
        /// <value>Path to the SSH Certificate Issuer for your Akeyless Bastion</value>
        [DataMember(Name = "secure-access-bastion-issuer", EmitDefaultValue = false)]
        public string SecureAccessBastionIssuer { get; set; }

        /// <summary>
        /// The K8s cluster endpoint URL
        /// </summary>
        /// <value>The K8s cluster endpoint URL</value>
        [DataMember(Name = "secure-access-cluster-endpoint", EmitDefaultValue = false)]
        public string SecureAccessClusterEndpoint { get; set; }

        /// <summary>
        /// Enable/Disable secure remote access [true/false]
        /// </summary>
        /// <value>Enable/Disable secure remote access [true/false]</value>
        [DataMember(Name = "secure-access-enable", EmitDefaultValue = false)]
        public string SecureAccessEnable { get; set; }

        /// <summary>
        /// Enable Web Secure Remote Access
        /// </summary>
        /// <value>Enable Web Secure Remote Access</value>
        [DataMember(Name = "secure-access-web", EmitDefaultValue = true)]
        public bool SecureAccessWeb { get; set; }

        /// <summary>
        /// Add tags attached to this object
        /// </summary>
        /// <value>Add tags attached to this object</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Target name
        /// </summary>
        /// <value>Target name</value>
        [DataMember(Name = "target-name", EmitDefaultValue = false)]
        public string TargetName { get; set; }

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
        /// User TTL
        /// </summary>
        /// <value>User TTL</value>
        [DataMember(Name = "user-ttl", EmitDefaultValue = false)]
        public string UserTtl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DynamicSecretCreateEks {\n");
            sb.Append("  DeleteProtection: ").Append(DeleteProtection).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EksAccessKeyId: ").Append(EksAccessKeyId).Append("\n");
            sb.Append("  EksAssumeRole: ").Append(EksAssumeRole).Append("\n");
            sb.Append("  EksClusterCaCert: ").Append(EksClusterCaCert).Append("\n");
            sb.Append("  EksClusterEndpoint: ").Append(EksClusterEndpoint).Append("\n");
            sb.Append("  EksClusterName: ").Append(EksClusterName).Append("\n");
            sb.Append("  EksRegion: ").Append(EksRegion).Append("\n");
            sb.Append("  EksSecretAccessKey: ").Append(EksSecretAccessKey).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProducerEncryptionKeyName: ").Append(ProducerEncryptionKeyName).Append("\n");
            sb.Append("  SecureAccessAllowPortForwading: ").Append(SecureAccessAllowPortForwading).Append("\n");
            sb.Append("  SecureAccessBastionIssuer: ").Append(SecureAccessBastionIssuer).Append("\n");
            sb.Append("  SecureAccessClusterEndpoint: ").Append(SecureAccessClusterEndpoint).Append("\n");
            sb.Append("  SecureAccessEnable: ").Append(SecureAccessEnable).Append("\n");
            sb.Append("  SecureAccessWeb: ").Append(SecureAccessWeb).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  TargetName: ").Append(TargetName).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  UserTtl: ").Append(UserTtl).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DynamicSecretCreateEks);
        }

        /// <summary>
        /// Returns true if DynamicSecretCreateEks instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicSecretCreateEks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicSecretCreateEks input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeleteProtection == input.DeleteProtection ||
                    (this.DeleteProtection != null &&
                    this.DeleteProtection.Equals(input.DeleteProtection))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EksAccessKeyId == input.EksAccessKeyId ||
                    (this.EksAccessKeyId != null &&
                    this.EksAccessKeyId.Equals(input.EksAccessKeyId))
                ) && 
                (
                    this.EksAssumeRole == input.EksAssumeRole ||
                    (this.EksAssumeRole != null &&
                    this.EksAssumeRole.Equals(input.EksAssumeRole))
                ) && 
                (
                    this.EksClusterCaCert == input.EksClusterCaCert ||
                    (this.EksClusterCaCert != null &&
                    this.EksClusterCaCert.Equals(input.EksClusterCaCert))
                ) && 
                (
                    this.EksClusterEndpoint == input.EksClusterEndpoint ||
                    (this.EksClusterEndpoint != null &&
                    this.EksClusterEndpoint.Equals(input.EksClusterEndpoint))
                ) && 
                (
                    this.EksClusterName == input.EksClusterName ||
                    (this.EksClusterName != null &&
                    this.EksClusterName.Equals(input.EksClusterName))
                ) && 
                (
                    this.EksRegion == input.EksRegion ||
                    (this.EksRegion != null &&
                    this.EksRegion.Equals(input.EksRegion))
                ) && 
                (
                    this.EksSecretAccessKey == input.EksSecretAccessKey ||
                    (this.EksSecretAccessKey != null &&
                    this.EksSecretAccessKey.Equals(input.EksSecretAccessKey))
                ) && 
                (
                    this.Json == input.Json ||
                    this.Json.Equals(input.Json)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProducerEncryptionKeyName == input.ProducerEncryptionKeyName ||
                    (this.ProducerEncryptionKeyName != null &&
                    this.ProducerEncryptionKeyName.Equals(input.ProducerEncryptionKeyName))
                ) && 
                (
                    this.SecureAccessAllowPortForwading == input.SecureAccessAllowPortForwading ||
                    this.SecureAccessAllowPortForwading.Equals(input.SecureAccessAllowPortForwading)
                ) && 
                (
                    this.SecureAccessBastionIssuer == input.SecureAccessBastionIssuer ||
                    (this.SecureAccessBastionIssuer != null &&
                    this.SecureAccessBastionIssuer.Equals(input.SecureAccessBastionIssuer))
                ) && 
                (
                    this.SecureAccessClusterEndpoint == input.SecureAccessClusterEndpoint ||
                    (this.SecureAccessClusterEndpoint != null &&
                    this.SecureAccessClusterEndpoint.Equals(input.SecureAccessClusterEndpoint))
                ) && 
                (
                    this.SecureAccessEnable == input.SecureAccessEnable ||
                    (this.SecureAccessEnable != null &&
                    this.SecureAccessEnable.Equals(input.SecureAccessEnable))
                ) && 
                (
                    this.SecureAccessWeb == input.SecureAccessWeb ||
                    this.SecureAccessWeb.Equals(input.SecureAccessWeb)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.TargetName == input.TargetName ||
                    (this.TargetName != null &&
                    this.TargetName.Equals(input.TargetName))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.UidToken == input.UidToken ||
                    (this.UidToken != null &&
                    this.UidToken.Equals(input.UidToken))
                ) && 
                (
                    this.UserTtl == input.UserTtl ||
                    (this.UserTtl != null &&
                    this.UserTtl.Equals(input.UserTtl))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DeleteProtection != null)
                {
                    hashCode = (hashCode * 59) + this.DeleteProtection.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.EksAccessKeyId != null)
                {
                    hashCode = (hashCode * 59) + this.EksAccessKeyId.GetHashCode();
                }
                if (this.EksAssumeRole != null)
                {
                    hashCode = (hashCode * 59) + this.EksAssumeRole.GetHashCode();
                }
                if (this.EksClusterCaCert != null)
                {
                    hashCode = (hashCode * 59) + this.EksClusterCaCert.GetHashCode();
                }
                if (this.EksClusterEndpoint != null)
                {
                    hashCode = (hashCode * 59) + this.EksClusterEndpoint.GetHashCode();
                }
                if (this.EksClusterName != null)
                {
                    hashCode = (hashCode * 59) + this.EksClusterName.GetHashCode();
                }
                if (this.EksRegion != null)
                {
                    hashCode = (hashCode * 59) + this.EksRegion.GetHashCode();
                }
                if (this.EksSecretAccessKey != null)
                {
                    hashCode = (hashCode * 59) + this.EksSecretAccessKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ProducerEncryptionKeyName != null)
                {
                    hashCode = (hashCode * 59) + this.ProducerEncryptionKeyName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SecureAccessAllowPortForwading.GetHashCode();
                if (this.SecureAccessBastionIssuer != null)
                {
                    hashCode = (hashCode * 59) + this.SecureAccessBastionIssuer.GetHashCode();
                }
                if (this.SecureAccessClusterEndpoint != null)
                {
                    hashCode = (hashCode * 59) + this.SecureAccessClusterEndpoint.GetHashCode();
                }
                if (this.SecureAccessEnable != null)
                {
                    hashCode = (hashCode * 59) + this.SecureAccessEnable.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SecureAccessWeb.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.TargetName != null)
                {
                    hashCode = (hashCode * 59) + this.TargetName.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                if (this.UidToken != null)
                {
                    hashCode = (hashCode * 59) + this.UidToken.GetHashCode();
                }
                if (this.UserTtl != null)
                {
                    hashCode = (hashCode * 59) + this.UserTtl.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
