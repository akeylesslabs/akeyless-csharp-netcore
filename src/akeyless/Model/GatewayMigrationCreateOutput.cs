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
    /// GatewayMigrationCreateOutput
    /// </summary>
    [DataContract(Name = "gatewayMigrationCreateOutput")]
    public partial class GatewayMigrationCreateOutput : IEquatable<GatewayMigrationCreateOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayMigrationCreateOutput" /> class.
        /// </summary>
        /// <param name="migrationName">migrationName.</param>
        public GatewayMigrationCreateOutput(string migrationName = default(string))
        {
            this.MigrationName = migrationName;
        }

        /// <summary>
        /// Gets or Sets MigrationName
        /// </summary>
        [DataMember(Name = "migration_name", EmitDefaultValue = false)]
        public string MigrationName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GatewayMigrationCreateOutput {\n");
            sb.Append("  MigrationName: ").Append(MigrationName).Append("\n");
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
            return this.Equals(input as GatewayMigrationCreateOutput);
        }

        /// <summary>
        /// Returns true if GatewayMigrationCreateOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of GatewayMigrationCreateOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GatewayMigrationCreateOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MigrationName == input.MigrationName ||
                    (this.MigrationName != null &&
                    this.MigrationName.Equals(input.MigrationName))
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
                if (this.MigrationName != null)
                    hashCode = hashCode * 59 + this.MigrationName.GetHashCode();
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