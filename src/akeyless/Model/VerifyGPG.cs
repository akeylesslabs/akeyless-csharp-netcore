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
    /// VerifyGPG
    /// </summary>
    [DataContract(Name = "verifyGPG")]
    public partial class VerifyGPG : IEquatable<VerifyGPG>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyGPG" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VerifyGPG() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyGPG" /> class.
        /// </summary>
        /// <param name="displayId">The display id of the key to use in the encryption process.</param>
        /// <param name="itemId">The item id of the key to use in the encryption process.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="keyName">The name of the key to use in the encryption process (required).</param>
        /// <param name="passphrase">Passphrase that was used to generate the key.</param>
        /// <param name="signature">The signature to be verified in base64 format (required).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        public VerifyGPG(string displayId = default(string), long itemId = default(long), bool json = false, string keyName = default(string), string passphrase = default(string), string signature = default(string), string token = default(string), string uidToken = default(string))
        {
            // to ensure "keyName" is required (not null)
            if (keyName == null)
            {
                throw new ArgumentNullException("keyName is a required property for VerifyGPG and cannot be null");
            }
            this.KeyName = keyName;
            // to ensure "signature" is required (not null)
            if (signature == null)
            {
                throw new ArgumentNullException("signature is a required property for VerifyGPG and cannot be null");
            }
            this.Signature = signature;
            this.DisplayId = displayId;
            this.ItemId = itemId;
            this.Json = json;
            this.Passphrase = passphrase;
            this.Token = token;
            this.UidToken = uidToken;
        }

        /// <summary>
        /// The display id of the key to use in the encryption process
        /// </summary>
        /// <value>The display id of the key to use in the encryption process</value>
        [DataMember(Name = "display-id", EmitDefaultValue = false)]
        public string DisplayId { get; set; }

        /// <summary>
        /// The item id of the key to use in the encryption process
        /// </summary>
        /// <value>The item id of the key to use in the encryption process</value>
        [DataMember(Name = "item-id", EmitDefaultValue = false)]
        public long ItemId { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// The name of the key to use in the encryption process
        /// </summary>
        /// <value>The name of the key to use in the encryption process</value>
        [DataMember(Name = "key-name", IsRequired = true, EmitDefaultValue = true)]
        public string KeyName { get; set; }

        /// <summary>
        /// Passphrase that was used to generate the key
        /// </summary>
        /// <value>Passphrase that was used to generate the key</value>
        [DataMember(Name = "passphrase", EmitDefaultValue = false)]
        public string Passphrase { get; set; }

        /// <summary>
        /// The signature to be verified in base64 format
        /// </summary>
        /// <value>The signature to be verified in base64 format</value>
        [DataMember(Name = "signature", IsRequired = true, EmitDefaultValue = true)]
        public string Signature { get; set; }

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
            sb.Append("class VerifyGPG {\n");
            sb.Append("  DisplayId: ").Append(DisplayId).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  KeyName: ").Append(KeyName).Append("\n");
            sb.Append("  Passphrase: ").Append(Passphrase).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
            return this.Equals(input as VerifyGPG);
        }

        /// <summary>
        /// Returns true if VerifyGPG instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyGPG to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyGPG input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisplayId == input.DisplayId ||
                    (this.DisplayId != null &&
                    this.DisplayId.Equals(input.DisplayId))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    this.ItemId.Equals(input.ItemId)
                ) && 
                (
                    this.Json == input.Json ||
                    this.Json.Equals(input.Json)
                ) && 
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))
                ) && 
                (
                    this.Passphrase == input.Passphrase ||
                    (this.Passphrase != null &&
                    this.Passphrase.Equals(input.Passphrase))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
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
                if (this.DisplayId != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ItemId.GetHashCode();
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                if (this.KeyName != null)
                {
                    hashCode = (hashCode * 59) + this.KeyName.GetHashCode();
                }
                if (this.Passphrase != null)
                {
                    hashCode = (hashCode * 59) + this.Passphrase.GetHashCode();
                }
                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
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