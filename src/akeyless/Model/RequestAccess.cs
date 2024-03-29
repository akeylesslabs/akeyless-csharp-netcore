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
    /// RequestAccess
    /// </summary>
    [DataContract(Name = "requestAccess")]
    public partial class RequestAccess : IEquatable<RequestAccess>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAccess" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestAccess() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAccess" /> class.
        /// </summary>
        /// <param name="capability">List of the required capabilities options: [read, update, delete] (required).</param>
        /// <param name="comment">Deprecated - use description.</param>
        /// <param name="description">Description of the object.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="name">Item name (required).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="type">Item type (required).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        public RequestAccess(List<string> capability = default(List<string>), string comment = default(string), string description = default(string), bool json = false, string name = default(string), string token = default(string), string type = default(string), string uidToken = default(string))
        {
            // to ensure "capability" is required (not null)
            if (capability == null)
            {
                throw new ArgumentNullException("capability is a required property for RequestAccess and cannot be null");
            }
            this.Capability = capability;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for RequestAccess and cannot be null");
            }
            this.Name = name;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for RequestAccess and cannot be null");
            }
            this.Type = type;
            this.Comment = comment;
            this.Description = description;
            this.Json = json;
            this.Token = token;
            this.UidToken = uidToken;
        }

        /// <summary>
        /// List of the required capabilities options: [read, update, delete]
        /// </summary>
        /// <value>List of the required capabilities options: [read, update, delete]</value>
        [DataMember(Name = "capability", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Capability { get; set; }

        /// <summary>
        /// Deprecated - use description
        /// </summary>
        /// <value>Deprecated - use description</value>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Description of the object
        /// </summary>
        /// <value>Description of the object</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// Item name
        /// </summary>
        /// <value>Item name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)
        /// </summary>
        /// <value>Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Item type
        /// </summary>
        /// <value>Item type</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The universal identity token, Required only for universal_identity authentication
        /// </summary>
        /// <value>The universal identity token, Required only for universal_identity authentication</value>
        [DataMember(Name = "uid-token", EmitDefaultValue = false)]
        public string UidToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequestAccess {\n");
            sb.Append("  Capability: ").Append(Capability).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
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
            return this.Equals(input as RequestAccess);
        }

        /// <summary>
        /// Returns true if RequestAccess instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestAccess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestAccess input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Capability == input.Capability ||
                    this.Capability != null &&
                    input.Capability != null &&
                    this.Capability.SequenceEqual(input.Capability)
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Json == input.Json ||
                    this.Json.Equals(input.Json)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UidToken == input.UidToken ||
                    (this.UidToken != null &&
                    this.UidToken.Equals(input.UidToken))
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
                if (this.Capability != null)
                {
                    hashCode = (hashCode * 59) + this.Capability.GetHashCode();
                }
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.UidToken != null)
                {
                    hashCode = (hashCode * 59) + this.UidToken.GetHashCode();
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
