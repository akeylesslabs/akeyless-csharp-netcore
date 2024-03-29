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
    /// GodaddyTargetDetails
    /// </summary>
    [DataContract(Name = "GodaddyTargetDetails")]
    public partial class GodaddyTargetDetails : IEquatable<GodaddyTargetDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GodaddyTargetDetails" /> class.
        /// </summary>
        /// <param name="imapFqdn">imapFqdn.</param>
        /// <param name="imapPassword">imapPassword.</param>
        /// <param name="imapPort">imapPort.</param>
        /// <param name="imapUser">imapUser.</param>
        /// <param name="key">key.</param>
        /// <param name="secret">secret.</param>
        /// <param name="timeout">A Duration represents the elapsed time between two instants as an int64 nanosecond count. The representation limits the largest representable duration to approximately 290 years..</param>
        /// <param name="validationEmail">validationEmail.</param>
        public GodaddyTargetDetails(string imapFqdn = default(string), string imapPassword = default(string), string imapPort = default(string), string imapUser = default(string), string key = default(string), string secret = default(string), long timeout = default(long), string validationEmail = default(string))
        {
            this.ImapFqdn = imapFqdn;
            this.ImapPassword = imapPassword;
            this.ImapPort = imapPort;
            this.ImapUser = imapUser;
            this.Key = key;
            this.Secret = secret;
            this.Timeout = timeout;
            this.ValidationEmail = validationEmail;
        }

        /// <summary>
        /// Gets or Sets ImapFqdn
        /// </summary>
        [DataMember(Name = "imap_fqdn", EmitDefaultValue = false)]
        public string ImapFqdn { get; set; }

        /// <summary>
        /// Gets or Sets ImapPassword
        /// </summary>
        [DataMember(Name = "imap_password", EmitDefaultValue = false)]
        public string ImapPassword { get; set; }

        /// <summary>
        /// Gets or Sets ImapPort
        /// </summary>
        [DataMember(Name = "imap_port", EmitDefaultValue = false)]
        public string ImapPort { get; set; }

        /// <summary>
        /// Gets or Sets ImapUser
        /// </summary>
        [DataMember(Name = "imap_user", EmitDefaultValue = false)]
        public string ImapUser { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Secret
        /// </summary>
        [DataMember(Name = "secret", EmitDefaultValue = false)]
        public string Secret { get; set; }

        /// <summary>
        /// A Duration represents the elapsed time between two instants as an int64 nanosecond count. The representation limits the largest representable duration to approximately 290 years.
        /// </summary>
        /// <value>A Duration represents the elapsed time between two instants as an int64 nanosecond count. The representation limits the largest representable duration to approximately 290 years.</value>
        [DataMember(Name = "timeout", EmitDefaultValue = false)]
        public long Timeout { get; set; }

        /// <summary>
        /// Gets or Sets ValidationEmail
        /// </summary>
        [DataMember(Name = "validation_email", EmitDefaultValue = false)]
        public string ValidationEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GodaddyTargetDetails {\n");
            sb.Append("  ImapFqdn: ").Append(ImapFqdn).Append("\n");
            sb.Append("  ImapPassword: ").Append(ImapPassword).Append("\n");
            sb.Append("  ImapPort: ").Append(ImapPort).Append("\n");
            sb.Append("  ImapUser: ").Append(ImapUser).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  ValidationEmail: ").Append(ValidationEmail).Append("\n");
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
            return this.Equals(input as GodaddyTargetDetails);
        }

        /// <summary>
        /// Returns true if GodaddyTargetDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of GodaddyTargetDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GodaddyTargetDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ImapFqdn == input.ImapFqdn ||
                    (this.ImapFqdn != null &&
                    this.ImapFqdn.Equals(input.ImapFqdn))
                ) && 
                (
                    this.ImapPassword == input.ImapPassword ||
                    (this.ImapPassword != null &&
                    this.ImapPassword.Equals(input.ImapPassword))
                ) && 
                (
                    this.ImapPort == input.ImapPort ||
                    (this.ImapPort != null &&
                    this.ImapPort.Equals(input.ImapPort))
                ) && 
                (
                    this.ImapUser == input.ImapUser ||
                    (this.ImapUser != null &&
                    this.ImapUser.Equals(input.ImapUser))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    this.Timeout.Equals(input.Timeout)
                ) && 
                (
                    this.ValidationEmail == input.ValidationEmail ||
                    (this.ValidationEmail != null &&
                    this.ValidationEmail.Equals(input.ValidationEmail))
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
                if (this.ImapFqdn != null)
                {
                    hashCode = (hashCode * 59) + this.ImapFqdn.GetHashCode();
                }
                if (this.ImapPassword != null)
                {
                    hashCode = (hashCode * 59) + this.ImapPassword.GetHashCode();
                }
                if (this.ImapPort != null)
                {
                    hashCode = (hashCode * 59) + this.ImapPort.GetHashCode();
                }
                if (this.ImapUser != null)
                {
                    hashCode = (hashCode * 59) + this.ImapUser.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.Secret != null)
                {
                    hashCode = (hashCode * 59) + this.Secret.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Timeout.GetHashCode();
                if (this.ValidationEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ValidationEmail.GetHashCode();
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
