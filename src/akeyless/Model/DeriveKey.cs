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
    /// DeriveKey
    /// </summary>
    [DataContract(Name = "DeriveKey")]
    public partial class DeriveKey : IEquatable<DeriveKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeriveKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeriveKey() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeriveKey" /> class.
        /// </summary>
        /// <param name="accessibility">for personal password manager (default to &quot;regular&quot;).</param>
        /// <param name="alg">Kdf algorithm (required) (default to &quot;pbkdf2&quot;).</param>
        /// <param name="hashFunction">HashFunction the hash function to use (relevant for pbkdf2) (default to &quot;sha256&quot;).</param>
        /// <param name="iter">IterationCount the number of iterations (required).</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="keyLen">KeyLength the byte length of the generated key (required).</param>
        /// <param name="mem">MemorySizeInKb the memory paramter in kb (relevant for argon2id) (default to 16384).</param>
        /// <param name="name">Static Secret full name (required).</param>
        /// <param name="parallelism">Parallelism the number of threads to use (relevant for argon2id) (default to 1).</param>
        /// <param name="salt">Salt Base64 encoded salt value. If not provided, the salt will be generated as part of the operation. The salt should be securely-generated random bytes, minimum 64 bits, 128 bits is recommended.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        public DeriveKey(string accessibility = "regular", string alg = "pbkdf2", string hashFunction = "sha256", long iter = default(long), bool json = false, long keyLen = default(long), long mem = 16384, string name = default(string), long parallelism = 1, string salt = default(string), string token = default(string), string uidToken = default(string))
        {
            // to ensure "alg" is required (not null)
            if (alg == null)
            {
                throw new ArgumentNullException("alg is a required property for DeriveKey and cannot be null");
            }
            this.Alg = alg;
            this.Iter = iter;
            this.KeyLen = keyLen;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DeriveKey and cannot be null");
            }
            this.Name = name;
            // use default value if no "accessibility" provided
            this.Accessibility = accessibility ?? "regular";
            // use default value if no "hashFunction" provided
            this.HashFunction = hashFunction ?? "sha256";
            this.Json = json;
            this.Mem = mem;
            this.Parallelism = parallelism;
            this.Salt = salt;
            this.Token = token;
            this.UidToken = uidToken;
        }

        /// <summary>
        /// for personal password manager
        /// </summary>
        /// <value>for personal password manager</value>
        [DataMember(Name = "accessibility", EmitDefaultValue = false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// Kdf algorithm
        /// </summary>
        /// <value>Kdf algorithm</value>
        [DataMember(Name = "alg", IsRequired = true, EmitDefaultValue = true)]
        public string Alg { get; set; }

        /// <summary>
        /// HashFunction the hash function to use (relevant for pbkdf2)
        /// </summary>
        /// <value>HashFunction the hash function to use (relevant for pbkdf2)</value>
        [DataMember(Name = "hash-function", EmitDefaultValue = false)]
        public string HashFunction { get; set; }

        /// <summary>
        /// IterationCount the number of iterations
        /// </summary>
        /// <value>IterationCount the number of iterations</value>
        [DataMember(Name = "iter", IsRequired = true, EmitDefaultValue = true)]
        public long Iter { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// KeyLength the byte length of the generated key
        /// </summary>
        /// <value>KeyLength the byte length of the generated key</value>
        [DataMember(Name = "key-len", IsRequired = true, EmitDefaultValue = true)]
        public long KeyLen { get; set; }

        /// <summary>
        /// MemorySizeInKb the memory paramter in kb (relevant for argon2id)
        /// </summary>
        /// <value>MemorySizeInKb the memory paramter in kb (relevant for argon2id)</value>
        [DataMember(Name = "mem", EmitDefaultValue = false)]
        public long Mem { get; set; }

        /// <summary>
        /// Static Secret full name
        /// </summary>
        /// <value>Static Secret full name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Parallelism the number of threads to use (relevant for argon2id)
        /// </summary>
        /// <value>Parallelism the number of threads to use (relevant for argon2id)</value>
        [DataMember(Name = "parallelism", EmitDefaultValue = false)]
        public long Parallelism { get; set; }

        /// <summary>
        /// Salt Base64 encoded salt value. If not provided, the salt will be generated as part of the operation. The salt should be securely-generated random bytes, minimum 64 bits, 128 bits is recommended
        /// </summary>
        /// <value>Salt Base64 encoded salt value. If not provided, the salt will be generated as part of the operation. The salt should be securely-generated random bytes, minimum 64 bits, 128 bits is recommended</value>
        [DataMember(Name = "salt", EmitDefaultValue = false)]
        public string Salt { get; set; }

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
            sb.Append("class DeriveKey {\n");
            sb.Append("  Accessibility: ").Append(Accessibility).Append("\n");
            sb.Append("  Alg: ").Append(Alg).Append("\n");
            sb.Append("  HashFunction: ").Append(HashFunction).Append("\n");
            sb.Append("  Iter: ").Append(Iter).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  KeyLen: ").Append(KeyLen).Append("\n");
            sb.Append("  Mem: ").Append(Mem).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Parallelism: ").Append(Parallelism).Append("\n");
            sb.Append("  Salt: ").Append(Salt).Append("\n");
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
            return this.Equals(input as DeriveKey);
        }

        /// <summary>
        /// Returns true if DeriveKey instances are equal
        /// </summary>
        /// <param name="input">Instance of DeriveKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeriveKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Accessibility == input.Accessibility ||
                    (this.Accessibility != null &&
                    this.Accessibility.Equals(input.Accessibility))
                ) && 
                (
                    this.Alg == input.Alg ||
                    (this.Alg != null &&
                    this.Alg.Equals(input.Alg))
                ) && 
                (
                    this.HashFunction == input.HashFunction ||
                    (this.HashFunction != null &&
                    this.HashFunction.Equals(input.HashFunction))
                ) && 
                (
                    this.Iter == input.Iter ||
                    this.Iter.Equals(input.Iter)
                ) && 
                (
                    this.Json == input.Json ||
                    this.Json.Equals(input.Json)
                ) && 
                (
                    this.KeyLen == input.KeyLen ||
                    this.KeyLen.Equals(input.KeyLen)
                ) && 
                (
                    this.Mem == input.Mem ||
                    this.Mem.Equals(input.Mem)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Parallelism == input.Parallelism ||
                    this.Parallelism.Equals(input.Parallelism)
                ) && 
                (
                    this.Salt == input.Salt ||
                    (this.Salt != null &&
                    this.Salt.Equals(input.Salt))
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
                if (this.Accessibility != null)
                {
                    hashCode = (hashCode * 59) + this.Accessibility.GetHashCode();
                }
                if (this.Alg != null)
                {
                    hashCode = (hashCode * 59) + this.Alg.GetHashCode();
                }
                if (this.HashFunction != null)
                {
                    hashCode = (hashCode * 59) + this.HashFunction.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Iter.GetHashCode();
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                hashCode = (hashCode * 59) + this.KeyLen.GetHashCode();
                hashCode = (hashCode * 59) + this.Mem.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Parallelism.GetHashCode();
                if (this.Salt != null)
                {
                    hashCode = (hashCode * 59) + this.Salt.GetHashCode();
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