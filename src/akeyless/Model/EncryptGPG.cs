/*
 * Akeyless API
 *
 * The purpose of this application is to provide access to Akeyless API.
 *
 * The version of the OpenAPI document: 3.0
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
    /// EncryptGPG
    /// </summary>
    [DataContract(Name = "encryptGPG")]
    public partial class EncryptGPG : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptGPG" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EncryptGPG() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptGPG" /> class.
        /// </summary>
        /// <param name="displayId">The display id of the key to use in the encryption process.</param>
        /// <param name="inputFormat">If specified, the plaintext input is assumed to be formatted accordingly. Current supported options: [base64].</param>
        /// <param name="itemId">The item id of the key to use in the encryption process.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="keyName">The name of the key to use in the encryption process (required).</param>
        /// <param name="plaintext">Data to be encrypted (required).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        public EncryptGPG(string displayId = default(string), string inputFormat = default(string), long itemId = default(long), bool json = false, string keyName = default(string), string plaintext = default(string), string token = default(string), string uidToken = default(string))
        {
            // to ensure "keyName" is required (not null)
            if (keyName == null)
            {
                throw new ArgumentNullException("keyName is a required property for EncryptGPG and cannot be null");
            }
            this.KeyName = keyName;
            // to ensure "plaintext" is required (not null)
            if (plaintext == null)
            {
                throw new ArgumentNullException("plaintext is a required property for EncryptGPG and cannot be null");
            }
            this.Plaintext = plaintext;
            this.DisplayId = displayId;
            this.InputFormat = inputFormat;
            this.ItemId = itemId;
            this.Json = json;
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
        /// If specified, the plaintext input is assumed to be formatted accordingly. Current supported options: [base64]
        /// </summary>
        /// <value>If specified, the plaintext input is assumed to be formatted accordingly. Current supported options: [base64]</value>
        [DataMember(Name = "input-format", EmitDefaultValue = false)]
        public string InputFormat { get; set; }

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
        /// Data to be encrypted
        /// </summary>
        /// <value>Data to be encrypted</value>
        [DataMember(Name = "plaintext", IsRequired = true, EmitDefaultValue = true)]
        public string Plaintext { get; set; }

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
            sb.Append("class EncryptGPG {\n");
            sb.Append("  DisplayId: ").Append(DisplayId).Append("\n");
            sb.Append("  InputFormat: ").Append(InputFormat).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  KeyName: ").Append(KeyName).Append("\n");
            sb.Append("  Plaintext: ").Append(Plaintext).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
