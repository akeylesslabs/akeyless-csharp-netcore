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
    /// LastConfigChange
    /// </summary>
    [DataContract(Name = "LastConfigChange")]
    public partial class LastConfigChange : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LastConfigChange" /> class.
        /// </summary>
        /// <param name="lastK8sAuthsChange">lastK8sAuthsChange.</param>
        /// <param name="lastMigrationsChange">lastMigrationsChange.</param>
        public LastConfigChange(K8SAuthsConfigLastChange lastK8sAuthsChange = default(K8SAuthsConfigLastChange), MigrationsConfigLastChange lastMigrationsChange = default(MigrationsConfigLastChange))
        {
            this.LastK8sAuthsChange = lastK8sAuthsChange;
            this.LastMigrationsChange = lastMigrationsChange;
        }

        /// <summary>
        /// Gets or Sets LastK8sAuthsChange
        /// </summary>
        [DataMember(Name = "last_k8s_auths_change", EmitDefaultValue = false)]
        public K8SAuthsConfigLastChange LastK8sAuthsChange { get; set; }

        /// <summary>
        /// Gets or Sets LastMigrationsChange
        /// </summary>
        [DataMember(Name = "last_migrations_change", EmitDefaultValue = false)]
        public MigrationsConfigLastChange LastMigrationsChange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LastConfigChange {\n");
            sb.Append("  LastK8sAuthsChange: ").Append(LastK8sAuthsChange).Append("\n");
            sb.Append("  LastMigrationsChange: ").Append(LastMigrationsChange).Append("\n");
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
