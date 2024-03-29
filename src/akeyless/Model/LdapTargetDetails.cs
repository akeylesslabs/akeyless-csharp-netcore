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
    /// LdapTargetDetails
    /// </summary>
    [DataContract(Name = "LdapTargetDetails")]
    public partial class LdapTargetDetails : IEquatable<LdapTargetDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LdapTargetDetails" /> class.
        /// </summary>
        /// <param name="implementationType">implementationType.</param>
        /// <param name="ldapAudience">ldapAudience.</param>
        /// <param name="ldapBindDn">ldapBindDn.</param>
        /// <param name="ldapBindPassword">ldapBindPassword.</param>
        /// <param name="ldapCertificate">ldapCertificate.</param>
        /// <param name="ldapTokenExpiration">ldapTokenExpiration.</param>
        /// <param name="ldapUrl">ldapUrl.</param>
        public LdapTargetDetails(string implementationType = default(string), string ldapAudience = default(string), string ldapBindDn = default(string), string ldapBindPassword = default(string), string ldapCertificate = default(string), string ldapTokenExpiration = default(string), string ldapUrl = default(string))
        {
            this.ImplementationType = implementationType;
            this.LdapAudience = ldapAudience;
            this.LdapBindDn = ldapBindDn;
            this.LdapBindPassword = ldapBindPassword;
            this.LdapCertificate = ldapCertificate;
            this.LdapTokenExpiration = ldapTokenExpiration;
            this.LdapUrl = ldapUrl;
        }

        /// <summary>
        /// Gets or Sets ImplementationType
        /// </summary>
        [DataMember(Name = "implementation_type", EmitDefaultValue = false)]
        public string ImplementationType { get; set; }

        /// <summary>
        /// Gets or Sets LdapAudience
        /// </summary>
        [DataMember(Name = "ldap_audience", EmitDefaultValue = false)]
        public string LdapAudience { get; set; }

        /// <summary>
        /// Gets or Sets LdapBindDn
        /// </summary>
        [DataMember(Name = "ldap_bind_dn", EmitDefaultValue = false)]
        public string LdapBindDn { get; set; }

        /// <summary>
        /// Gets or Sets LdapBindPassword
        /// </summary>
        [DataMember(Name = "ldap_bind_password", EmitDefaultValue = false)]
        public string LdapBindPassword { get; set; }

        /// <summary>
        /// Gets or Sets LdapCertificate
        /// </summary>
        [DataMember(Name = "ldap_certificate", EmitDefaultValue = false)]
        public string LdapCertificate { get; set; }

        /// <summary>
        /// Gets or Sets LdapTokenExpiration
        /// </summary>
        [DataMember(Name = "ldap_token_expiration", EmitDefaultValue = false)]
        public string LdapTokenExpiration { get; set; }

        /// <summary>
        /// Gets or Sets LdapUrl
        /// </summary>
        [DataMember(Name = "ldap_url", EmitDefaultValue = false)]
        public string LdapUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LdapTargetDetails {\n");
            sb.Append("  ImplementationType: ").Append(ImplementationType).Append("\n");
            sb.Append("  LdapAudience: ").Append(LdapAudience).Append("\n");
            sb.Append("  LdapBindDn: ").Append(LdapBindDn).Append("\n");
            sb.Append("  LdapBindPassword: ").Append(LdapBindPassword).Append("\n");
            sb.Append("  LdapCertificate: ").Append(LdapCertificate).Append("\n");
            sb.Append("  LdapTokenExpiration: ").Append(LdapTokenExpiration).Append("\n");
            sb.Append("  LdapUrl: ").Append(LdapUrl).Append("\n");
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
            return this.Equals(input as LdapTargetDetails);
        }

        /// <summary>
        /// Returns true if LdapTargetDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of LdapTargetDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LdapTargetDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ImplementationType == input.ImplementationType ||
                    (this.ImplementationType != null &&
                    this.ImplementationType.Equals(input.ImplementationType))
                ) && 
                (
                    this.LdapAudience == input.LdapAudience ||
                    (this.LdapAudience != null &&
                    this.LdapAudience.Equals(input.LdapAudience))
                ) && 
                (
                    this.LdapBindDn == input.LdapBindDn ||
                    (this.LdapBindDn != null &&
                    this.LdapBindDn.Equals(input.LdapBindDn))
                ) && 
                (
                    this.LdapBindPassword == input.LdapBindPassword ||
                    (this.LdapBindPassword != null &&
                    this.LdapBindPassword.Equals(input.LdapBindPassword))
                ) && 
                (
                    this.LdapCertificate == input.LdapCertificate ||
                    (this.LdapCertificate != null &&
                    this.LdapCertificate.Equals(input.LdapCertificate))
                ) && 
                (
                    this.LdapTokenExpiration == input.LdapTokenExpiration ||
                    (this.LdapTokenExpiration != null &&
                    this.LdapTokenExpiration.Equals(input.LdapTokenExpiration))
                ) && 
                (
                    this.LdapUrl == input.LdapUrl ||
                    (this.LdapUrl != null &&
                    this.LdapUrl.Equals(input.LdapUrl))
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
                if (this.ImplementationType != null)
                {
                    hashCode = (hashCode * 59) + this.ImplementationType.GetHashCode();
                }
                if (this.LdapAudience != null)
                {
                    hashCode = (hashCode * 59) + this.LdapAudience.GetHashCode();
                }
                if (this.LdapBindDn != null)
                {
                    hashCode = (hashCode * 59) + this.LdapBindDn.GetHashCode();
                }
                if (this.LdapBindPassword != null)
                {
                    hashCode = (hashCode * 59) + this.LdapBindPassword.GetHashCode();
                }
                if (this.LdapCertificate != null)
                {
                    hashCode = (hashCode * 59) + this.LdapCertificate.GetHashCode();
                }
                if (this.LdapTokenExpiration != null)
                {
                    hashCode = (hashCode * 59) + this.LdapTokenExpiration.GetHashCode();
                }
                if (this.LdapUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LdapUrl.GetHashCode();
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
