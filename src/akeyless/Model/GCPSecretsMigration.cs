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
    /// GCPSecretsMigration
    /// </summary>
    [DataContract(Name = "GCPSecretsMigration")]
    public partial class GCPSecretsMigration : IEquatable<GCPSecretsMigration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GCPSecretsMigration" /> class.
        /// </summary>
        /// <param name="general">general.</param>
        /// <param name="payload">payload.</param>
        public GCPSecretsMigration(MigrationGeneral general = default(MigrationGeneral), GCPPayload payload = default(GCPPayload))
        {
            this.General = general;
            this.Payload = payload;
        }

        /// <summary>
        /// Gets or Sets General
        /// </summary>
        [DataMember(Name = "general", EmitDefaultValue = false)]
        public MigrationGeneral General { get; set; }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public GCPPayload Payload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GCPSecretsMigration {\n");
            sb.Append("  General: ").Append(General).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
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
            return this.Equals(input as GCPSecretsMigration);
        }

        /// <summary>
        /// Returns true if GCPSecretsMigration instances are equal
        /// </summary>
        /// <param name="input">Instance of GCPSecretsMigration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GCPSecretsMigration input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.General == input.General ||
                    (this.General != null &&
                    this.General.Equals(input.General))
                ) && 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
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
                if (this.General != null)
                {
                    hashCode = (hashCode * 59) + this.General.GetHashCode();
                }
                if (this.Payload != null)
                {
                    hashCode = (hashCode * 59) + this.Payload.GetHashCode();
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
