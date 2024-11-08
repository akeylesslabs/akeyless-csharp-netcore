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
    /// dynamicSecretUpdateAws is a command that Updates aws dynamic secret
    /// </summary>
    [DataContract(Name = "dynamicSecretUpdateAws")]
    public partial class DynamicSecretUpdateAws : IEquatable<DynamicSecretUpdateAws>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicSecretUpdateAws" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DynamicSecretUpdateAws() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicSecretUpdateAws" /> class.
        /// </summary>
        /// <param name="accessMode">accessMode.</param>
        /// <param name="adminRotationIntervalDays">Admin credentials rotation interval (days) (default to 0).</param>
        /// <param name="awsAccessKeyId">Access Key ID.</param>
        /// <param name="awsAccessSecretKey">Secret Access Key.</param>
        /// <param name="awsRoleArns">AWS Role ARNs to be used in the Assume Role operation (relevant only for assume_role mode).</param>
        /// <param name="awsUserConsoleAccess">AWS User console access (default to false).</param>
        /// <param name="awsUserGroups">AWS User groups.</param>
        /// <param name="awsUserPolicies">AWS User policies.</param>
        /// <param name="awsUserProgrammaticAccess">Enable AWS User programmatic access (default to true).</param>
        /// <param name="deleteProtection">Protection from accidental deletion of this object [true/false].</param>
        /// <param name="description">Description of the object.</param>
        /// <param name="enableAdminRotation">Automatic admin credentials rotation (default to false).</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="name">Dynamic secret name (required).</param>
        /// <param name="newName">Dynamic secret name.</param>
        /// <param name="passwordLength">The length of the password to be generated.</param>
        /// <param name="producerEncryptionKeyName">Dynamic producer encryption key.</param>
        /// <param name="region">Region (default to &quot;us-east-2&quot;).</param>
        /// <param name="secureAccessAwsAccountId">The AWS account id.</param>
        /// <param name="secureAccessAwsNativeCli">The AWS native cli.</param>
        /// <param name="secureAccessBastionIssuer">Path to the SSH Certificate Issuer for your Akeyless Bastion.</param>
        /// <param name="secureAccessEnable">Enable/Disable secure remote access [true/false].</param>
        /// <param name="secureAccessWeb">Enable Web Secure Remote Access (default to true).</param>
        /// <param name="secureAccessWebBrowsing">Secure browser via Akeyless Web Access Bastion (default to false).</param>
        /// <param name="secureAccessWebProxy">Web-Proxy via Akeyless Web Access Bastion (default to false).</param>
        /// <param name="sessionTags">String of Key value session tags comma separated, relevant only for Assumed Role.</param>
        /// <param name="tags">Add tags attached to this object.</param>
        /// <param name="targetName">Target name.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="transitiveTagKeys">String of transitive tag keys space separated, relevant only for Assumed Role.</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="userTtl">User TTL (default to &quot;60m&quot;).</param>
        public DynamicSecretUpdateAws(string accessMode = default(string), long adminRotationIntervalDays = 0, string awsAccessKeyId = default(string), string awsAccessSecretKey = default(string), string awsRoleArns = default(string), bool awsUserConsoleAccess = false, string awsUserGroups = default(string), string awsUserPolicies = default(string), bool awsUserProgrammaticAccess = true, string deleteProtection = default(string), string description = default(string), bool enableAdminRotation = false, bool json = false, string name = default(string), string newName = default(string), string passwordLength = default(string), string producerEncryptionKeyName = default(string), string region = "us-east-2", string secureAccessAwsAccountId = default(string), bool secureAccessAwsNativeCli = default(bool), string secureAccessBastionIssuer = default(string), string secureAccessEnable = default(string), bool secureAccessWeb = true, bool secureAccessWebBrowsing = false, bool secureAccessWebProxy = false, string sessionTags = default(string), List<string> tags = default(List<string>), string targetName = default(string), string token = default(string), string transitiveTagKeys = default(string), string uidToken = default(string), string userTtl = "60m")
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DynamicSecretUpdateAws and cannot be null");
            }
            this.Name = name;
            this.AccessMode = accessMode;
            this.AdminRotationIntervalDays = adminRotationIntervalDays;
            this.AwsAccessKeyId = awsAccessKeyId;
            this.AwsAccessSecretKey = awsAccessSecretKey;
            this.AwsRoleArns = awsRoleArns;
            this.AwsUserConsoleAccess = awsUserConsoleAccess;
            this.AwsUserGroups = awsUserGroups;
            this.AwsUserPolicies = awsUserPolicies;
            this.AwsUserProgrammaticAccess = awsUserProgrammaticAccess;
            this.DeleteProtection = deleteProtection;
            this.Description = description;
            this.EnableAdminRotation = enableAdminRotation;
            this.Json = json;
            this.NewName = newName;
            this.PasswordLength = passwordLength;
            this.ProducerEncryptionKeyName = producerEncryptionKeyName;
            // use default value if no "region" provided
            this.Region = region ?? "us-east-2";
            this.SecureAccessAwsAccountId = secureAccessAwsAccountId;
            this.SecureAccessAwsNativeCli = secureAccessAwsNativeCli;
            this.SecureAccessBastionIssuer = secureAccessBastionIssuer;
            this.SecureAccessEnable = secureAccessEnable;
            this.SecureAccessWeb = secureAccessWeb;
            this.SecureAccessWebBrowsing = secureAccessWebBrowsing;
            this.SecureAccessWebProxy = secureAccessWebProxy;
            this.SessionTags = sessionTags;
            this.Tags = tags;
            this.TargetName = targetName;
            this.Token = token;
            this.TransitiveTagKeys = transitiveTagKeys;
            this.UidToken = uidToken;
            // use default value if no "userTtl" provided
            this.UserTtl = userTtl ?? "60m";
        }

        /// <summary>
        /// Gets or Sets AccessMode
        /// </summary>
        [DataMember(Name = "access-mode", EmitDefaultValue = false)]
        public string AccessMode { get; set; }

        /// <summary>
        /// Admin credentials rotation interval (days)
        /// </summary>
        /// <value>Admin credentials rotation interval (days)</value>
        [DataMember(Name = "admin-rotation-interval-days", EmitDefaultValue = false)]
        public long AdminRotationIntervalDays { get; set; }

        /// <summary>
        /// Access Key ID
        /// </summary>
        /// <value>Access Key ID</value>
        [DataMember(Name = "aws-access-key-id", EmitDefaultValue = false)]
        public string AwsAccessKeyId { get; set; }

        /// <summary>
        /// Secret Access Key
        /// </summary>
        /// <value>Secret Access Key</value>
        [DataMember(Name = "aws-access-secret-key", EmitDefaultValue = false)]
        public string AwsAccessSecretKey { get; set; }

        /// <summary>
        /// AWS Role ARNs to be used in the Assume Role operation (relevant only for assume_role mode)
        /// </summary>
        /// <value>AWS Role ARNs to be used in the Assume Role operation (relevant only for assume_role mode)</value>
        [DataMember(Name = "aws-role-arns", EmitDefaultValue = false)]
        public string AwsRoleArns { get; set; }

        /// <summary>
        /// AWS User console access
        /// </summary>
        /// <value>AWS User console access</value>
        [DataMember(Name = "aws-user-console-access", EmitDefaultValue = true)]
        public bool AwsUserConsoleAccess { get; set; }

        /// <summary>
        /// AWS User groups
        /// </summary>
        /// <value>AWS User groups</value>
        [DataMember(Name = "aws-user-groups", EmitDefaultValue = false)]
        public string AwsUserGroups { get; set; }

        /// <summary>
        /// AWS User policies
        /// </summary>
        /// <value>AWS User policies</value>
        [DataMember(Name = "aws-user-policies", EmitDefaultValue = false)]
        public string AwsUserPolicies { get; set; }

        /// <summary>
        /// Enable AWS User programmatic access
        /// </summary>
        /// <value>Enable AWS User programmatic access</value>
        [DataMember(Name = "aws-user-programmatic-access", EmitDefaultValue = true)]
        public bool AwsUserProgrammaticAccess { get; set; }

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
        /// Automatic admin credentials rotation
        /// </summary>
        /// <value>Automatic admin credentials rotation</value>
        [DataMember(Name = "enable-admin-rotation", EmitDefaultValue = true)]
        public bool EnableAdminRotation { get; set; }

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
        /// Dynamic secret name
        /// </summary>
        /// <value>Dynamic secret name</value>
        [DataMember(Name = "new-name", EmitDefaultValue = false)]
        public string NewName { get; set; }

        /// <summary>
        /// The length of the password to be generated
        /// </summary>
        /// <value>The length of the password to be generated</value>
        [DataMember(Name = "password-length", EmitDefaultValue = false)]
        public string PasswordLength { get; set; }

        /// <summary>
        /// Dynamic producer encryption key
        /// </summary>
        /// <value>Dynamic producer encryption key</value>
        [DataMember(Name = "producer-encryption-key-name", EmitDefaultValue = false)]
        public string ProducerEncryptionKeyName { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        /// <value>Region</value>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// The AWS account id
        /// </summary>
        /// <value>The AWS account id</value>
        [DataMember(Name = "secure-access-aws-account-id", EmitDefaultValue = false)]
        public string SecureAccessAwsAccountId { get; set; }

        /// <summary>
        /// The AWS native cli
        /// </summary>
        /// <value>The AWS native cli</value>
        [DataMember(Name = "secure-access-aws-native-cli", EmitDefaultValue = true)]
        public bool SecureAccessAwsNativeCli { get; set; }

        /// <summary>
        /// Path to the SSH Certificate Issuer for your Akeyless Bastion
        /// </summary>
        /// <value>Path to the SSH Certificate Issuer for your Akeyless Bastion</value>
        [DataMember(Name = "secure-access-bastion-issuer", EmitDefaultValue = false)]
        public string SecureAccessBastionIssuer { get; set; }

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
        /// Secure browser via Akeyless Web Access Bastion
        /// </summary>
        /// <value>Secure browser via Akeyless Web Access Bastion</value>
        [DataMember(Name = "secure-access-web-browsing", EmitDefaultValue = true)]
        public bool SecureAccessWebBrowsing { get; set; }

        /// <summary>
        /// Web-Proxy via Akeyless Web Access Bastion
        /// </summary>
        /// <value>Web-Proxy via Akeyless Web Access Bastion</value>
        [DataMember(Name = "secure-access-web-proxy", EmitDefaultValue = true)]
        public bool SecureAccessWebProxy { get; set; }

        /// <summary>
        /// String of Key value session tags comma separated, relevant only for Assumed Role
        /// </summary>
        /// <value>String of Key value session tags comma separated, relevant only for Assumed Role</value>
        [DataMember(Name = "session-tags", EmitDefaultValue = false)]
        public string SessionTags { get; set; }

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
        /// String of transitive tag keys space separated, relevant only for Assumed Role
        /// </summary>
        /// <value>String of transitive tag keys space separated, relevant only for Assumed Role</value>
        [DataMember(Name = "transitive-tag-keys", EmitDefaultValue = false)]
        public string TransitiveTagKeys { get; set; }

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
            sb.Append("class DynamicSecretUpdateAws {\n");
            sb.Append("  AccessMode: ").Append(AccessMode).Append("\n");
            sb.Append("  AdminRotationIntervalDays: ").Append(AdminRotationIntervalDays).Append("\n");
            sb.Append("  AwsAccessKeyId: ").Append(AwsAccessKeyId).Append("\n");
            sb.Append("  AwsAccessSecretKey: ").Append(AwsAccessSecretKey).Append("\n");
            sb.Append("  AwsRoleArns: ").Append(AwsRoleArns).Append("\n");
            sb.Append("  AwsUserConsoleAccess: ").Append(AwsUserConsoleAccess).Append("\n");
            sb.Append("  AwsUserGroups: ").Append(AwsUserGroups).Append("\n");
            sb.Append("  AwsUserPolicies: ").Append(AwsUserPolicies).Append("\n");
            sb.Append("  AwsUserProgrammaticAccess: ").Append(AwsUserProgrammaticAccess).Append("\n");
            sb.Append("  DeleteProtection: ").Append(DeleteProtection).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EnableAdminRotation: ").Append(EnableAdminRotation).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NewName: ").Append(NewName).Append("\n");
            sb.Append("  PasswordLength: ").Append(PasswordLength).Append("\n");
            sb.Append("  ProducerEncryptionKeyName: ").Append(ProducerEncryptionKeyName).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  SecureAccessAwsAccountId: ").Append(SecureAccessAwsAccountId).Append("\n");
            sb.Append("  SecureAccessAwsNativeCli: ").Append(SecureAccessAwsNativeCli).Append("\n");
            sb.Append("  SecureAccessBastionIssuer: ").Append(SecureAccessBastionIssuer).Append("\n");
            sb.Append("  SecureAccessEnable: ").Append(SecureAccessEnable).Append("\n");
            sb.Append("  SecureAccessWeb: ").Append(SecureAccessWeb).Append("\n");
            sb.Append("  SecureAccessWebBrowsing: ").Append(SecureAccessWebBrowsing).Append("\n");
            sb.Append("  SecureAccessWebProxy: ").Append(SecureAccessWebProxy).Append("\n");
            sb.Append("  SessionTags: ").Append(SessionTags).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  TargetName: ").Append(TargetName).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TransitiveTagKeys: ").Append(TransitiveTagKeys).Append("\n");
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
            return this.Equals(input as DynamicSecretUpdateAws);
        }

        /// <summary>
        /// Returns true if DynamicSecretUpdateAws instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicSecretUpdateAws to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicSecretUpdateAws input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessMode == input.AccessMode ||
                    (this.AccessMode != null &&
                    this.AccessMode.Equals(input.AccessMode))
                ) && 
                (
                    this.AdminRotationIntervalDays == input.AdminRotationIntervalDays ||
                    this.AdminRotationIntervalDays.Equals(input.AdminRotationIntervalDays)
                ) && 
                (
                    this.AwsAccessKeyId == input.AwsAccessKeyId ||
                    (this.AwsAccessKeyId != null &&
                    this.AwsAccessKeyId.Equals(input.AwsAccessKeyId))
                ) && 
                (
                    this.AwsAccessSecretKey == input.AwsAccessSecretKey ||
                    (this.AwsAccessSecretKey != null &&
                    this.AwsAccessSecretKey.Equals(input.AwsAccessSecretKey))
                ) && 
                (
                    this.AwsRoleArns == input.AwsRoleArns ||
                    (this.AwsRoleArns != null &&
                    this.AwsRoleArns.Equals(input.AwsRoleArns))
                ) && 
                (
                    this.AwsUserConsoleAccess == input.AwsUserConsoleAccess ||
                    this.AwsUserConsoleAccess.Equals(input.AwsUserConsoleAccess)
                ) && 
                (
                    this.AwsUserGroups == input.AwsUserGroups ||
                    (this.AwsUserGroups != null &&
                    this.AwsUserGroups.Equals(input.AwsUserGroups))
                ) && 
                (
                    this.AwsUserPolicies == input.AwsUserPolicies ||
                    (this.AwsUserPolicies != null &&
                    this.AwsUserPolicies.Equals(input.AwsUserPolicies))
                ) && 
                (
                    this.AwsUserProgrammaticAccess == input.AwsUserProgrammaticAccess ||
                    this.AwsUserProgrammaticAccess.Equals(input.AwsUserProgrammaticAccess)
                ) && 
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
                    this.EnableAdminRotation == input.EnableAdminRotation ||
                    this.EnableAdminRotation.Equals(input.EnableAdminRotation)
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
                    this.NewName == input.NewName ||
                    (this.NewName != null &&
                    this.NewName.Equals(input.NewName))
                ) && 
                (
                    this.PasswordLength == input.PasswordLength ||
                    (this.PasswordLength != null &&
                    this.PasswordLength.Equals(input.PasswordLength))
                ) && 
                (
                    this.ProducerEncryptionKeyName == input.ProducerEncryptionKeyName ||
                    (this.ProducerEncryptionKeyName != null &&
                    this.ProducerEncryptionKeyName.Equals(input.ProducerEncryptionKeyName))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.SecureAccessAwsAccountId == input.SecureAccessAwsAccountId ||
                    (this.SecureAccessAwsAccountId != null &&
                    this.SecureAccessAwsAccountId.Equals(input.SecureAccessAwsAccountId))
                ) && 
                (
                    this.SecureAccessAwsNativeCli == input.SecureAccessAwsNativeCli ||
                    this.SecureAccessAwsNativeCli.Equals(input.SecureAccessAwsNativeCli)
                ) && 
                (
                    this.SecureAccessBastionIssuer == input.SecureAccessBastionIssuer ||
                    (this.SecureAccessBastionIssuer != null &&
                    this.SecureAccessBastionIssuer.Equals(input.SecureAccessBastionIssuer))
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
                    this.SecureAccessWebBrowsing == input.SecureAccessWebBrowsing ||
                    this.SecureAccessWebBrowsing.Equals(input.SecureAccessWebBrowsing)
                ) && 
                (
                    this.SecureAccessWebProxy == input.SecureAccessWebProxy ||
                    this.SecureAccessWebProxy.Equals(input.SecureAccessWebProxy)
                ) && 
                (
                    this.SessionTags == input.SessionTags ||
                    (this.SessionTags != null &&
                    this.SessionTags.Equals(input.SessionTags))
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
                    this.TransitiveTagKeys == input.TransitiveTagKeys ||
                    (this.TransitiveTagKeys != null &&
                    this.TransitiveTagKeys.Equals(input.TransitiveTagKeys))
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
                if (this.AccessMode != null)
                {
                    hashCode = (hashCode * 59) + this.AccessMode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AdminRotationIntervalDays.GetHashCode();
                if (this.AwsAccessKeyId != null)
                {
                    hashCode = (hashCode * 59) + this.AwsAccessKeyId.GetHashCode();
                }
                if (this.AwsAccessSecretKey != null)
                {
                    hashCode = (hashCode * 59) + this.AwsAccessSecretKey.GetHashCode();
                }
                if (this.AwsRoleArns != null)
                {
                    hashCode = (hashCode * 59) + this.AwsRoleArns.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AwsUserConsoleAccess.GetHashCode();
                if (this.AwsUserGroups != null)
                {
                    hashCode = (hashCode * 59) + this.AwsUserGroups.GetHashCode();
                }
                if (this.AwsUserPolicies != null)
                {
                    hashCode = (hashCode * 59) + this.AwsUserPolicies.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AwsUserProgrammaticAccess.GetHashCode();
                if (this.DeleteProtection != null)
                {
                    hashCode = (hashCode * 59) + this.DeleteProtection.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EnableAdminRotation.GetHashCode();
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.NewName != null)
                {
                    hashCode = (hashCode * 59) + this.NewName.GetHashCode();
                }
                if (this.PasswordLength != null)
                {
                    hashCode = (hashCode * 59) + this.PasswordLength.GetHashCode();
                }
                if (this.ProducerEncryptionKeyName != null)
                {
                    hashCode = (hashCode * 59) + this.ProducerEncryptionKeyName.GetHashCode();
                }
                if (this.Region != null)
                {
                    hashCode = (hashCode * 59) + this.Region.GetHashCode();
                }
                if (this.SecureAccessAwsAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.SecureAccessAwsAccountId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SecureAccessAwsNativeCli.GetHashCode();
                if (this.SecureAccessBastionIssuer != null)
                {
                    hashCode = (hashCode * 59) + this.SecureAccessBastionIssuer.GetHashCode();
                }
                if (this.SecureAccessEnable != null)
                {
                    hashCode = (hashCode * 59) + this.SecureAccessEnable.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SecureAccessWeb.GetHashCode();
                hashCode = (hashCode * 59) + this.SecureAccessWebBrowsing.GetHashCode();
                hashCode = (hashCode * 59) + this.SecureAccessWebProxy.GetHashCode();
                if (this.SessionTags != null)
                {
                    hashCode = (hashCode * 59) + this.SessionTags.GetHashCode();
                }
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
                if (this.TransitiveTagKeys != null)
                {
                    hashCode = (hashCode * 59) + this.TransitiveTagKeys.GetHashCode();
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
