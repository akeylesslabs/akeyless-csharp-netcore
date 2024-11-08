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
    /// updateGithubTarget is a command that updates a new target. [Deprecated: Use target-update-github command]
    /// </summary>
    [DataContract(Name = "updateGithubTarget")]
    public partial class UpdateGithubTarget : IEquatable<UpdateGithubTarget>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGithubTarget" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateGithubTarget() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGithubTarget" /> class.
        /// </summary>
        /// <param name="comment">Deprecated - use description.</param>
        /// <param name="description">Description of the object.</param>
        /// <param name="githubAppId">Github app id.</param>
        /// <param name="githubAppPrivateKey">App private key.</param>
        /// <param name="githubBaseUrl">Base URL (default to &quot;https://api.github.com/&quot;).</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="keepPrevVersion">Whether to keep previous version [true/false]. If not set, use default according to account settings.</param>
        /// <param name="key">The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used).</param>
        /// <param name="maxVersions">Set the maximum number of versions, limited by the account settings defaults..</param>
        /// <param name="name">Target name (required).</param>
        /// <param name="newName">New target name.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="updateVersion">Deprecated.</param>
        public UpdateGithubTarget(string comment = default(string), string description = default(string), long githubAppId = default(long), string githubAppPrivateKey = default(string), string githubBaseUrl = "https://api.github.com/", bool json = false, string keepPrevVersion = default(string), string key = default(string), string maxVersions = default(string), string name = default(string), string newName = default(string), string token = default(string), string uidToken = default(string), bool updateVersion = default(bool))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for UpdateGithubTarget and cannot be null");
            }
            this.Name = name;
            this.Comment = comment;
            this.Description = description;
            this.GithubAppId = githubAppId;
            this.GithubAppPrivateKey = githubAppPrivateKey;
            // use default value if no "githubBaseUrl" provided
            this.GithubBaseUrl = githubBaseUrl ?? "https://api.github.com/";
            this.Json = json;
            this.KeepPrevVersion = keepPrevVersion;
            this.Key = key;
            this.MaxVersions = maxVersions;
            this.NewName = newName;
            this.Token = token;
            this.UidToken = uidToken;
            this.UpdateVersion = updateVersion;
        }

        /// <summary>
        /// Deprecated - use description
        /// </summary>
        /// <value>Deprecated - use description</value>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Description of the object
        /// </summary>
        /// <value>Description of the object</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Github app id
        /// </summary>
        /// <value>Github app id</value>
        [DataMember(Name = "github-app-id", EmitDefaultValue = false)]
        public long GithubAppId { get; set; }

        /// <summary>
        /// App private key
        /// </summary>
        /// <value>App private key</value>
        [DataMember(Name = "github-app-private-key", EmitDefaultValue = false)]
        public string GithubAppPrivateKey { get; set; }

        /// <summary>
        /// Base URL
        /// </summary>
        /// <value>Base URL</value>
        [DataMember(Name = "github-base-url", EmitDefaultValue = false)]
        public string GithubBaseUrl { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// Whether to keep previous version [true/false]. If not set, use default according to account settings
        /// </summary>
        /// <value>Whether to keep previous version [true/false]. If not set, use default according to account settings</value>
        [DataMember(Name = "keep-prev-version", EmitDefaultValue = false)]
        public string KeepPrevVersion { get; set; }

        /// <summary>
        /// The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used)
        /// </summary>
        /// <value>The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used)</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Set the maximum number of versions, limited by the account settings defaults.
        /// </summary>
        /// <value>Set the maximum number of versions, limited by the account settings defaults.</value>
        [DataMember(Name = "max-versions", EmitDefaultValue = false)]
        public string MaxVersions { get; set; }

        /// <summary>
        /// Target name
        /// </summary>
        /// <value>Target name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// New target name
        /// </summary>
        /// <value>New target name</value>
        [DataMember(Name = "new-name", EmitDefaultValue = false)]
        public string NewName { get; set; }

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
        /// Deprecated
        /// </summary>
        /// <value>Deprecated</value>
        [DataMember(Name = "update-version", EmitDefaultValue = true)]
        public bool UpdateVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateGithubTarget {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  GithubAppId: ").Append(GithubAppId).Append("\n");
            sb.Append("  GithubAppPrivateKey: ").Append(GithubAppPrivateKey).Append("\n");
            sb.Append("  GithubBaseUrl: ").Append(GithubBaseUrl).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  KeepPrevVersion: ").Append(KeepPrevVersion).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  MaxVersions: ").Append(MaxVersions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NewName: ").Append(NewName).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  UpdateVersion: ").Append(UpdateVersion).Append("\n");
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
            return this.Equals(input as UpdateGithubTarget);
        }

        /// <summary>
        /// Returns true if UpdateGithubTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateGithubTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateGithubTarget input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.GithubAppId == input.GithubAppId ||
                    this.GithubAppId.Equals(input.GithubAppId)
                ) && 
                (
                    this.GithubAppPrivateKey == input.GithubAppPrivateKey ||
                    (this.GithubAppPrivateKey != null &&
                    this.GithubAppPrivateKey.Equals(input.GithubAppPrivateKey))
                ) && 
                (
                    this.GithubBaseUrl == input.GithubBaseUrl ||
                    (this.GithubBaseUrl != null &&
                    this.GithubBaseUrl.Equals(input.GithubBaseUrl))
                ) && 
                (
                    this.Json == input.Json ||
                    this.Json.Equals(input.Json)
                ) && 
                (
                    this.KeepPrevVersion == input.KeepPrevVersion ||
                    (this.KeepPrevVersion != null &&
                    this.KeepPrevVersion.Equals(input.KeepPrevVersion))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.MaxVersions == input.MaxVersions ||
                    (this.MaxVersions != null &&
                    this.MaxVersions.Equals(input.MaxVersions))
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
                    this.UpdateVersion == input.UpdateVersion ||
                    this.UpdateVersion.Equals(input.UpdateVersion)
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
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GithubAppId.GetHashCode();
                if (this.GithubAppPrivateKey != null)
                {
                    hashCode = (hashCode * 59) + this.GithubAppPrivateKey.GetHashCode();
                }
                if (this.GithubBaseUrl != null)
                {
                    hashCode = (hashCode * 59) + this.GithubBaseUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                if (this.KeepPrevVersion != null)
                {
                    hashCode = (hashCode * 59) + this.KeepPrevVersion.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.MaxVersions != null)
                {
                    hashCode = (hashCode * 59) + this.MaxVersions.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.NewName != null)
                {
                    hashCode = (hashCode * 59) + this.NewName.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                if (this.UidToken != null)
                {
                    hashCode = (hashCode * 59) + this.UidToken.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UpdateVersion.GetHashCode();
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
