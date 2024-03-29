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
    /// CreateGroupOutput
    /// </summary>
    [DataContract(Name = "CreateGroupOutput")]
    public partial class CreateGroupOutput : IEquatable<CreateGroupOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupOutput" /> class.
        /// </summary>
        /// <param name="groupAlias">groupAlias.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        public CreateGroupOutput(string groupAlias = default(string), string id = default(string), string name = default(string))
        {
            this.GroupAlias = groupAlias;
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets GroupAlias
        /// </summary>
        [DataMember(Name = "group_alias", EmitDefaultValue = false)]
        public string GroupAlias { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateGroupOutput {\n");
            sb.Append("  GroupAlias: ").Append(GroupAlias).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as CreateGroupOutput);
        }

        /// <summary>
        /// Returns true if CreateGroupOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateGroupOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateGroupOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GroupAlias == input.GroupAlias ||
                    (this.GroupAlias != null &&
                    this.GroupAlias.Equals(input.GroupAlias))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.GroupAlias != null)
                {
                    hashCode = (hashCode * 59) + this.GroupAlias.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
