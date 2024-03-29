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
    /// RotateSecret
    /// </summary>
    [DataContract(Name = "rotateSecret")]
    public partial class RotateSecret : IEquatable<RotateSecret>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RotateSecret" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RotateSecret() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RotateSecret" /> class.
        /// </summary>
        /// <param name="rotateAllServicesBoolean">rotateAllServicesBoolean.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="name">Secret name (Rotated Secret or Custom Dynamic Secret) (required).</param>
        /// <param name="rotateAllServices">Rotate all associated services (default to &quot;false&quot;).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        public RotateSecret(bool rotateAllServicesBoolean = default(bool), bool json = false, string name = default(string), string rotateAllServices = "false", string token = default(string), string uidToken = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for RotateSecret and cannot be null");
            }
            this.Name = name;
            this.RotateAllServicesBoolean = rotateAllServicesBoolean;
            this.Json = json;
            // use default value if no "rotateAllServices" provided
            this.RotateAllServices = rotateAllServices ?? "false";
            this.Token = token;
            this.UidToken = uidToken;
        }

        /// <summary>
        /// Gets or Sets RotateAllServicesBoolean
        /// </summary>
        [DataMember(Name = "RotateAllServicesBoolean", EmitDefaultValue = true)]
        public bool RotateAllServicesBoolean { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// Secret name (Rotated Secret or Custom Dynamic Secret)
        /// </summary>
        /// <value>Secret name (Rotated Secret or Custom Dynamic Secret)</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Rotate all associated services
        /// </summary>
        /// <value>Rotate all associated services</value>
        [DataMember(Name = "rotate-all-services", EmitDefaultValue = false)]
        public string RotateAllServices { get; set; }

        /// <summary>
        /// Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)
        /// </summary>
        /// <value>Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

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
            sb.Append("class RotateSecret {\n");
            sb.Append("  RotateAllServicesBoolean: ").Append(RotateAllServicesBoolean).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RotateAllServices: ").Append(RotateAllServices).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as RotateSecret);
        }

        /// <summary>
        /// Returns true if RotateSecret instances are equal
        /// </summary>
        /// <param name="input">Instance of RotateSecret to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RotateSecret input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RotateAllServicesBoolean == input.RotateAllServicesBoolean ||
                    this.RotateAllServicesBoolean.Equals(input.RotateAllServicesBoolean)
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
                    this.RotateAllServices == input.RotateAllServices ||
                    (this.RotateAllServices != null &&
                    this.RotateAllServices.Equals(input.RotateAllServices))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                hashCode = (hashCode * 59) + this.RotateAllServicesBoolean.GetHashCode();
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.RotateAllServices != null)
                {
                    hashCode = (hashCode * 59) + this.RotateAllServices.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
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
