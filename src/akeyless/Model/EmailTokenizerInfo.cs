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
    /// EmailTokenizerInfo represents a tokenizer that specifically tokenizes emails
    /// </summary>
    [DataContract(Name = "EmailTokenizerInfo")]
    public partial class EmailTokenizerInfo : IEquatable<EmailTokenizerInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTokenizerInfo" /> class.
        /// </summary>
        /// <param name="domainSuffixLength">What length of a random domain suffix to generate used only if FixedDomainSuffix is empty.</param>
        /// <param name="fixedDomainSuffix">if FixedDomainSuffix isn&#39;t empty, it will be appended to the output.</param>
        /// <param name="keepPrefixLength">How many letters of the plaintext to keep in the output.</param>
        public EmailTokenizerInfo(long domainSuffixLength = default(long), string fixedDomainSuffix = default(string), long keepPrefixLength = default(long))
        {
            this.DomainSuffixLength = domainSuffixLength;
            this.FixedDomainSuffix = fixedDomainSuffix;
            this.KeepPrefixLength = keepPrefixLength;
        }

        /// <summary>
        /// What length of a random domain suffix to generate used only if FixedDomainSuffix is empty
        /// </summary>
        /// <value>What length of a random domain suffix to generate used only if FixedDomainSuffix is empty</value>
        [DataMember(Name = "domain_suffix_length", EmitDefaultValue = false)]
        public long DomainSuffixLength { get; set; }

        /// <summary>
        /// if FixedDomainSuffix isn&#39;t empty, it will be appended to the output
        /// </summary>
        /// <value>if FixedDomainSuffix isn&#39;t empty, it will be appended to the output</value>
        [DataMember(Name = "fixed_domain_suffix", EmitDefaultValue = false)]
        public string FixedDomainSuffix { get; set; }

        /// <summary>
        /// How many letters of the plaintext to keep in the output
        /// </summary>
        /// <value>How many letters of the plaintext to keep in the output</value>
        [DataMember(Name = "keep_prefix_length", EmitDefaultValue = false)]
        public long KeepPrefixLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailTokenizerInfo {\n");
            sb.Append("  DomainSuffixLength: ").Append(DomainSuffixLength).Append("\n");
            sb.Append("  FixedDomainSuffix: ").Append(FixedDomainSuffix).Append("\n");
            sb.Append("  KeepPrefixLength: ").Append(KeepPrefixLength).Append("\n");
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
            return this.Equals(input as EmailTokenizerInfo);
        }

        /// <summary>
        /// Returns true if EmailTokenizerInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailTokenizerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailTokenizerInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DomainSuffixLength == input.DomainSuffixLength ||
                    this.DomainSuffixLength.Equals(input.DomainSuffixLength)
                ) && 
                (
                    this.FixedDomainSuffix == input.FixedDomainSuffix ||
                    (this.FixedDomainSuffix != null &&
                    this.FixedDomainSuffix.Equals(input.FixedDomainSuffix))
                ) && 
                (
                    this.KeepPrefixLength == input.KeepPrefixLength ||
                    this.KeepPrefixLength.Equals(input.KeepPrefixLength)
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
                hashCode = (hashCode * 59) + this.DomainSuffixLength.GetHashCode();
                if (this.FixedDomainSuffix != null)
                {
                    hashCode = (hashCode * 59) + this.FixedDomainSuffix.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.KeepPrefixLength.GetHashCode();
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
