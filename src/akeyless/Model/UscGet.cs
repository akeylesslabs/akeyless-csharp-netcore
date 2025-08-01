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
    /// uscGet is a command that gets the value and internal details of a secret from a Universal Secrets Connector
    /// </summary>
    [DataContract(Name = "uscGet")]
    public partial class UscGet : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UscGet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UscGet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UscGet" /> class.
        /// </summary>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="varNamespace">The namespace (relevant for Hashi vault target).</param>
        /// <param name="secretId">The secret id (or name, for AWS, Azure, K8s or Hashi vault targets) to get from the Universal Secrets Connector (required).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="uscName">Name of the Universal Secrets Connector item (required).</param>
        /// <param name="versionId">The version id (if not specified, will retrieve the last version).</param>
        public UscGet(bool json = false, string varNamespace = default(string), string secretId = default(string), string token = default(string), string uidToken = default(string), string uscName = default(string), string versionId = default(string))
        {
            // to ensure "secretId" is required (not null)
            if (secretId == null)
            {
                throw new ArgumentNullException("secretId is a required property for UscGet and cannot be null");
            }
            this.SecretId = secretId;
            // to ensure "uscName" is required (not null)
            if (uscName == null)
            {
                throw new ArgumentNullException("uscName is a required property for UscGet and cannot be null");
            }
            this.UscName = uscName;
            this.Json = json;
            this.Namespace = varNamespace;
            this.Token = token;
            this.UidToken = uidToken;
            this.VersionId = versionId;
        }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// The namespace (relevant for Hashi vault target)
        /// </summary>
        /// <value>The namespace (relevant for Hashi vault target)</value>
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The secret id (or name, for AWS, Azure, K8s or Hashi vault targets) to get from the Universal Secrets Connector
        /// </summary>
        /// <value>The secret id (or name, for AWS, Azure, K8s or Hashi vault targets) to get from the Universal Secrets Connector</value>
        [DataMember(Name = "secret-id", IsRequired = true, EmitDefaultValue = true)]
        public string SecretId { get; set; }

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
        /// Name of the Universal Secrets Connector item
        /// </summary>
        /// <value>Name of the Universal Secrets Connector item</value>
        [DataMember(Name = "usc-name", IsRequired = true, EmitDefaultValue = true)]
        public string UscName { get; set; }

        /// <summary>
        /// The version id (if not specified, will retrieve the last version)
        /// </summary>
        /// <value>The version id (if not specified, will retrieve the last version)</value>
        [DataMember(Name = "version-id", EmitDefaultValue = false)]
        public string VersionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UscGet {\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  SecretId: ").Append(SecretId).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  UscName: ").Append(UscName).Append("\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
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
