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
    /// GatewayMigrationDeleteOutput
    /// </summary>
    [DataContract(Name = "gatewayMigrationDeleteOutput")]
    public partial class GatewayMigrationDeleteOutput : IEquatable<GatewayMigrationDeleteOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayMigrationDeleteOutput" /> class.
        /// </summary>
        /// <param name="migrationId">migrationId.</param>
        public GatewayMigrationDeleteOutput(string migrationId = default(string))
        {
            this.MigrationId = migrationId;
        }

        /// <summary>
        /// Gets or Sets MigrationId
        /// </summary>
        [DataMember(Name = "migration_id", EmitDefaultValue = false)]
        public string MigrationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GatewayMigrationDeleteOutput {\n");
            sb.Append("  MigrationId: ").Append(MigrationId).Append("\n");
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
            return this.Equals(input as GatewayMigrationDeleteOutput);
        }

        /// <summary>
        /// Returns true if GatewayMigrationDeleteOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of GatewayMigrationDeleteOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GatewayMigrationDeleteOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MigrationId == input.MigrationId ||
                    (this.MigrationId != null &&
                    this.MigrationId.Equals(input.MigrationId))
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
                if (this.MigrationId != null)
                    hashCode = hashCode * 59 + this.MigrationId.GetHashCode();
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