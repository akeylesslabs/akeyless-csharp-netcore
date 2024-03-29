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
    /// VerifyPKCS1
    /// </summary>
    [DataContract(Name = "verifyPKCS1")]
    public partial class VerifyPKCS1 : IEquatable<VerifyPKCS1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyPKCS1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VerifyPKCS1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyPKCS1" /> class.
        /// </summary>
        /// <param name="displayId">The display id of the key to use in the verification process.</param>
        /// <param name="hashFunction">HashFunction defines the hash function (e.g. sha-256).</param>
        /// <param name="inputFormat">Select default assumed format for the plaintext message. Currently supported options: [base64].</param>
        /// <param name="itemId">The item id of the key to use in the verification process.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="keyName">The name of the RSA key to use in the verification process (required).</param>
        /// <param name="message">The message to be verified (required).</param>
        /// <param name="prehashed">Markes that the message is already hashed.</param>
        /// <param name="signature">The message&#39;s signature (required).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="version">The version of the key to use for verification.</param>
        public VerifyPKCS1(string displayId = default(string), string hashFunction = default(string), string inputFormat = default(string), long itemId = default(long), bool json = false, string keyName = default(string), string message = default(string), bool prehashed = default(bool), string signature = default(string), string token = default(string), string uidToken = default(string), int version = default(int))
        {
            // to ensure "keyName" is required (not null)
            if (keyName == null)
            {
                throw new ArgumentNullException("keyName is a required property for VerifyPKCS1 and cannot be null");
            }
            this.KeyName = keyName;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for VerifyPKCS1 and cannot be null");
            }
            this.Message = message;
            // to ensure "signature" is required (not null)
            if (signature == null)
            {
                throw new ArgumentNullException("signature is a required property for VerifyPKCS1 and cannot be null");
            }
            this.Signature = signature;
            this.DisplayId = displayId;
            this.HashFunction = hashFunction;
            this.InputFormat = inputFormat;
            this.ItemId = itemId;
            this.Json = json;
            this.Prehashed = prehashed;
            this.Token = token;
            this.UidToken = uidToken;
            this._Version = version;
        }

        /// <summary>
        /// The display id of the key to use in the verification process
        /// </summary>
        /// <value>The display id of the key to use in the verification process</value>
        [DataMember(Name = "display-id", EmitDefaultValue = false)]
        public string DisplayId { get; set; }

        /// <summary>
        /// HashFunction defines the hash function (e.g. sha-256)
        /// </summary>
        /// <value>HashFunction defines the hash function (e.g. sha-256)</value>
        [DataMember(Name = "hash-function", EmitDefaultValue = false)]
        public string HashFunction { get; set; }

        /// <summary>
        /// Select default assumed format for the plaintext message. Currently supported options: [base64]
        /// </summary>
        /// <value>Select default assumed format for the plaintext message. Currently supported options: [base64]</value>
        [DataMember(Name = "input-format", EmitDefaultValue = false)]
        public string InputFormat { get; set; }

        /// <summary>
        /// The item id of the key to use in the verification process
        /// </summary>
        /// <value>The item id of the key to use in the verification process</value>
        [DataMember(Name = "item-id", EmitDefaultValue = false)]
        public long ItemId { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// The name of the RSA key to use in the verification process
        /// </summary>
        /// <value>The name of the RSA key to use in the verification process</value>
        [DataMember(Name = "key-name", IsRequired = true, EmitDefaultValue = true)]
        public string KeyName { get; set; }

        /// <summary>
        /// The message to be verified
        /// </summary>
        /// <value>The message to be verified</value>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Markes that the message is already hashed
        /// </summary>
        /// <value>Markes that the message is already hashed</value>
        [DataMember(Name = "prehashed", EmitDefaultValue = true)]
        public bool Prehashed { get; set; }

        /// <summary>
        /// The message&#39;s signature
        /// </summary>
        /// <value>The message&#39;s signature</value>
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
        /// The version of the key to use for verification
        /// </summary>
        /// <value>The version of the key to use for verification</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int _Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VerifyPKCS1 {\n");
            sb.Append("  DisplayId: ").Append(DisplayId).Append("\n");
            sb.Append("  HashFunction: ").Append(HashFunction).Append("\n");
            sb.Append("  InputFormat: ").Append(InputFormat).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  KeyName: ").Append(KeyName).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Prehashed: ").Append(Prehashed).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as VerifyPKCS1);
        }

        /// <summary>
        /// Returns true if VerifyPKCS1 instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyPKCS1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyPKCS1 input)
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
                    this.HashFunction == input.HashFunction ||
                    (this.HashFunction != null &&
                    this.HashFunction.Equals(input.HashFunction))
                ) && 
                (
                    this.InputFormat == input.InputFormat ||
                    (this.InputFormat != null &&
                    this.InputFormat.Equals(input.InputFormat))
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
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Prehashed == input.Prehashed ||
                    this.Prehashed.Equals(input.Prehashed)
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
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
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
                if (this.HashFunction != null)
                {
                    hashCode = (hashCode * 59) + this.HashFunction.GetHashCode();
                }
                if (this.InputFormat != null)
                {
                    hashCode = (hashCode * 59) + this.InputFormat.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ItemId.GetHashCode();
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                if (this.KeyName != null)
                {
                    hashCode = (hashCode * 59) + this.KeyName.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Prehashed.GetHashCode();
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
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
