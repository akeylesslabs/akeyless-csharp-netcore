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
    /// ChangeAdminAccountPassword
    /// </summary>
    [DataContract(Name = "changeAdminAccountPassword")]
    public partial class ChangeAdminAccountPassword : IEquatable<ChangeAdminAccountPassword>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeAdminAccountPassword" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChangeAdminAccountPassword() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeAdminAccountPassword" /> class.
        /// </summary>
        /// <param name="currentPassword">Current password (required).</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="newPassword">New password (required).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        public ChangeAdminAccountPassword(string currentPassword = default(string), bool json = false, string newPassword = default(string), string token = default(string), string uidToken = default(string))
        {
            // to ensure "currentPassword" is required (not null)
            if (currentPassword == null)
            {
                throw new ArgumentNullException("currentPassword is a required property for ChangeAdminAccountPassword and cannot be null");
            }
            this.CurrentPassword = currentPassword;
            // to ensure "newPassword" is required (not null)
            if (newPassword == null)
            {
                throw new ArgumentNullException("newPassword is a required property for ChangeAdminAccountPassword and cannot be null");
            }
            this.NewPassword = newPassword;
            this.Json = json;
            this.Token = token;
            this.UidToken = uidToken;
        }

        /// <summary>
        /// Current password
        /// </summary>
        /// <value>Current password</value>
        [DataMember(Name = "current-password", IsRequired = true, EmitDefaultValue = true)]
        public string CurrentPassword { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// New password
        /// </summary>
        /// <value>New password</value>
        [DataMember(Name = "new-password", IsRequired = true, EmitDefaultValue = true)]
        public string NewPassword { get; set; }

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
            sb.Append("class ChangeAdminAccountPassword {\n");
            sb.Append("  CurrentPassword: ").Append(CurrentPassword).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
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
            return this.Equals(input as ChangeAdminAccountPassword);
        }

        /// <summary>
        /// Returns true if ChangeAdminAccountPassword instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeAdminAccountPassword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeAdminAccountPassword input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CurrentPassword == input.CurrentPassword ||
                    (this.CurrentPassword != null &&
                    this.CurrentPassword.Equals(input.CurrentPassword))
                ) && 
                (
                    this.Json == input.Json ||
                    this.Json.Equals(input.Json)
                ) && 
                (
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
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
                if (this.CurrentPassword != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentPassword.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                if (this.NewPassword != null)
                {
                    hashCode = (hashCode * 59) + this.NewPassword.GetHashCode();
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
