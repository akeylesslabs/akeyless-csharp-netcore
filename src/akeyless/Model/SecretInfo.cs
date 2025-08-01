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
    /// SecretInfo
    /// </summary>
    [DataContract(Name = "SecretInfo")]
    public partial class SecretInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretInfo" /> class.
        /// </summary>
        /// <param name="created">created.</param>
        /// <param name="description">description.</param>
        /// <param name="expiration">expiration.</param>
        /// <param name="lastRetrieved">lastRetrieved.</param>
        /// <param name="location">location.</param>
        /// <param name="name">name.</param>
        /// <param name="secretId">secretId.</param>
        /// <param name="status">status.</param>
        /// <param name="tags">tags.</param>
        /// <param name="thumbprint">thumbprint.</param>
        /// <param name="type">type.</param>
        /// <param name="varVersion">varVersion.</param>
        public SecretInfo(DateTime created = default(DateTime), string description = default(string), DateTime expiration = default(DateTime), DateTime lastRetrieved = default(DateTime), Object location = default(Object), string name = default(string), string secretId = default(string), bool status = default(bool), Dictionary<string, string> tags = default(Dictionary<string, string>), string thumbprint = default(string), string type = default(string), long varVersion = default(long))
        {
            this.Created = created;
            this.Description = description;
            this.Expiration = expiration;
            this.LastRetrieved = lastRetrieved;
            this.Location = location;
            this.Name = name;
            this.SecretId = secretId;
            this.Status = status;
            this.Tags = tags;
            this.Thumbprint = thumbprint;
            this.Type = type;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Expiration
        /// </summary>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]
        public DateTime Expiration { get; set; }

        /// <summary>
        /// Gets or Sets LastRetrieved
        /// </summary>
        [DataMember(Name = "last_retrieved", EmitDefaultValue = false)]
        public DateTime LastRetrieved { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = true)]
        public Object Location { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SecretId
        /// </summary>
        [DataMember(Name = "secret_id", EmitDefaultValue = false)]
        public string SecretId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public bool Status { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Thumbprint
        /// </summary>
        [DataMember(Name = "thumbprint", EmitDefaultValue = false)]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public long VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SecretInfo {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  LastRetrieved: ").Append(LastRetrieved).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SecretId: ").Append(SecretId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Thumbprint: ").Append(Thumbprint).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
