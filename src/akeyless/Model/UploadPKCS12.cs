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
    /// UploadPKCS12
    /// </summary>
    [DataContract]
    public partial class UploadPKCS12 :  IEquatable<UploadPKCS12>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadPKCS12" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UploadPKCS12() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadPKCS12" /> class.
        /// </summary>
        /// <param name="customerFrgId">The customer fragment ID that will be used to split the key (if empty, the key will be created independently of a customer fragment).</param>
        /// <param name="_in">PKCS#12 input file (private key and certificate only) (required).</param>
        /// <param name="metadata">A metadata about the key.</param>
        /// <param name="name">Name of key to be created (required).</param>
        /// <param name="passphrase">Passphrase to unlock the pkcs#12 bundle (required).</param>
        /// <param name="password">Required only when the authentication process requires a username and password.</param>
        /// <param name="splitLevel">The number of fragments that the item will be split into (default to 2).</param>
        /// <param name="tag">List of the tags attached to this key.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="username">Required only when the authentication process requires a username and password.</param>
        public UploadPKCS12(string customerFrgId = default(string), string _in = default(string), string metadata = default(string), string name = default(string), string passphrase = default(string), string password = default(string), long splitLevel = 2, List<string> tag = default(List<string>), string token = default(string), string uidToken = default(string), string username = default(string))
        {
            // to ensure "_in" is required (not null)
            this.In = _in ?? throw new ArgumentNullException("_in is a required property for UploadPKCS12 and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for UploadPKCS12 and cannot be null");
            // to ensure "passphrase" is required (not null)
            this.Passphrase = passphrase ?? throw new ArgumentNullException("passphrase is a required property for UploadPKCS12 and cannot be null");
            this.CustomerFrgId = customerFrgId;
            this.Metadata = metadata;
            this.Password = password;
            this.SplitLevel = splitLevel;
            this.Tag = tag;
            this.Token = token;
            this.UidToken = uidToken;
            this.Username = username;
        }
        
        /// <summary>
        /// The customer fragment ID that will be used to split the key (if empty, the key will be created independently of a customer fragment)
        /// </summary>
        /// <value>The customer fragment ID that will be used to split the key (if empty, the key will be created independently of a customer fragment)</value>
        [DataMember(Name="customer-frg-id", EmitDefaultValue=false)]
        public string CustomerFrgId { get; set; }

        /// <summary>
        /// PKCS#12 input file (private key and certificate only)
        /// </summary>
        /// <value>PKCS#12 input file (private key and certificate only)</value>
        [DataMember(Name="in", EmitDefaultValue=false)]
        public string In { get; set; }

        /// <summary>
        /// A metadata about the key
        /// </summary>
        /// <value>A metadata about the key</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// Name of key to be created
        /// </summary>
        /// <value>Name of key to be created</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Passphrase to unlock the pkcs#12 bundle
        /// </summary>
        /// <value>Passphrase to unlock the pkcs#12 bundle</value>
        [DataMember(Name="passphrase", EmitDefaultValue=false)]
        public string Passphrase { get; set; }

        /// <summary>
        /// Required only when the authentication process requires a username and password
        /// </summary>
        /// <value>Required only when the authentication process requires a username and password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// The number of fragments that the item will be split into
        /// </summary>
        /// <value>The number of fragments that the item will be split into</value>
        [DataMember(Name="split-level", EmitDefaultValue=false)]
        public long SplitLevel { get; set; }

        /// <summary>
        /// List of the tags attached to this key
        /// </summary>
        /// <value>List of the tags attached to this key</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public List<string> Tag { get; set; }

        /// <summary>
        /// Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)
        /// </summary>
        /// <value>Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// The universal identity token, Required only for universal_identity authentication
        /// </summary>
        /// <value>The universal identity token, Required only for universal_identity authentication</value>
        [DataMember(Name="uid-token", EmitDefaultValue=false)]
        public string UidToken { get; set; }

        /// <summary>
        /// Required only when the authentication process requires a username and password
        /// </summary>
        /// <value>Required only when the authentication process requires a username and password</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadPKCS12 {\n");
            sb.Append("  CustomerFrgId: ").Append(CustomerFrgId).Append("\n");
            sb.Append("  In: ").Append(In).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Passphrase: ").Append(Passphrase).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  SplitLevel: ").Append(SplitLevel).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as UploadPKCS12);
        }

        /// <summary>
        /// Returns true if UploadPKCS12 instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadPKCS12 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadPKCS12 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomerFrgId == input.CustomerFrgId ||
                    (this.CustomerFrgId != null &&
                    this.CustomerFrgId.Equals(input.CustomerFrgId))
                ) && 
                (
                    this.In == input.In ||
                    (this.In != null &&
                    this.In.Equals(input.In))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Passphrase == input.Passphrase ||
                    (this.Passphrase != null &&
                    this.Passphrase.Equals(input.Passphrase))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.SplitLevel == input.SplitLevel ||
                    this.SplitLevel.Equals(input.SplitLevel)
                ) && 
                (
                    this.Tag == input.Tag ||
                    this.Tag != null &&
                    input.Tag != null &&
                    this.Tag.SequenceEqual(input.Tag)
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
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.CustomerFrgId != null)
                    hashCode = hashCode * 59 + this.CustomerFrgId.GetHashCode();
                if (this.In != null)
                    hashCode = hashCode * 59 + this.In.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Passphrase != null)
                    hashCode = hashCode * 59 + this.Passphrase.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                hashCode = hashCode * 59 + this.SplitLevel.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.UidToken != null)
                    hashCode = hashCode * 59 + this.UidToken.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
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
