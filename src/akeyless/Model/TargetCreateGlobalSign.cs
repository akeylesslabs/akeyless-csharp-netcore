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
    /// TargetCreateGlobalSign
    /// </summary>
    [DataContract(Name = "targetCreateGlobalSign")]
    public partial class TargetCreateGlobalSign : IEquatable<TargetCreateGlobalSign>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetCreateGlobalSign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TargetCreateGlobalSign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetCreateGlobalSign" /> class.
        /// </summary>
        /// <param name="contactEmail">Email of the GlobalSign GCC account contact (required).</param>
        /// <param name="contactFirstName">First name of the GlobalSign GCC account contact (required).</param>
        /// <param name="contactLastName">Last name of the GlobalSign GCC account contact (required).</param>
        /// <param name="contactPhone">Telephone of the GlobalSign GCC account contact (required).</param>
        /// <param name="description">Description of the object.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="key">The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used).</param>
        /// <param name="maxVersions">Set the maximum number of versions, limited by the account settings defaults..</param>
        /// <param name="name">Target name (required).</param>
        /// <param name="password">Password of the GlobalSign GCC account (required).</param>
        /// <param name="profileId">Profile ID of the GlobalSign GCC account (required).</param>
        /// <param name="timeout">Timeout waiting for certificate validation in Duration format (1h - 1 Hour, 20m - 20 Minutes, 33m3s - 33 Minutes and 3 Seconds), maximum 1h. (default to &quot;5m&quot;).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="username">Username of the GlobalSign GCC account (required).</param>
        public TargetCreateGlobalSign(string contactEmail = default(string), string contactFirstName = default(string), string contactLastName = default(string), string contactPhone = default(string), string description = default(string), bool json = false, string key = default(string), string maxVersions = default(string), string name = default(string), string password = default(string), string profileId = default(string), string timeout = "5m", string token = default(string), string uidToken = default(string), string username = default(string))
        {
            // to ensure "contactEmail" is required (not null)
            if (contactEmail == null)
            {
                throw new ArgumentNullException("contactEmail is a required property for TargetCreateGlobalSign and cannot be null");
            }
            this.ContactEmail = contactEmail;
            // to ensure "contactFirstName" is required (not null)
            if (contactFirstName == null)
            {
                throw new ArgumentNullException("contactFirstName is a required property for TargetCreateGlobalSign and cannot be null");
            }
            this.ContactFirstName = contactFirstName;
            // to ensure "contactLastName" is required (not null)
            if (contactLastName == null)
            {
                throw new ArgumentNullException("contactLastName is a required property for TargetCreateGlobalSign and cannot be null");
            }
            this.ContactLastName = contactLastName;
            // to ensure "contactPhone" is required (not null)
            if (contactPhone == null)
            {
                throw new ArgumentNullException("contactPhone is a required property for TargetCreateGlobalSign and cannot be null");
            }
            this.ContactPhone = contactPhone;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TargetCreateGlobalSign and cannot be null");
            }
            this.Name = name;
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new ArgumentNullException("password is a required property for TargetCreateGlobalSign and cannot be null");
            }
            this.Password = password;
            // to ensure "profileId" is required (not null)
            if (profileId == null)
            {
                throw new ArgumentNullException("profileId is a required property for TargetCreateGlobalSign and cannot be null");
            }
            this.ProfileId = profileId;
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new ArgumentNullException("username is a required property for TargetCreateGlobalSign and cannot be null");
            }
            this.Username = username;
            this.Description = description;
            this.Json = json;
            this.Key = key;
            this.MaxVersions = maxVersions;
            // use default value if no "timeout" provided
            this.Timeout = timeout ?? "5m";
            this.Token = token;
            this.UidToken = uidToken;
        }

        /// <summary>
        /// Email of the GlobalSign GCC account contact
        /// </summary>
        /// <value>Email of the GlobalSign GCC account contact</value>
        [DataMember(Name = "contact-email", IsRequired = true, EmitDefaultValue = true)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// First name of the GlobalSign GCC account contact
        /// </summary>
        /// <value>First name of the GlobalSign GCC account contact</value>
        [DataMember(Name = "contact-first-name", IsRequired = true, EmitDefaultValue = true)]
        public string ContactFirstName { get; set; }

        /// <summary>
        /// Last name of the GlobalSign GCC account contact
        /// </summary>
        /// <value>Last name of the GlobalSign GCC account contact</value>
        [DataMember(Name = "contact-last-name", IsRequired = true, EmitDefaultValue = true)]
        public string ContactLastName { get; set; }

        /// <summary>
        /// Telephone of the GlobalSign GCC account contact
        /// </summary>
        /// <value>Telephone of the GlobalSign GCC account contact</value>
        [DataMember(Name = "contact-phone", IsRequired = true, EmitDefaultValue = true)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// Description of the object
        /// </summary>
        /// <value>Description of the object</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used)
        /// </summary>
        /// <value>The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used)</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Set the maximum number of versions, limited by the account settings defaults.
        /// </summary>
        /// <value>Set the maximum number of versions, limited by the account settings defaults.</value>
        [DataMember(Name = "max-versions", EmitDefaultValue = false)]
        public string MaxVersions { get; set; }

        /// <summary>
        /// Target name
        /// </summary>
        /// <value>Target name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Password of the GlobalSign GCC account
        /// </summary>
        /// <value>Password of the GlobalSign GCC account</value>
        [DataMember(Name = "password", IsRequired = true, EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Profile ID of the GlobalSign GCC account
        /// </summary>
        /// <value>Profile ID of the GlobalSign GCC account</value>
        [DataMember(Name = "profile-id", IsRequired = true, EmitDefaultValue = true)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Timeout waiting for certificate validation in Duration format (1h - 1 Hour, 20m - 20 Minutes, 33m3s - 33 Minutes and 3 Seconds), maximum 1h.
        /// </summary>
        /// <value>Timeout waiting for certificate validation in Duration format (1h - 1 Hour, 20m - 20 Minutes, 33m3s - 33 Minutes and 3 Seconds), maximum 1h.</value>
        [DataMember(Name = "timeout", EmitDefaultValue = false)]
        public string Timeout { get; set; }

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
        /// Username of the GlobalSign GCC account
        /// </summary>
        /// <value>Username of the GlobalSign GCC account</value>
        [DataMember(Name = "username", IsRequired = true, EmitDefaultValue = true)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TargetCreateGlobalSign {\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  ContactFirstName: ").Append(ContactFirstName).Append("\n");
            sb.Append("  ContactLastName: ").Append(ContactLastName).Append("\n");
            sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  MaxVersions: ").Append(MaxVersions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TargetCreateGlobalSign);
        }

        /// <summary>
        /// Returns true if TargetCreateGlobalSign instances are equal
        /// </summary>
        /// <param name="input">Instance of TargetCreateGlobalSign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TargetCreateGlobalSign input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContactEmail == input.ContactEmail ||
                    (this.ContactEmail != null &&
                    this.ContactEmail.Equals(input.ContactEmail))
                ) && 
                (
                    this.ContactFirstName == input.ContactFirstName ||
                    (this.ContactFirstName != null &&
                    this.ContactFirstName.Equals(input.ContactFirstName))
                ) && 
                (
                    this.ContactLastName == input.ContactLastName ||
                    (this.ContactLastName != null &&
                    this.ContactLastName.Equals(input.ContactLastName))
                ) && 
                (
                    this.ContactPhone == input.ContactPhone ||
                    (this.ContactPhone != null &&
                    this.ContactPhone.Equals(input.ContactPhone))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Json == input.Json ||
                    this.Json.Equals(input.Json)
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.MaxVersions == input.MaxVersions ||
                    (this.MaxVersions != null &&
                    this.MaxVersions.Equals(input.MaxVersions))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.ProfileId == input.ProfileId ||
                    (this.ProfileId != null &&
                    this.ProfileId.Equals(input.ProfileId))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
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
                if (this.ContactEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ContactEmail.GetHashCode();
                }
                if (this.ContactFirstName != null)
                {
                    hashCode = (hashCode * 59) + this.ContactFirstName.GetHashCode();
                }
                if (this.ContactLastName != null)
                {
                    hashCode = (hashCode * 59) + this.ContactLastName.GetHashCode();
                }
                if (this.ContactPhone != null)
                {
                    hashCode = (hashCode * 59) + this.ContactPhone.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.MaxVersions != null)
                {
                    hashCode = (hashCode * 59) + this.MaxVersions.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.ProfileId != null)
                {
                    hashCode = (hashCode * 59) + this.ProfileId.GetHashCode();
                }
                if (this.Timeout != null)
                {
                    hashCode = (hashCode * 59) + this.Timeout.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                if (this.UidToken != null)
                {
                    hashCode = (hashCode * 59) + this.UidToken.GetHashCode();
                }
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
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