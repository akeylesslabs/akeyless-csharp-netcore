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
    /// UscSyncInfo
    /// </summary>
    [DataContract(Name = "UscSyncInfo")]
    public partial class UscSyncInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UscSyncInfo" /> class.
        /// </summary>
        /// <param name="jqSecretFilter">jqSecretFilter.</param>
        /// <param name="lastError">lastError.</param>
        /// <param name="varNamespace">varNamespace.</param>
        /// <param name="secretId">secretId.</param>
        /// <param name="secretName">secretName.</param>
        public UscSyncInfo(string jqSecretFilter = default(string), string lastError = default(string), string varNamespace = default(string), string secretId = default(string), string secretName = default(string))
        {
            this.JqSecretFilter = jqSecretFilter;
            this.LastError = lastError;
            this.Namespace = varNamespace;
            this.SecretId = secretId;
            this.SecretName = secretName;
        }

        /// <summary>
        /// Gets or Sets JqSecretFilter
        /// </summary>
        [DataMember(Name = "jq_secret_filter", EmitDefaultValue = false)]
        public string JqSecretFilter { get; set; }

        /// <summary>
        /// Gets or Sets LastError
        /// </summary>
        [DataMember(Name = "last_error", EmitDefaultValue = false)]
        public string LastError { get; set; }

        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets SecretId
        /// </summary>
        [DataMember(Name = "secret_id", EmitDefaultValue = false)]
        public string SecretId { get; set; }

        /// <summary>
        /// Gets or Sets SecretName
        /// </summary>
        [DataMember(Name = "secret_name", EmitDefaultValue = false)]
        public string SecretName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UscSyncInfo {\n");
            sb.Append("  JqSecretFilter: ").Append(JqSecretFilter).Append("\n");
            sb.Append("  LastError: ").Append(LastError).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  SecretId: ").Append(SecretId).Append("\n");
            sb.Append("  SecretName: ").Append(SecretName).Append("\n");
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
