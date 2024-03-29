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
    /// MigrationGeneral
    /// </summary>
    [DataContract(Name = "MigrationGeneral")]
    public partial class MigrationGeneral : IEquatable<MigrationGeneral>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationGeneral" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="lastMigration">lastMigration.</param>
        /// <param name="name">name.</param>
        /// <param name="newName">newName.</param>
        /// <param name="prefix">prefix.</param>
        /// <param name="protectionKey">protectionKey.</param>
        /// <param name="status">status.</param>
        /// <param name="type">type.</param>
        public MigrationGeneral(string id = default(string), string lastMigration = default(string), string name = default(string), string newName = default(string), string prefix = default(string), string protectionKey = default(string), string status = default(string), string type = default(string))
        {
            this.Id = id;
            this.LastMigration = lastMigration;
            this.Name = name;
            this.NewName = newName;
            this.Prefix = prefix;
            this.ProtectionKey = protectionKey;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets LastMigration
        /// </summary>
        [DataMember(Name = "last_migration", EmitDefaultValue = false)]
        public string LastMigration { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NewName
        /// </summary>
        [DataMember(Name = "new_name", EmitDefaultValue = false)]
        public string NewName { get; set; }

        /// <summary>
        /// Gets or Sets Prefix
        /// </summary>
        [DataMember(Name = "prefix", EmitDefaultValue = false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionKey
        /// </summary>
        [DataMember(Name = "protection_key", EmitDefaultValue = false)]
        public string ProtectionKey { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MigrationGeneral {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastMigration: ").Append(LastMigration).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NewName: ").Append(NewName).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  ProtectionKey: ").Append(ProtectionKey).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as MigrationGeneral);
        }

        /// <summary>
        /// Returns true if MigrationGeneral instances are equal
        /// </summary>
        /// <param name="input">Instance of MigrationGeneral to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MigrationGeneral input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastMigration == input.LastMigration ||
                    (this.LastMigration != null &&
                    this.LastMigration.Equals(input.LastMigration))
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
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.ProtectionKey == input.ProtectionKey ||
                    (this.ProtectionKey != null &&
                    this.ProtectionKey.Equals(input.ProtectionKey))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.LastMigration != null)
                {
                    hashCode = (hashCode * 59) + this.LastMigration.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.NewName != null)
                {
                    hashCode = (hashCode * 59) + this.NewName.GetHashCode();
                }
                if (this.Prefix != null)
                {
                    hashCode = (hashCode * 59) + this.Prefix.GetHashCode();
                }
                if (this.ProtectionKey != null)
                {
                    hashCode = (hashCode * 59) + this.ProtectionKey.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
