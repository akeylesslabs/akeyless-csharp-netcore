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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = akeyless.Client.OpenAPIDateConverter;

namespace akeyless.Model
{
    /// <summary>
    /// AuthMethodRoleAssociation includes details of an association between an auth method and a role.
    /// </summary>
    [DataContract]
    public partial class AuthMethodRoleAssociation :  IEquatable<AuthMethodRoleAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthMethodRoleAssociation" /> class.
        /// </summary>
        /// <param name="assocId">assocId.</param>
        /// <param name="authMethodSubClaims">authMethodSubClaims.</param>
        /// <param name="roleName">roleName.</param>
        /// <param name="rules">rules.</param>
        public AuthMethodRoleAssociation(string assocId = default(string), Dictionary<string, List<string>> authMethodSubClaims = default(Dictionary<string, List<string>>), string roleName = default(string), Rules rules = default(Rules))
        {
            this.AssocId = assocId;
            this.AuthMethodSubClaims = authMethodSubClaims;
            this.RoleName = roleName;
            this.Rules = rules;
        }
        
        /// <summary>
        /// Gets or Sets AssocId
        /// </summary>
        [DataMember(Name="assoc_id", EmitDefaultValue=false)]
        public string AssocId { get; set; }

        /// <summary>
        /// Gets or Sets AuthMethodSubClaims
        /// </summary>
        [DataMember(Name="auth_method_sub_claims", EmitDefaultValue=false)]
        public Dictionary<string, List<string>> AuthMethodSubClaims { get; set; }

        /// <summary>
        /// Gets or Sets RoleName
        /// </summary>
        [DataMember(Name="role_name", EmitDefaultValue=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or Sets Rules
        /// </summary>
        [DataMember(Name="rules", EmitDefaultValue=false)]
        public Rules Rules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthMethodRoleAssociation {\n");
            sb.Append("  AssocId: ").Append(AssocId).Append("\n");
            sb.Append("  AuthMethodSubClaims: ").Append(AuthMethodSubClaims).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthMethodRoleAssociation);
        }

        /// <summary>
        /// Returns true if AuthMethodRoleAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthMethodRoleAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthMethodRoleAssociation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssocId == input.AssocId ||
                    (this.AssocId != null &&
                    this.AssocId.Equals(input.AssocId))
                ) && 
                (
                    this.AuthMethodSubClaims == input.AuthMethodSubClaims ||
                    this.AuthMethodSubClaims != null &&
                    input.AuthMethodSubClaims != null &&
                    this.AuthMethodSubClaims.SequenceEqual(input.AuthMethodSubClaims)
                ) && 
                (
                    this.RoleName == input.RoleName ||
                    (this.RoleName != null &&
                    this.RoleName.Equals(input.RoleName))
                ) && 
                (
                    this.Rules == input.Rules ||
                    (this.Rules != null &&
                    this.Rules.Equals(input.Rules))
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
                if (this.AssocId != null)
                    hashCode = hashCode * 59 + this.AssocId.GetHashCode();
                if (this.AuthMethodSubClaims != null)
                    hashCode = hashCode * 59 + this.AuthMethodSubClaims.GetHashCode();
                if (this.RoleName != null)
                    hashCode = hashCode * 59 + this.RoleName.GetHashCode();
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
