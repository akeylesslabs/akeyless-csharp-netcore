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
    /// UpdateOutput
    /// </summary>
    [DataContract(Name = "updateOutput")]
    public partial class UpdateOutput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOutput" /> class.
        /// </summary>
        /// <param name="changelog">changelog.</param>
        /// <param name="latest">latest.</param>
        /// <param name="updated">updated.</param>
        public UpdateOutput(string changelog = default(string), string latest = default(string), bool updated = default(bool))
        {
            this.Changelog = changelog;
            this.Latest = latest;
            this.Updated = updated;
        }

        /// <summary>
        /// Gets or Sets Changelog
        /// </summary>
        [DataMember(Name = "changelog", EmitDefaultValue = false)]
        public string Changelog { get; set; }

        /// <summary>
        /// Gets or Sets Latest
        /// </summary>
        [DataMember(Name = "latest", EmitDefaultValue = false)]
        public string Latest { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name = "updated", EmitDefaultValue = true)]
        public bool Updated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateOutput {\n");
            sb.Append("  Changelog: ").Append(Changelog).Append("\n");
            sb.Append("  Latest: ").Append(Latest).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
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
