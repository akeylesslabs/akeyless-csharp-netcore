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
    /// gatewayCreateProducerDockerhub is a command that creates a DOCKERHUB producer [Deprecated: Use dynamic-secret-create-dockerhub command]
    /// </summary>
    [DataContract(Name = "gatewayCreateProducerDockerhub")]
    public partial class GatewayCreateProducerDockerhub : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayCreateProducerDockerhub" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GatewayCreateProducerDockerhub() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayCreateProducerDockerhub" /> class.
        /// </summary>
        /// <param name="deleteProtection">Protection from accidental deletion of this object [true/false].</param>
        /// <param name="dockerhubPassword">DockerhubPassword is either the user&#39;s password access token to manage the repository.</param>
        /// <param name="dockerhubTokenScopes">Access token scopes list (comma-separated) to give the dynamic secret valid options are in \&quot;repo:admin\&quot;, \&quot;repo:write\&quot;, \&quot;repo:read\&quot;, \&quot;repo:public_read\&quot;.</param>
        /// <param name="dockerhubUsername">DockerhubUsername is the name of the user in dockerhub.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="name">Dynamic secret name (required).</param>
        /// <param name="producerEncryptionKeyName">Dynamic producer encryption key.</param>
        /// <param name="tags">Add tags attached to this object.</param>
        /// <param name="targetName">Target name.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="userTtl">User TTL (default to &quot;60m&quot;).</param>
        public GatewayCreateProducerDockerhub(string deleteProtection = default(string), string dockerhubPassword = default(string), string dockerhubTokenScopes = default(string), string dockerhubUsername = default(string), bool json = false, string name = default(string), string producerEncryptionKeyName = default(string), List<string> tags = default(List<string>), string targetName = default(string), string token = default(string), string uidToken = default(string), string userTtl = @"60m")
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for GatewayCreateProducerDockerhub and cannot be null");
            }
            this.Name = name;
            this.DeleteProtection = deleteProtection;
            this.DockerhubPassword = dockerhubPassword;
            this.DockerhubTokenScopes = dockerhubTokenScopes;
            this.DockerhubUsername = dockerhubUsername;
            this.Json = json;
            this.ProducerEncryptionKeyName = producerEncryptionKeyName;
            this.Tags = tags;
            this.TargetName = targetName;
            this.Token = token;
            this.UidToken = uidToken;
            // use default value if no "userTtl" provided
            this.UserTtl = userTtl ?? @"60m";
        }

        /// <summary>
        /// Protection from accidental deletion of this object [true/false]
        /// </summary>
        /// <value>Protection from accidental deletion of this object [true/false]</value>
        [DataMember(Name = "delete_protection", EmitDefaultValue = false)]
        public string DeleteProtection { get; set; }

        /// <summary>
        /// DockerhubPassword is either the user&#39;s password access token to manage the repository
        /// </summary>
        /// <value>DockerhubPassword is either the user&#39;s password access token to manage the repository</value>
        [DataMember(Name = "dockerhub-password", EmitDefaultValue = false)]
        public string DockerhubPassword { get; set; }

        /// <summary>
        /// Access token scopes list (comma-separated) to give the dynamic secret valid options are in \&quot;repo:admin\&quot;, \&quot;repo:write\&quot;, \&quot;repo:read\&quot;, \&quot;repo:public_read\&quot;
        /// </summary>
        /// <value>Access token scopes list (comma-separated) to give the dynamic secret valid options are in \&quot;repo:admin\&quot;, \&quot;repo:write\&quot;, \&quot;repo:read\&quot;, \&quot;repo:public_read\&quot;</value>
        [DataMember(Name = "dockerhub-token-scopes", EmitDefaultValue = false)]
        public string DockerhubTokenScopes { get; set; }

        /// <summary>
        /// DockerhubUsername is the name of the user in dockerhub
        /// </summary>
        /// <value>DockerhubUsername is the name of the user in dockerhub</value>
        [DataMember(Name = "dockerhub-username", EmitDefaultValue = false)]
        public string DockerhubUsername { get; set; }

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
            sb.Append("class GatewayCreateProducerDockerhub {\n");
            sb.Append("  DeleteProtection: ").Append(DeleteProtection).Append("\n");
            sb.Append("  DockerhubPassword: ").Append(DockerhubPassword).Append("\n");
            sb.Append("  DockerhubTokenScopes: ").Append(DockerhubTokenScopes).Append("\n");
            sb.Append("  DockerhubUsername: ").Append(DockerhubUsername).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProducerEncryptionKeyName: ").Append(ProducerEncryptionKeyName).Append("\n");
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
